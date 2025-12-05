using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class frmProfissional : Form
    {
        public frmProfissional()
        {
            InitializeComponent();
        }
        Profissional profissional;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtAtuacao.Clear();
            rdbAtivo.Checked = true;
            txtPesquisa.Clear();
            txtPesquisa.Focus();
            profissional = new Profissional();
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = profissional.Consultar();

                grdDados.Columns[0].Visible = false;
                grdDados.Columns[3].Visible = false;
                grdDados.Columns[4].Visible = false;

                grdDados.Columns[1].HeaderText = "Nome";
                grdDados.Columns[2].HeaderText = "Atuação";

                grdDados.Columns[1].Width = 240;
                grdDados.Columns[2].Width = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Profissionais",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;

            if (txtNome.Text == string.Empty)
            {
                msgErro = "Preenchar o campo NOME.\n";
            }
            if (txtAtuacao.Text == string.Empty)
            {
                msgErro += "Preencha o campo ATUAÇÃO.\n";
            }
            return msgErro;
        }
        private void PreencherFormulario()
        {
            txtNome.Text = profissional.nome;
            txtAtuacao.Text = profissional.atuacao;
            rdbAtivo.Checked = profissional.ativo;
            rdbInativo.Checked = !profissional.ativo;
        }
        private void PreencherClasse()
        {
            profissional.nome = txtNome.Text;
            profissional.atuacao = txtAtuacao.Text;
            profissional.ativo = rdbAtivo.Checked;
        }
        private void frmProfissional_Load(object sender, EventArgs e)
        {
            profissional = new Profissional();
            CarregarGrid();
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            profissional = new Profissional();
            profissional.nome = txtPesquisa.Text;
            CarregarGrid();
        }

        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDados.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                profissional = new Profissional();
                profissional.id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                profissional.Consultar();
                PreencherFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Profissionais",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem = ValidarPreenchimento();
                if (mensagem != string.Empty)
                {
                    MessageBox.Show(mensagem, "Cadastro de Profissionais",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PreencherClasse();
                profissional.Gravar();
                MessageBox.Show("Profissional gravado com sucesso.",
                    "Cadastro de Profissionais",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Cadastro de Profissionais",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
