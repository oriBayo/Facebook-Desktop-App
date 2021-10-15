// $G$ THE-001 (-22) your grade on diagrams document - 69. please see comments inside the document. 40% of your grade).

namespace BasicFacebookFeatures
{
    using System;
    using System.Windows.Forms;
    using FacebookWrapper;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);    
            Application.Run(new FormLogin());
        }
    }
}
