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
    public partial class frmSituacao : Form
    {
        public frmSituacao()
        {
            InitializeComponent();
        }

        Situacao situacao;
        private void frmSituacao_Load(object sender, EventArgs e)
        {
            situacao = new Situacao();
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = situacao.Consultar();

                grdDados.Columns[0].Visible = false;
                grdDados.Columns[1].HeaderText = "Situacao";
                grdDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Situações",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            situacao = new Situacao();
            situacao.situacao = txtPesquisa.Text;
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
                situacao = new Situacao();
                situacao.id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                situacao.Consultar();
                PreencherFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Situações",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherFormulario()
        {
            txtSituacao.Text = situacao.situacao;
        }
        private void PreencherClasse()
        {
            situacao.situacao = txtSituacao.Text;
        }
        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;
            if (txtSituacao.Text == string.Empty)
            {
                msgErro = "Preencha o campo SITUAÇÃO.";
            }
            return msgErro;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem = ValidarPreenchimento();
                if (mensagem != string.Empty)
                {
                    MessageBox.Show(mensagem, "Cadastro de Situações",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PreencherClasse();
                situacao.Gravar();
                MessageBox.Show("Situação gravada com sucesso.",
                    "Cadastro de Situações",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Cadastro de Situações",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparCampos()
        {
            txtSituacao.Clear();
            txtPesquisa.Clear();
            txtPesquisa.Focus();
            situacao = new Situacao();
            CarregarGrid();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
