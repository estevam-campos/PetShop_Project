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
    public partial class frmSexo : Form
    {
        public frmSexo()
        {
            InitializeComponent();
        }
        Sexo sexo;
        private void frmSexo_Load(object sender, EventArgs e)
        {
            sexo = new Sexo();
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = sexo.Consultar();

                grdDados.Columns[0].Visible = false;
                grdDados.Columns[1].HeaderText = "Sexo";
                grdDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Sexos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            sexo = new Sexo();
            sexo.sexo = txtPesquisa.Text;
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
                sexo = new Sexo();
                sexo.id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                sexo.Consultar();
                PreencherFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Sexos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherFormulario()
        {
            txtSexo.Text = sexo.sexo ;
        }
        private void PreencherClasse()
        {
            sexo.sexo = txtSexo.Text;
        }
        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;
            if (txtSexo.Text == string.Empty)
            {
                msgErro = "Preencha o campo SEXO.";
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
                    MessageBox.Show(mensagem, "Cadastro de Sexos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PreencherClasse();
                sexo.Gravar();
                MessageBox.Show("Sexo gravado com sucesso.",
                    "Cadastro de Sexos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Cadastro de Sexos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparCampos()
        {
            txtSexo.Clear();
            txtPesquisa.Clear();
            txtPesquisa.Focus();
            sexo = new Sexo();
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
