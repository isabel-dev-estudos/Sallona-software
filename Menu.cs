using System.Windows.Forms;

namespace Agenda
{
    public static class Paginas
    {
        public static void Abrir(Form proximo, Form atual = null)
        {
            proximo.FormClosed += (s, e) =>
            {
                if (Application.OpenForms.Count == 0)
                {
                    Application.Exit();
                }
            };

            if (atual != null)
            {
                proximo.StartPosition = FormStartPosition.Manual;
                proximo.Location = atual.Location;
                proximo.WindowState = atual.WindowState;
            }

            proximo.Show();

            if (atual != null)
            {
                atual.Close();
            }
        }
    }
}