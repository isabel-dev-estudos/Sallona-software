using System;
using System.Windows.Forms;
using Dashboard;

namespace Agenda
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (Login.Login login = new Login.Login())
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            Paginas.Abrir(new FrmDashboard());
            Application.Run();
        }
    }
}