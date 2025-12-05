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
    public partial class frmEspecie : Form
    {
        public frmEspecie()
        {
            InitializeComponent();
        }
        Especie especie;
        private void frmEspecie_Load(object sender, EventArgs e)
        {
            especie = new Especie();
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = especie.Consultar();

                grdDados.Columns[0].Visible = false;
                grdDados.Columns[1].HeaderText = "Espécie";
                grdDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Espécies",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            especie = new Especie();
            especie.especie = txtPesquisa.Text;
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
                especie = new Especie();
                especie.id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                especie.Consultar();
                PreencherFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Espécies",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherFormulario()
        {
            txtEspecie.Text = especie.especie;
        }
        private void PreencherClasse()
        {
            especie.especie = txtEspecie.Text;
        }
        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;
            if (txtEspecie.Text == string.Empty)
            {
                msgErro = "Preencha o campo ESPÉCIE.";
            }
            return msgErro;
        }
        private void LimparCampos()
        {
            txtEspecie.Clear();
            txtPesquisa.Clear();
            txtPesquisa.Focus();
            especie = new Especie();
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
                    MessageBox.Show(mensagem, "Cadastro de Espécies",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PreencherClasse();
                especie.Gravar();
                MessageBox.Show("Espécie gravado com sucesso.",
                    "Cadastro de Espécies",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Cadastro de Espécies",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
