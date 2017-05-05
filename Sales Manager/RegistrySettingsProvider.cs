using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Sales_Manager
{
    internal class RegistrySettingsProvider : SettingsProvider
    {
        public override string ApplicationName
        {
            get { return Application.ProductName; }
            set { }
        }

        public override string Name => "RegistrySettingsProvider";

        public override void Initialize(string name, NameValueCollection col)
        {
            base.Initialize(ApplicationName, col);
        }

        // SetPropertyValue is invoked when ApplicationSettingsBase.Save is called
        // Application Settings Base makes sure to pass each provider only the values
        // marked for that provider.
        public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection propvals)
        {
            // Iterate through the settings to be stored
            // Only IsDirty=true properties should be included in propvals
            foreach (SettingsPropertyValue propval in propvals)
            {
                // NOTE: this provider allows setting to both user- and application-scoped
                // Settings.Default. The default provider for ApplicationSettingsBase - 
                // LocalFileSettingsProvider - is read-only for application-scoped setting. This 
                // is an example of a policy that a provider may need to enforce for implementation,
                // security or other reasons.
                if (propval.SerializedValue != null)
                    GetRegKey(propval.Property).SetValue(propval.Name, propval.SerializedValue);
            }
        }

        public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context,
                                                                          SettingsPropertyCollection props)
        {
            // Create new collection of values
            var values = new SettingsPropertyValueCollection();

            // Iterate through the settings to be retrieved
            foreach (SettingsProperty setting in props)
            {
                var value = new SettingsPropertyValue(setting)
                    {
                        IsDirty = false,
                        SerializedValue = GetRegKey(setting).GetValue(setting.Name)
                    };
                values.Add(value);
            }
            return values;
        }

        // Helper method: fetches correct registry subkey.
        // HKLM is used for settings marked as application-scoped.
        // HKLU is used for settings marked as user-scoped.
        private RegistryKey GetRegKey(SettingsProperty prop)
        {
            RegistryKey regKey = IsUserScoped(prop) ? Registry.CurrentUser : Registry.LocalMachine;

            regKey = regKey.CreateSubKey(GetSubKeyPath());
            return regKey;
        }

        // Helper method: walks the "attribute bag" for a given property
        // to determine if it is user-scoped or not.
        // Note that this provider does not enforce other rules, such as 
        //   - unknown attributes
        //   - improper attribute combinations (e.g. both user and app - this implementation
        //     would say true for user-scoped regardless of existence of app-scoped)
        private bool IsUserScoped(SettingsProperty prop)
        {
            return
                (from DictionaryEntry d in prop.Attributes select (Attribute) d.Value)
                    .OfType<UserScopedSettingAttribute>().Any();
        }

        // Builds a key path based on the CompanyName, ProductName attributes in 
        // the AssemblyInfo file (editable directly or within the Project Properties UI)
        private string GetSubKeyPath()
        {
            return "Software\\" + Application.CompanyName + "\\" + Application.ProductName;
        }
    }
}