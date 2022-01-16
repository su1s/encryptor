using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace Encryptor
{
    class Program
    {
        [STAThread]
        static void Main()
        {
              Application.EnableVisualStyles();
              Application.SetCompatibleTextRenderingDefault(false);
            // Fix this if its left in an odd state
            if (Properties.Settings.Default.SplitLine > 99)
            {
                Properties.Settings.Default.SplitLine = 22;
                Properties.Settings.Default.Save();
            }
            Application.Run(new frmMain());
        }
    }
}
