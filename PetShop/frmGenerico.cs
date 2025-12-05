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
    public partial class frmGenerico : Form
    {
        public frmGenerico()
        {
            InitializeComponent();
        }
        int aba = 0;
        int idAnimal = 0;
        string opcao = "";
        Historico historico;
        Medicamento medicamento;
        Vacina vacina;
        Vermifugo vermifugo;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LimparCampos()
        {
            dtpData.Value = DateTime.Now;
            nudPeso.Value = 0;
            txtGenerico.Clear();
            dtpData.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void frmGenerico_Load(object sender, EventArgs e)
        {
            string[] dados = this.Tag.ToString().Split('|');
            aba = Convert.ToInt32(dados[0]);
            opcao = dados[1];
            idAnimal = Convert.ToInt32(dados[2]);
            Bitmap bitmap = new Bitmap(Global.RetornarImagem(aba));
            IntPtr hIcon = bitmap.GetHicon();
            Icon icon = Icon.FromHandle(hIcon);
            this.Icon = icon;
            this.Text = $"PetShop - Cadastro de {dados[1]}";
            grpLista.Text = $"{dados[1]} Cadastrados";
            lblGenerico.Text = dados[1];
            if (aba == 0 || aba == 2)
            {
                lblPeso.Visible = false;
                nudPeso.Visible = false;
            }
            dtpData.MaxDate = Convert.ToDateTime($"{DateTime.Now.ToShortDateString()} 23:59:59");
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            try
            {
                DataTable dt = new DataTable();

                if (aba == 0)
                {
                    historico = new Historico();
                    historico.idAnimal = idAnimal;
                    dt = historico.Consultar();
                }
                else if (aba == 1)
                {
                    medicamento = new Medicamento();
                    medicamento.idAnimal = idAnimal;
                    dt = medicamento.Consultar();
                }
                else if (aba == 2)
                {
                    vacina = new Vacina();
                    vacina.idAnimal = idAnimal;
                    dt = vacina.Consultar();
                }
                else if (aba == 3)
                {
                    vermifugo = new Vermifugo();
                    vermifugo.idAnimal = idAnimal;
                    dt = vermifugo.Consultar();
                }

                grdDados.DataSource = dt;

                grdDados.Columns[0].Visible = false;
                grdDados.Columns[3].Visible = false;

                grdDados.Columns[1].HeaderText = "Data";
                grdDados.Columns[2].HeaderText = opcao;

                grdDados.Columns[1].Width = 75;
                grdDados.Columns[2].Width = 350;

                grdDados.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

                if (aba == 1 || aba == 3)
                {
                    grdDados.Columns[4].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, $"Cadastro de {opcao}",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherFormulario()
        {
            if (aba == 0)
            {
                dtpData.Value = historico.data;
                txtGenerico.Text = historico.historico;
            }
            else if (aba == 1)
            {
                dtpData.Value = medicamento.data;
                txtGenerico.Text = medicamento.medicamento;
                nudPeso.Value = medicamento.peso;
            }
            else if (aba == 2)
            {
                dtpData.Value = vacina.data;
                txtGenerico.Text = vacina.vacina;
            }
            else if (aba == 3)
            {
                dtpData.Value = vermifugo.data;
                txtGenerico.Text = vermifugo.vermifugo;
                nudPeso.Value = vermifugo.peso;
            }
        }
        private void PreencherClasse()
        {
            if (aba == 0)
            {
                historico.data = dtpData.Value;
                historico.historico = txtGenerico.Text;
            }
            else if (aba == 1)
            {
                medicamento.data = dtpData.Value;
                medicamento.medicamento = txtGenerico.Text;
                medicamento.peso = nudPeso.Value;
            }
            else if (aba == 2)
            {
                vacina.data = dtpData.Value;
                vacina.vacina = txtGenerico.Text;
            }
            else if (aba == 3)
            {
                vermifugo.data = dtpData.Value;
                vermifugo.vermifugo = txtGenerico.Text;
                vermifugo.peso = nudPeso.Value;
            }
        }
        private void grdDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDados.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                int id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                if (aba == 0)
                {
                    historico = new Historico();
                    historico.id = id;
                    historico.Consultar();
                }
                else if (aba == 1)
                {
                    medicamento = new Medicamento();
                    medicamento.id = id;
                    medicamento.Consultar();
                }
                else if (aba == 2)
                {
                    vacina = new Vacina();
                    vacina.id = id;
                    vacina.Consultar();
                }
                else if (aba == 3)
                {
                    vermifugo = new Vermifugo();
                    vermifugo.id = id;
                    vermifugo.Consultar();
                }
                PreencherFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, $"Cadastro de {opcao}",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGenerico.Text == string.Empty)
                {
                    MessageBox.Show($"Preencha o campo {opcao.ToUpper()}", $"Cadastro de {opcao}",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PreencherClasse();
                if (aba == 0)
                {
                    historico.Gravar();
                }
                else if (aba == 1)
                {
                    medicamento.Gravar();
                }
                else if (aba == 2)
                {
                    vacina.Gravar();
                }
                else if (aba == 3)
                {
                    vermifugo.Gravar();
                }
                MessageBox.Show($"Registro efetuado com sucesso !!!" ,$"Cadastro de {opcao}",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGrid();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, $"Cadastro de {opcao}",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
