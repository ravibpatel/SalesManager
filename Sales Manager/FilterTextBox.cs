using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace New_Menu_Editor
{
    class FilterTextBox : TextBox
    {
        private Button ClearButton { get; set; }

        [Category("Appearance")]
        [Description("Image for clear button.")]
        public Image ClearButtonImage { get; set; }

        protected override void OnCreateControl()
        {
            if (!Controls.Contains(ClearButton))
            {
                ClearButton = new Button
                                {
                                    Size = new Size(32, ClientSize.Height + 2),
                                    FlatStyle = FlatStyle.Flat,
                                    Image = ClearButtonImage,
                                    Dock = DockStyle.Right,
                                    Visible = false,
                                    Cursor = Cursors.Default
                                };
                ClearButton.Click += delegate
                                        {
                                            Clear();
                                        };
                Controls.Add(ClearButton);

                // Send EM_SETMARGINS to prevent text from disappearing underneath the button.
                SendMessage(Handle, 0xd3, (IntPtr)2, (IntPtr)(ClearButton.Width << 16));
            }
            base.OnCreateControl();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            ClearButton.Visible = !string.IsNullOrEmpty(Text);
        }
    }
}
