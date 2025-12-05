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
    public partial class frmAnimal : Form
    {
        public frmAnimal()
        {
            InitializeComponent();
        }
        Animal animal;
        bool load = false;
        private void frmAnimal_Load(object sender, EventArgs e)
        {
            animal = new Animal();
            CarregarEspecies();
            CarregarSexos();
            CarregarGrid();
            load = true;
        }
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = animal.Consultar();
                grdDados.Columns[0].Visible = false;
                grdDados.Columns[2].Visible = false;
                grdDados.Columns[3].Visible = false;
                grdDados.Columns[4].Visible = false;
                grdDados.Columns[5].Visible = false;
                grdDados.Columns[1].HeaderText = "Nome";
                grdDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Animais",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarSexos()
        {
            try
            {
                cboSexo.DataSource = (new Sexo()).Consultar();
                cboSexo.DisplayMember = "sexo";
                cboSexo.ValueMember = "id";
                cboSexo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void CarregarEspecies()
        {
            try
            {
                cboEspecie.DataSource = (new Especie()).Consultar();
                cboEspecie.DisplayMember = "especie";
                cboEspecie.ValueMember = "id";
                cboEspecie.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void CarregarRacas(int idEspecie)
        {
            try
            {
                Raca raca = new Raca();
                raca.idEspecie = idEspecie;
                cboRaca.DataSource = raca.Consultar();
                cboRaca.DisplayMember = "raca";
                cboRaca.ValueMember = "id";
                cboRaca.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void cboEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (load && cboEspecie.SelectedIndex != -1)
            {
                CarregarRacas((int)cboEspecie.SelectedValue);
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            animal = new Animal();
            if (rdbNome.Checked)
            {
                animal.nome = txtPesquisa.Text;
            }
            else
            {
                Proprietario p = new Proprietario();
                p.cpf = txtPesquisa.Text;
                p.Consultar();
                animal.idProprietario = p.id;
            }
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
                animal = new Animal();
                animal.id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                animal.Consultar();
                PreencherFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Animais",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherFormulario()
        {
            try
            {
                Raca r = new Raca();
                r.id = animal.idRaca;
                r.Consultar();

                Proprietario p = new Proprietario();
                p.id = animal.idProprietario;
                p.Consultar();

                txtCPF.Text = p.cpf;
                txtNome.Text = p.nome;

                txtNomeAnimal.Text = animal.nome;
                dtpDataNascimento.Value = animal.dataNascimento;
                cboEspecie.SelectedValue = r.idEspecie;
                cboRaca.SelectedValue = animal.idRaca;
                cboSexo.SelectedValue = animal.idSexo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text ==string.Empty)
            {
                return;
            }

            try
            {
                Proprietario p = new Proprietario();
                p.cpf = txtCPF.Text;
                p.Consultar();
                if (p.id == 0)
                {
                    MessageBox.Show("CPF não encontrado. Efetue o Cadastro para continuar.",
                        "Cadastro de Animais", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtNome.Text = p.nome;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Animais",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparCampos()
        {
            txtCPF.Clear();
            txtNome.Clear();
            txtNomeAnimal.Clear();
            dtpDataNascimento.Value = DateTime.Now;            
            cboRaca.DataSource = null;
            cboEspecie.SelectedIndex = -1;
            cboSexo.SelectedIndex = -1;
            rdbNome.Checked = true;
            txtPesquisa.Clear();
            txtPesquisa.Focus();
            animal = new Animal();
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
        private string ValidarPreenchimento()
        {
            try
            {
                string msgErro = string.Empty;

                if (txtCPF.Text == string.Empty)
                {
                    msgErro = "Campo CPF em branco.\n";
                }
                else
                {
                    Proprietario p = new Proprietario();
                    p.cpf = txtCPF.Text;
                    p.Consultar();
                    if (p.id == 0)
                    {
                        msgErro = "CPF não encontrado. Efetue o Cadastro para continuar.\n";
                    }
                }
                if (cboEspecie.SelectedIndex == -1)
                {
                    msgErro += "Selecione a ESPÉCIE.\n";
                }
                if (cboRaca.SelectedIndex == -1)
                {
                    msgErro += "Selecione a RAÇA.\n";
                }
                if (txtNomeAnimal.Text == string.Empty)
                {
                    msgErro += "Campo NOME DO ANIMAL em branco.\n";
                }
                if (cboSexo.SelectedIndex == -1)
                {
                    msgErro += "Selecione o SEXO do animal.\n";
                }
                return msgErro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem = ValidarPreenchimento();
                if (mensagem != string.Empty)
                {
                    MessageBox.Show(mensagem, "Cadastro de Animais",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PreencherClasse();
                animal.Gravar();
                MessageBox.Show("Animal gravado com sucesso.",
                    "Cadastro de Animal",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Cadastro de Animais",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherClasse()
        {
            try
            {
                Proprietario p = new Proprietario();
                p.cpf = txtCPF.Text;
                p.Consultar();

                animal.nome = txtNomeAnimal.Text;
                animal.dataNascimento = dtpDataNascimento.Value;
                animal.idRaca = (int)cboRaca.SelectedValue;
                animal.idSexo = (int)cboSexo.SelectedValue;
                animal.idProprietario = p.id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }   
    }
}
