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
    public partial class frmAgendamento : Form
    {
        public frmAgendamento()
        {
            InitializeComponent();
        }
        Proprietario proprietario;
        private void CarregarSituacaoAgendamento()
        {
            try
            {
                Situacao situacao = new Situacao();
                cboSituacao.DataSource = situacao.Consultar();
                cboSituacao.DisplayMember = "situacao";
                cboSituacao.ValueMember = "id";
                cboSituacao.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Agendamentos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarProfissionais()
        {
            try
            {
                Profissional profissional = new Profissional();
                cboProfissional.DataSource = profissional.Consultar(true);
                cboProfissional.DisplayMember = "nome";
                cboProfissional.ValueMember = "id";
                cboProfissional.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Agendamentos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarGrid()
        {
            grdAgendamento.Rows.Clear();
            grdAgendamento.Columns.Clear();
            grdAgendamento.Columns.Add("id", "id");
            grdAgendamento.Columns.Add("hora", "Hora");
            grdAgendamento.Columns.Add("Situacao", "Situação");
            grdAgendamento.Columns.Add("cliente", "Cliente");
            grdAgendamento.Columns.Add("cpf", "CPF");
            grdAgendamento.Columns.Add("animal", "Animal");
            grdAgendamento.Columns.Add("obs", "Observação");
            grdAgendamento.Columns.Add("idAnimal", "idAnimal");
            grdAgendamento.Columns.Add("idSituacao", "idSituacao");

            grdAgendamento.Columns[0].Visible = false; //Id
            grdAgendamento.Columns[7].Visible = false; //IdCliente
            grdAgendamento.Columns[8].Visible = false; //IdSituacao

            grdAgendamento.Columns[1].Width = 50; //Hora
            grdAgendamento.Columns[2].Width = 75; //Situação
            grdAgendamento.Columns[3].Width = 300; //Cliente
            grdAgendamento.Columns[4].Width = 75; //CPF
            grdAgendamento.Columns[5].Width = 100; //Animal
            grdAgendamento.Columns[6].Width = 500; //Obs

            grdAgendamento.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdAgendamento.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            string[] linha = new string[7];
            for (int i = 0; i < 7; i++)
            {
                linha[i] = string.Empty;
            }

            for (int i = 8; i < 23; i++)
            {
                linha[1] = i.ToString("00") + ":00";
                grdAgendamento.Rows.Add(linha);
            }
        }
        private void frmAgendamento_Load(object sender, EventArgs e)
        {
            CarregarSituacaoAgendamento();
            CarregarProfissionais();
            ConfigurarGrid();
        }
        private void txtCPF_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCPF.Text == string.Empty)
                {
                    return;
                }
                proprietario = new Proprietario();
                proprietario.cpf = txtCPF.Text;
                proprietario.Consultar();
                if (proprietario.id == 0)
                {
                    MessageBox.Show("Cliente não localizado. Efetue o cadastro para continuar.",
                        "Cadastro de Agendamentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtNomeCliente.Text = proprietario.nome;
                CarregarAnimais();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -->" + ex.Message, "Cadastro de Agendamentos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarAnimais()
        {
            cboAnimais.Items.Clear();
            cboAnimais.DisplayMember = "nome";
            cboAnimais.ValueMember = "id";
            foreach (Animal animal in proprietario.animais)
            {
                cboAnimais.Items.Add(animal);
            }
            if (cboAnimais.Items.Count > 0)
            {
                cboAnimais.SelectedIndex = 0;
            }
        }
        private void CarregarDadosAnimal()
        {
            try
            {
                Animal a = new Animal();
                a.id = ((Animal)cboAnimais.SelectedItem).id;
                a.Consultar();
                txtDataNascimento.Text = a.dataNascimento.ToShortDateString();

                Raca r = new Raca();
                r.id = a.idRaca;
                r.Consultar();
                txtRaca.Text = r.raca;

                Especie esp = new Especie();
                esp.id = r.idEspecie;
                esp.Consultar();
                txtEspecie.Text = esp.especie;

                Sexo s = new Sexo();
                s.id = a.idSexo;
                s.Consultar();
                txtSexo.Text = s.sexo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -->" + ex.Message, "Cadastro de Agendamentos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDadosAnimal();
        }
        private void LimparCampos()
        {
            txtCPF.Clear();
            txtNomeCliente.Clear();
            txtEspecie.Clear();
            txtRaca.Clear();
            txtSexo.Clear();
            txtDataNascimento.Clear();
            cboAnimais.Items.Clear();
            txtObservacoes.Clear();
            cboSituacao.SelectedIndex = -1;
            cboSituacao.Enabled = false;
            cboProfissional.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
