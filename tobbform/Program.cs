using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tobbform
{
    internal static class Program
    {
        static public GyumolcsUpdate gyumolcsUpdate = null;
        static public GyumolcsDelete gyumolcsDelete = null;
        static public GyumolcsInsert gyumolcsInsert = null;
        static public Form_Nyito form_Nyito = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            gyumolcsUpdate = new GyumolcsUpdate();
            gyumolcsDelete = new GyumolcsDelete();
            gyumolcsInsert = new GyumolcsInsert();
            form_Nyito = new Form_Nyito();
            Application.Run(form_Nyito);
        }
    }
}
