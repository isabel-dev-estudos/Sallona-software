using Clientes.Telas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clientes
{
    public partial class Clientesforms : Form
    {
        private List<Cliente> todosClientes = new List<Cliente>();
        private bool ordemAZ = true;
        private string filtroAtual = "Todos";

        public Clientesforms()
        {
            InitializeComponent();

            Load -= Clientesforms_Load;
            Load += Clientesforms_Load;

            txtBusca.TextChanged -= txtBusca_TextChanged;
            txtBusca.TextChanged += txtBusca_TextChanged;

            btnOrdenar.Click -= btnOrdenar_Click;
            btnOrdenar.Click += btnOrdenar_Click;

            btnFiltros.Click -= btnFiltros_Click;
            btnFiltros.Click += btnFiltros_Click;

            btnNovo.Click -= btnNovo_Click;
            btnNovo.Click += btnNovo_Click;

            btnEditar.Click -= btnEditar_Click;
            btnEditar.Click += btnEditar_Click;

            btnExcluir.Click -= btnExcluir_Click;
            btnExcluir.Click += btnExcluir_Click;

            dgvClientes.CellDoubleClick -= dgvClientes_CellDoubleClick;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
        }

        private void Clientesforms_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            CarregarDoBanco();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            using (var form = new NovoClienteForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    CarregarDoBanco();
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarSelecionado();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                EditarSelecionado();
        }

        private void EditarSelecionado()
        {
            Cliente selecionado = ClienteSelecionado();

            if (selecionado == null)
            {
                MessageBox.Show("Selecione um cliente na tabela.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new NovoClienteForm(selecionado))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    CarregarDoBanco();
                    MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente selecionado = ClienteSelecionado();

            if (selecionado == null)
            {
                MessageBox.Show("Selecione um cliente na tabela.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir o cliente \"" + selecionado.Nome + "\"?",
                "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes)
                return;

            try
            {
                new ClienteDAO().Excluir(selecionado.Id);
                CarregarDoBanco();
                MessageBox.Show("Cliente excluído com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível excluir o cliente: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Cliente ClienteSelecionado()
        {
            if (dgvClientes.CurrentRow == null)
                return null;

            return dgvClientes.CurrentRow.DataBoundItem as Cliente;
        }

        private void CarregarDoBanco()
        {
            try
            {
                todosClientes = new ClienteDAO().Listar();
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os clientes: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarFiltros()
        {
            IEnumerable<Cliente> q = todosClientes;

            string busca = txtBusca.Text.Trim();
            if (busca != "")
                q = q.Where(c => c.Nome.IndexOf(busca, StringComparison.OrdinalIgnoreCase) >= 0);

            switch (filtroAtual)
            {
                case "ComEmail":
                    q = q.Where(c => !string.IsNullOrWhiteSpace(c.Email));
                    break;
                case "SemEmail":
                    q = q.Where(c => string.IsNullOrWhiteSpace(c.Email));
                    break;
                case "Recentes":
                    q = q.Where(c => c.UltimaVisita != null &&
                                     c.UltimaVisita >= DateTime.Today.AddDays(-30));
                    break;
                case "Inativos":
                    q = q.Where(c => c.UltimaVisita == null ||
                                     c.UltimaVisita < DateTime.Today.AddDays(-60));
                    break;
            }

            q = ordemAZ ? q.OrderBy(c => c.Nome) : q.OrderByDescending(c => c.Nome);

            dgvClientes.DataSource = q.ToList();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvClientes.Columns["Id"].Visible = false;
            dgvClientes.Columns["UltimaVisita"].HeaderText = "Última visita";
            dgvClientes.Columns["UltimaVisita"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvClientes.ReadOnly = true;
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.MultiSelect = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            ordemAZ = !ordemAZ;
            btnOrdenar.Text = ordemAZ ? "Nome: A–Z" : "Nome: Z–A";
            AplicarFiltros();
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            var menu = new ContextMenuStrip();
            AddFiltro(menu, "Todos", "Todos");
            AddFiltro(menu, "Com e-mail", "ComEmail");
            AddFiltro(menu, "Sem e-mail", "SemEmail");
            AddFiltro(menu, "Visitaram nos últimos 30 dias", "Recentes");
            AddFiltro(menu, "Sem visita há mais de 60 dias", "Inativos");
            menu.Show(btnFiltros, new Point(0, btnFiltros.Height));
        }

        private void AddFiltro(ContextMenuStrip menu, string texto, string chave)
        {
            var item = new ToolStripMenuItem(texto);
            item.Checked = (filtroAtual == chave);
            item.Click += (s, e) =>
            {
                filtroAtual = chave;
                btnFiltros.Text = chave == "Todos" ? "Filtros" : "Filtros (1)";
                AplicarFiltros();
            };
            menu.Items.Add(item);
        }

        private void Clientesforms_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {

        }
    }
}