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
    public partial class frmRaca : Form
    {
        public frmRaca()
        {
            InitializeComponent();
        }
        Raca raca;
        private void frmRaca_Load(object sender, EventArgs e)
        {
            raca = new Raca();
            CarregarGrid();
            CarregarEspecies();
        }
        private void CarregarEspecies()
        {
            try
            {
                Especie especie = new Especie();
                cboEspecie.DataSource = especie.Consultar();
                cboEspecie.DisplayMember = "especie";
                cboEspecie.ValueMember = "id";
                cboEspecie.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Raças",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = raca.Consultar();

                grdDados.Columns[0].Visible = false;
                grdDados.Columns[2].Visible = false;
                grdDados.Columns[1].HeaderText = "Raça";
                grdDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Raças",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            raca = new Raca();
            raca.raca = txtPesquisa.Text;
            CarregarGrid();
        }
        private void PreencherFormulario()
        {
            txtRaca.Text = raca.raca;
            cboEspecie.SelectedValue = raca.idEspecie;
        }
        private void PreencherClasse()
        {
            raca.raca= txtRaca.Text;
            raca.idEspecie = (int)cboEspecie.SelectedValue;
        }
        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDados.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                raca = new Raca();
                raca.id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                raca.Consultar();
                PreencherFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Raças",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;
            if (cboEspecie.SelectedIndex == -1)
            {
                msgErro = "Selecione a ESPÉCIE.\n";
            }
            if (txtRaca.Text == string.Empty)
            {
                msgErro += "Preencha o campo RAÇA.";
            }
            return msgErro;
        }
        private void LimparCampos()
        {
            cboEspecie.SelectedIndex = -1;
            txtRaca.Clear();
            txtPesquisa.Clear();
            txtPesquisa.Focus();
            raca = new Raca();
            CarregarGrid();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem = ValidarPreenchimento();
                if (mensagem != string.Empty)
                {
                    MessageBox.Show(mensagem, "Cadastro de Raças",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PreencherClasse();
                raca.Gravar();
                MessageBox.Show("Raça gravada com sucesso.",
                    "Cadastro de Raças",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Cadastro de Raças",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
