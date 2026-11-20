using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        private const string UsuarioPadrao = "adm";
        private const string SenhaPadrao = "adm";

        private readonly string arquivoLembrar = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Sallona", "usuario.txt");

        public Login()
        {
            InitializeComponent();

            txtSenha.UseSystemPasswordChar = true;
            lnkMostrar.Text = "Mostrar";
            AcceptButton = btnEntrar;

            btnEntrar.Click -= btnEntrar_Click;
            btnEntrar.Click += btnEntrar_Click;

            lnkMostrar.Click -= lnkMostrar_Click;
            lnkMostrar.Click += lnkMostrar_Click;

            lnkEsqueciSenha.LinkClicked -= lnkEsqueciSenha_LinkClicked;
            lnkEsqueciSenha.LinkClicked += lnkEsqueciSenha_LinkClicked;

           

            CarregarUsuarioLembrado();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Informe o usuário e a senha.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            bool usuarioCerto = string.Equals(usuario, UsuarioPadrao, StringComparison.OrdinalIgnoreCase);
            bool senhaCerta = senha == SenhaPadrao;

            if (usuarioCerto && senhaCerta)
            {
                SalvarUsuarioLembrado(usuario);
                AbrirMenuPrincipal();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear();
                txtSenha.Focus();
            }
        }

        private void AbrirMenuPrincipal()
        {
            MessageBox.Show("Login realizado com sucesso!", "Sallona",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkMostrar_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
            lnkMostrar.Text = txtSenha.UseSystemPasswordChar ? "Mostrar" : "Ocultar";
            txtSenha.Focus();
        }

        private void lnkEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Procure o administrador do sistema para redefinir a senha.",
                "Esqueci a senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("O cadastro de novos estabelecimentos não está disponível nesta versão.",
                "Cadastre-se", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CarregarUsuarioLembrado()
        {
            try
            {
                if (!File.Exists(arquivoLembrar))
                    return;

                string salvo = File.ReadAllText(arquivoLembrar).Trim();

                if (salvo != "")
                {
                    txtUsuario.Text = salvo;
                    chkLembrar.Checked = true;
                    ActiveControl = txtSenha;
                }
            }
            catch
            {
                chkLembrar.Checked = false;
            }
        }

        private void SalvarUsuarioLembrado(string usuario)
        {
            try
            {
                if (chkLembrar.Checked)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(arquivoLembrar));
                    File.WriteAllText(arquivoLembrar, usuario);
                }
                else if (File.Exists(arquivoLembrar))
                {
                    File.Delete(arquivoLembrar);
                }
            }
            catch
            {
            }
        }
    }
}