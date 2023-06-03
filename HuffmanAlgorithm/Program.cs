using System;
using System.Windows.Forms;

namespace HuffmanAlgorithm
{
    static class Program
    {
        /// <summary>
        /// Main point for starting.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_Main());
        }
    }
}
