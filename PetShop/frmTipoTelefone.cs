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
    public partial class frmTipoTelefone : Form
    {
        public frmTipoTelefone()
        {
            InitializeComponent();
        }
        TipoTelefone tipoTelefone;
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = tipoTelefone.Consultar();

                grdDados.Columns[0].Visible = false;
                grdDados.Columns[1].HeaderText = "Tipo Telefone";
                grdDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Tipos de Telefone",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmTipoTelefone_Load(object sender, EventArgs e)
        {
            tipoTelefone = new TipoTelefone();
            CarregarGrid();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            tipoTelefone = new TipoTelefone();
            tipoTelefone.tipoTelefone = txtPesquisa.Text;
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
                tipoTelefone = new TipoTelefone();
                tipoTelefone.id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                tipoTelefone.Consultar();
                PreencherFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Tipos de Telefone",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherFormulario()
        {
            txtTipoTelefone.Text = tipoTelefone.tipoTelefone;
        }
        private void PreencherClasse()
        {
            tipoTelefone.tipoTelefone = txtTipoTelefone.Text;
        }
        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;
            if (txtTipoTelefone.Text == string.Empty)
            {
                msgErro = "Preencha o campo TIPO TELEFONE.";
            }
            return msgErro;
        }
        private void LimparCampos()
        {
            txtTipoTelefone.Clear();
            txtPesquisa.Clear();
            txtPesquisa.Focus();
            tipoTelefone = new TipoTelefone();
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem = ValidarPreenchimento();
                if (mensagem != string.Empty)
                {
                    MessageBox.Show(mensagem, "Cadastro de Tipos de Telefone",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PreencherClasse();
                tipoTelefone.Gravar();
                MessageBox.Show("Tipo de Telefone gravado com sucesso.",
                    "Cadastro de Tipos de Telefone",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Cadastro de Tipos de Telefone",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
