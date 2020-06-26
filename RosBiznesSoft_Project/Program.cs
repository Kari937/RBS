using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosBiznesSoft_Project
{
    static class Program
    {
        public static RosBiznesSoftEntities rbs = new RosBiznesSoftEntities();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Us());
        }
    }
}
