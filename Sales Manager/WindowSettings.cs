using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sales_Manager
{
    [Serializable]
    public class WindowSettings
    {
        public Point Location { get; set; }
        public Size Size { get; set; }
        public FormWindowState WindowState { get; set; }
        public int[] SplitterDistances { get; set; }
        public int[] SplitterSizes { get; set; }

        public WindowSettings()
        {
            // default to an invalid location
            Location = new Point(Int32.MinValue, Int32.MinValue);
        }

        /// <summary>
        /// Record a form's position and that of several splitters.
        /// </summary>
        /// <param name="windowSettings">Where the settings should be recorded,
        /// or null.</param>
        /// <param name="form">The form to record. May be null if you just want
        /// to record splitter positions.</param>
        /// <param name="splitters">The splitters to record. You can change
        /// some entries to null if you no longer use that position in the
        /// list.</param>
        /// <returns>The windowSettings parameter, or a new WindowSettings
        /// object if that was null.</returns>
        public static WindowSettings Record(
            WindowSettings windowSettings,
            Form form,
            params SplitContainer[] splitters)
        {
            if (windowSettings == null)
            {
                windowSettings = new WindowSettings();
            }
            windowSettings.Record(form, splitters);
            return windowSettings;
        }

        /// <summary>
        /// Record a form's position and that of several splitters.
        /// </summary>
        /// <param name="form">The form to record. May be null if you just want
        /// to record splitter positions.</param>
        /// <param name="splitters">The splitters to record. You can change
        /// some entries to null if you no longer use that position in the
        /// list.</param>
        public void Record(Form form, params SplitContainer[] splitters)
        {
            bool shouldRecordSplitters;
            if (form == null)
            {
                shouldRecordSplitters = false;
                foreach (var splitter in splitters)
                {
                    if (splitter != null)
                    {
                        var findForm = splitter.FindForm();
                        if (findForm != null)
                        {
                            var formState = findForm.WindowState;
                            shouldRecordSplitters =
                                formState != FormWindowState.Minimized;
                        }
                        break;
                    }
                }
            }
            else
            {
                switch (form.WindowState)
                {
                    case FormWindowState.Maximized:
                        RecordWindowPosition(form.RestoreBounds);
                        shouldRecordSplitters = true;
                        break;
                    case FormWindowState.Normal:
                        shouldRecordSplitters =
                            RecordWindowPosition(form.Bounds);
                        break;
                    default:
                        // Don't record anything when closing while minimized.
                        return;
                }
                WindowState = form.WindowState;
            }

            if (shouldRecordSplitters)
            {
                RecordSplitters(splitters);
            }
        }

        /// <summary>
        /// Restore a form's position and that of several splitters.
        /// </summary>
        /// <param name="windowSettings">Holds the settings to restore.</param>
        /// <param name="form">The form to restore. May be null if you just want
        /// to record splitter positions.</param>
        /// <param name="splitters">The splitters to restore. You can change
        /// some entries to null if you no longer use that position in the
        /// list.</param>
        public static void Restore(
            WindowSettings windowSettings,
            Form form,
            params SplitContainer[] splitters)
        {
            if (windowSettings != null)
            {
                windowSettings.Restore(form, splitters);
            }
        }

        /// <summary>
        /// Restore a form's position and that of several splitters.
        /// </summary>
        /// <param name="form">The form to restore. May be null if you just want
        /// to record splitter positions.</param>
        /// <param name="splitters">The splitters to restore. You can change
        /// some entries to null if you no longer use that position in the
        /// list.</param>
        public void Restore(Form form, params SplitContainer[] splitters)
        {
            if (form == null)
            {
                RestoreSplitters(splitters);
            }
            else if (IsOnScreen(Location, Size))
            {
                form.Location = Location;
                form.Size = Size;
                form.StartPosition = FormStartPosition.Manual;
                form.WindowState = WindowState;
                RestoreSplitters(splitters);
            }
            else
            {
                form.WindowState = WindowState;
            }
        }

        private void RestoreSplitters(SplitContainer[] splitters)
        {
            for (
                int i = 0;
                i < splitters.Length &&
                SplitterDistances != null &&
                i < SplitterDistances.Length;
                i++)
            {
                var splitter = splitters[i];
                if (splitter == null)
                {
                    continue;
                }
                int splitterDistance = SplitterDistances[i];
                if (SplitterSizes != null)
                {
                    splitterDistance =
                        splitterDistance * GetSplitterSize(splitter) / SplitterSizes[i];
                }
                int splitterSize = GetSplitterSize(splitter);
                bool isDistanceLegal =
                    splitter.Panel1MinSize <= splitterDistance
                    && splitterDistance <= splitterSize - splitter.Panel2MinSize;
                if (isDistanceLegal)
                {
                    splitter.SplitterDistance = splitterDistance;
                }
            }
        }

        private static int GetSplitterSize(SplitContainer splitter)
        {
            int splitterSize =
                splitter.Orientation == Orientation.Vertical
                ? splitter.PreferredSize.Width
                : splitter.PreferredSize.Height;
            return splitterSize;
        }

        private bool RecordWindowPosition(Rectangle bounds)
        {
            bool isOnScreen = IsOnScreen(bounds.Location, bounds.Size);
            if (isOnScreen)
            {
                Location = bounds.Location;
                Size = bounds.Size;
            }
            return isOnScreen;
        }

        private void RecordSplitters(SplitContainer[] splitters)
        {
            SplitterDistances = new int[splitters.Length];
            SplitterSizes = new int[splitters.Length];
            for (int i = 0; i < splitters.Length; i++)
            {
                if (splitters[i] != null)
                {
                    SplitterDistances[i] = splitters[i].SplitterDistance;
                    SplitterSizes[i] = GetSplitterSize(splitters[i]);
                }
            }
        }

        private bool IsOnScreen(Point location, Size size)
        {
            return IsOnScreen(location) && IsOnScreen(location + size);
        }

        private bool IsOnScreen(Point location)
        {
            foreach (var screen in Screen.AllScreens)
            {
                var workingArea = new Rectangle(
                    screen.WorkingArea.Location,
                    screen.WorkingArea.Size);
                workingArea.Inflate(1, 1);
                if (workingArea.Contains(location))
                {
                    return true;
                }
            }
            return false;
        }

    }

}
