using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes.Telas
{
    public partial class NovoClienteForm : Form
    {
        private Cliente clienteOriginal;
        private bool editando;

        public NovoClienteForm() : this(null)
        {
        }

        public NovoClienteForm(Cliente cliente)
        {
            InitializeComponent();

            clienteOriginal = cliente;
            editando = (cliente != null);

            btnSalvar.Click -= btnSalvar_Click;
            btnSalvar.Click += btnSalvar_Click;

            btnCancelar.Click -= btnCancelar_Click;
            btnCancelar.Click += btnCancelar_Click;

            Text = editando ? "Editar cliente" : "Novo cliente";
            lblTitulo.Text = Text;

            if (editando)
                PreencherCampos();
        }

        private void PreencherCampos()
        {
            txtNome.Text = clienteOriginal.Nome;
            mskTelefone.Text = clienteOriginal.Telefone;
            txtEmail.Text = clienteOriginal.Email;

            if (clienteOriginal.UltimaVisita.HasValue)
            {
                dtpUltimaVisita.Value = clienteOriginal.UltimaVisita.Value;
                dtpUltimaVisita.Checked = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string digitos = new string(mskTelefone.Text.Where(char.IsDigit).ToArray());

            if (nome.Length < 3)
            {
                MessageBox.Show("Informe o nome do cliente (mínimo 3 letras).", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            if (digitos.Length > 0 && !mskTelefone.MaskCompleted)
            {
                MessageBox.Show("Telefone incompleto. Preencha todos os números ou deixe em branco.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTelefone.Focus();
                return;
            }

            if (email != "" && !EmailValido(email))
            {
                MessageBox.Show("E-mail inválido.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            var cliente = new Cliente
            {
                Id = editando ? clienteOriginal.Id : 0,
                Nome = nome,
                Telefone = digitos.Length > 0 ? mskTelefone.Text : "",
                Email = email,
                UltimaVisita = dtpUltimaVisita.Checked
                    ? (DateTime?)dtpUltimaVisita.Value.Date
                    : null
            };

            try
            {
                var dao = new ClienteDAO();

                if (editando)
                    dao.Atualizar(cliente);
                else
                    dao.Inserir(cliente);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o cliente: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EmailValido(string email)
        {
            try
            {
                var m = new MailAddress(email);
                return m.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void NovoClienteForm_Load(object sender, EventArgs e)
        {

        }
    }
}