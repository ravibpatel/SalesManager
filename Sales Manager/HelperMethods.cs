using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Sales_Manager
{
    static class HelperMethods
    {
        #region Fix Fonts

        public static void FixFonts(Form form)
        {
            form.Font = SystemFonts.MessageBoxFont;
            SetFont(form.Controls);
        }

        private static void SetFont(IEnumerable controls)
        {
            foreach (Control control in controls)
            {
                var font = new Font(SystemFonts.MessageBoxFont.FontFamily, control.Font.SizeInPoints, control.Font.Style,
                                    GraphicsUnit.Point);
                control.Font = font;
                if (control.HasChildren)
                {
                    SetFont(control.Controls);
                }
            }
        }

        #endregion

        /// <summary>
        /// Gets the 12:00:00 instance of a DateTime
        /// </summary>
        public static DateTime AbsoluteStart(this DateTime dateTime)
        {
            return dateTime.Date;
        }

        /// <summary>
        /// Gets the 11:59:59 instance of a DateTime
        /// </summary>
        public static DateTime AbsoluteEnd(this DateTime dateTime)
        {
            return AbsoluteStart(dateTime).AddDays(1).AddTicks(-1);
        }

        public static void ReportProgress(this BackgroundWorker backgroundWorker, int count, int total, object userState)
        {
            var progress = count * 100 / total;
            backgroundWorker.ReportProgress(progress, userState);
        }

        public static void ListViewToCSV(ListView listView, string filePath, bool includeHidden)
        {
            //make header string
            StringBuilder result = new StringBuilder();
            WriteCSVRow(result, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listView.Columns[i].Text);

            //export data rows
            foreach (ListViewItem listItem in listView.Items)
                WriteCSVRow(result, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listItem.SubItems[i].Text);

            File.WriteAllText(filePath, result.ToString());
        }

        private static void WriteCSVRow(StringBuilder result, int itemsCount, Func<int, bool> isColumnNeeded, Func<int, string> columnValue)
        {
            bool isFirstTime = true;
            for (int i = 0; i < itemsCount; i++)
            {
                if (!isColumnNeeded(i))
                    continue;

                if (!isFirstTime)
                    result.Append(",");
                isFirstTime = false;

                result.Append($"\"{columnValue(i)}\"");
            }
            result.AppendLine();
        }
    }
}
