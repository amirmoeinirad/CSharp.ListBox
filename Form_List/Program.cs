using System;
using System.Windows.Forms;

namespace Form_List
{    
    static class Program
    {
       [STAThread]
       static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_List());
        }
    }
}
