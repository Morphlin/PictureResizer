using System;
using System.Windows.Forms;

namespace PictureResizer
{
    /// <summary>
    /// Entry point class for the application.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Entry point method for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormResizer());
        }
    }
}
