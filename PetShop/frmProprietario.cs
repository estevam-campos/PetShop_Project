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
    public partial class frmProprietario : Form
    {
        public frmProprietario()
        {
            InitializeComponent();
        }
        Proprietario proprietario;
        bool load = false;
        bool abrir = true;
        private void CarregarEstados()
        {
            try
            {
                cboEstado.DataSource = Global.ConsultarEstados();
                cboEstado.DisplayMember = "estado";
                cboEstado.ValueMember = "id";
                cboEstado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void CarregarCidades(int idEstado)
        {
            try
            {
                cboCidade.DataSource = Global.ConsultarCidades(idEstado);
                cboCidade.DisplayMember = "cidade";
                cboCidade.ValueMember = "id";
                cboCidade.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void CarregarTipoTelefone()
        {
            try
            {
                cboTipoTelefone.DataSource = (new TipoTelefone()).Consultar();
                cboTipoTelefone.DisplayMember = "tipoTelefone";
                cboTipoTelefone.ValueMember = "id";
                cboTipoTelefone.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = proprietario.Consultar();

                grdDados.Columns[0].Visible = false;

                grdDados.Columns[1].HeaderText = "Nome";
                grdDados.Columns[2].HeaderText = "CPF";

                grdDados.Columns[1].Width = 340;
                grdDados.Columns[2].Width = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Proprietários",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmProprietario_Load(object sender, EventArgs e)
        {
            this.Width = 483;
            proprietario = new Proprietario();
            CarregarEstados();
            CarregarTipoTelefone();
            CarregarGrid();
            load = true;
        }
        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (load && cboEstado.SelectedIndex != -1)
            {
                CarregarCidades((int)cboEstado.SelectedValue);
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            proprietario = new Proprietario();
            proprietario.nome = txtPesquisa.Text;
            CarregarGrid();
        }
        private void PreencherFormulario()
        {
            try
            {
                txtNome.Text = proprietario.nome;
                txtCPF.Text = proprietario.cpf;
                txtCEP.Text = proprietario.endereco.cep;
                txtEndereco.Text = proprietario.endereco.endereco;
                txtNumero.Text = proprietario.endereco.numero;
                txtComplemento.Text = proprietario.endereco.complemento;
                txtBairro.Text = proprietario.endereco.bairro;
                cboEstado.SelectedValue = Global.ConsultarEstado(proprietario.endereco.idCidade);
                cboCidade.SelectedValue = proprietario.endereco.idCidade;
                CarregarTelefones();
                LimparCamposAnimais();
                CarregarAnimais();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void CarregarTelefones()
        {
            try
            {
                lstTelefone.Items.Clear();
                foreach (Telefone t in proprietario.telefones)
                {
                    TipoTelefone tt = new TipoTelefone();
                    tt.id = t.idTipoTelefone;
                    tt.Consultar();
                    lstTelefone.Items.Add($"{t.telefone} ({tt.tipoTelefone.Substring(0, 3)})");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
                proprietario = new Proprietario();
                proprietario.id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                proprietario.Consultar();
                PreencherFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Proprietários",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            cboCidade.DataSource = null;
            cboEstado.SelectedIndex = -1;
            txtPesquisa.Clear();
            txtPesquisa.Focus();
            lstTelefone.Items.Clear();
            txtTelefone.Clear();
            cboTipoTelefone.SelectedIndex = -1;
            proprietario = new Proprietario();
            LimparCamposAnimais();
            CarregarGrid();
        }
        private void LimparCamposAnimais()
        {
            cboAnimais.Items.Clear();
            txtEspecie.Clear();
            txtRaca.Clear();
            txtDataNascimento.Clear();
            txtSexo.Clear();
            txtHistorico.Clear();
            txtMedicamento.Clear();
            txtVacina.Clear();
            txtVermifugo.Clear();
            tabAtendimentos.SelectedIndex = 0;
            grdHistorico.DataSource = null;
            grdMedicamento.DataSource = null;
            grdVacina.DataSource = null;
            grdVermifugo.DataSource = null;
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

                if (txtNome.Text == string.Empty)
                {
                    msgErro = "Preencha o campo NOME.\n";
                }
                if (txtCPF.Text == string.Empty)
                {
                    msgErro += "Preencha o campo CPF.\n";
                }
                else
                {
                    Proprietario p = new Proprietario();
                    p.cpf = txtCPF.Text;
                    p.Consultar();
                    //Novo Cadastro com usuário já existente
                    if ((proprietario.id == 0 && p.id != 0) ||
                        //Alteração com usuário já existente diferente do usuário original
                        (proprietario.id != 0 && p.id != 0 && proprietario.id != p.id))
                    {
                        msgErro += "CPF já cadastrado.\n";
                    }
                }
                if (txtCEP.Text == string.Empty)
                {
                    msgErro += "Preencha o campo CEP.\n";
                }
                if (txtEndereco.Text == string.Empty)
                {
                    msgErro += "Preencha o campo ENDEREÇO.\n";
                }
                if (txtNumero.Text == string.Empty)
                {
                    msgErro += "Preencha o campo NÚMERO.\n";
                }
                if (txtBairro.Text == string.Empty)
                {
                    msgErro += "Preencha o campo BAIRRO.\n";
                }
                if (cboCidade.SelectedIndex == -1)
                {
                    msgErro += "Selecione a CIDADE.\n";
                }
                if (cboEstado.SelectedIndex == -1)
                {
                    msgErro += "Selecione o ESTADO.\n";
                }
                if (lstTelefone.Items.Count == 0)
                {
                    msgErro += "Adicione ao menos 1 TELEFONE.\n";
                }
                return msgErro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void PreencherClasse()
        {
            proprietario.nome = txtNome.Text;
            proprietario.cpf = txtCPF.Text;
            proprietario.endereco.cep = txtCEP.Text;
            proprietario.endereco.endereco = txtEndereco.Text;
            proprietario.endereco.numero = txtNumero.Text;
            proprietario.endereco.complemento = txtComplemento.Text;
            proprietario.endereco.bairro = txtBairro.Text;
            proprietario.endereco.idCidade = (int)cboCidade.SelectedValue;
            proprietario.telefones.Clear();
            foreach (string numero in lstTelefone.Items)
            {
                Telefone t = new Telefone();
                t.telefone = numero.Substring(0, numero.Length - 5).Trim();
                string tipo = numero.Substring(numero.Length - 5).Replace("(","").Replace(")","");
                cboTipoTelefone.SelectedIndex = cboTipoTelefone.FindString(tipo);
                t.idTipoTelefone = (int)cboTipoTelefone.SelectedValue;
                t.idProprietario = proprietario.id;
                proprietario.telefones.Add(t);
            }
            cboTipoTelefone.SelectedIndex = -1;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem = ValidarPreenchimento();
                if (mensagem != string.Empty)
                {
                    MessageBox.Show(mensagem, "Cadastro de Proprietários",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PreencherClasse();
                proprietario.Gravar();
                MessageBox.Show("Proprietário gravado com sucesso.",
                    "Cadastro de Proprietários",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Cadastro de Proprietários",
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
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (abrir)
            {
                for (int i = 483; i <= 860; i += 10)
                {
                    this.Width = i;
                    Application.DoEvents();
                }
                this.Width = 860;
                btnVisualizar.Text = "&Ocultar\nAnimais";
                abrir = false;
                return;
            }

            for (int i = 860; i >= 483; i -= 10)
            {
                this.Width = i;
                Application.DoEvents();
            }
            this.Width = 483;
            btnVisualizar.Text = "&Visualizar\nAnimais";
            abrir = true;
        }
        private void cboAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarDadosAnimal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Cadastro de Proprietários",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                Historico h = new Historico();
                h.idAnimal = a.id;
                grdHistorico.DataSource = h.Consultar();
                grdHistorico.Columns[0].Visible = false;
                grdHistorico.Columns[3].Visible = false;

                grdHistorico.Columns[1].HeaderText = "Data";
                grdHistorico.Columns[2].HeaderText = "Histórico";

                grdHistorico.Columns[1].Width = 75;
                grdHistorico.Columns[2].Width = 300;

                grdHistorico.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

                Medicamento m = new Medicamento();
                m.idAnimal = a.id;
                grdMedicamento.DataSource = m.Consultar();
                grdMedicamento.Columns[0].Visible = false;
                grdMedicamento.Columns[3].Visible = false;
                grdMedicamento.Columns[4].Visible = false;

                grdMedicamento.Columns[1].HeaderText = "Data";
                grdMedicamento.Columns[2].HeaderText = "Medicamento";

                grdMedicamento.Columns[1].Width = 75;
                grdMedicamento.Columns[2].Width = 300;

                grdMedicamento.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

                Vacina v = new Vacina();
                v.idAnimal = a.id;
                grdVacina.DataSource = v.Consultar();
                grdVacina.Columns[0].Visible = false;
                grdVacina.Columns[3].Visible = false;

                grdVacina.Columns[1].HeaderText = "Data";
                grdVacina.Columns[2].HeaderText = "Vacina";

                grdVacina.Columns[1].Width = 75;
                grdVacina.Columns[2].Width = 300;

                grdVacina.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

                Vermifugo ver = new Vermifugo();
                ver.idAnimal = a.id;
                grdVermifugo.DataSource = ver.Consultar();
                grdVermifugo.Columns[0].Visible = false;
                grdVermifugo.Columns[3].Visible = false;
                grdVermifugo.Columns[4].Visible = false;

                grdVermifugo.Columns[1].HeaderText = "Data";
                grdVermifugo.Columns[2].HeaderText = "Vermífugo";

                grdVermifugo.Columns[1].Width = 75;
                grdVermifugo.Columns[2].Width = 300;

                grdVermifugo.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

                tabAtendimentos.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void grdVermifugo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Vermifugo v = new Vermifugo();
                v.id = Convert.ToInt32(grdVermifugo.SelectedRows[0].Cells[0].Value);
                v.Consultar();
                txtVermifugo.Text = $"Data: {v.data.ToShortDateString()} - Peso: {v.peso} Kg - {v.vermifugo}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Cadastro de Proprietários",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grdHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Historico h = new Historico();
                h.id = Convert.ToInt32(grdHistorico.SelectedRows[0].Cells[0].Value);
                h.Consultar();
                txtHistorico.Text = $"Data: {h.data.ToShortDateString()} - {h.historico}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Cadastro de Proprietários",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grdMedicamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Medicamento m = new Medicamento();
                m.id = Convert.ToInt32(grdMedicamento.SelectedRows[0].Cells[0].Value);
                m.Consultar();
                txtMedicamento.Text = $"Data: {m.data.ToShortDateString()} - Peso: {m.peso} Kg - {m.medicamento}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Cadastro de Proprietários",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grdVacina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Vacina v = new Vacina();
                v.id = Convert.ToInt32(grdVacina.SelectedRows[0].Cells[0].Value);
                v.Consultar();
                txtVacina.Text = $"Data: {v.data.ToShortDateString()} - {v.vacina}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Cadastro de Proprietários",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tabAtendimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdicionar.Text = "&Adicionar " + tabAtendimentos.SelectedTab.Text;
            btnAdicionar.Image = Global.RetornarImagem(tabAtendimentos.SelectedIndex);
            Application.DoEvents();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cboAnimais.SelectedIndex == -1)
            {
                return;
            }
            frmGenerico form = new frmGenerico();
            form.Tag = $"{tabAtendimentos.SelectedIndex}|" +
                $"{tabAtendimentos.SelectedTab.Text}|" +
                $"{((Animal)cboAnimais.SelectedItem).id}";
            form.ShowDialog();
            CarregarDadosAnimal();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTelefone.Text == string.Empty || cboTipoTelefone.SelectedIndex == -1)
            {
                return;
            }
            string numero = $"{txtTelefone.Text} ({cboTipoTelefone.Text.Substring(0, 3)})";
            if (lstTelefone.Items.IndexOf(numero) != -1)
            {
                MessageBox.Show("Telefone já adicionado.", "Cadastro de Proprietários",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lstTelefone.Items.Add(numero);
            txtTelefone.Clear();
            cboTipoTelefone.SelectedIndex = -1;
            txtTelefone.Focus();
        }
        private void btnRem_Click(object sender, EventArgs e)
        {
            if (lstTelefone.SelectedIndex != -1)
            {
                lstTelefone.Items.RemoveAt(lstTelefone.SelectedIndex);
            }
        }

        private void lstTelefone_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void lstTelefone_DoubleClick(object sender, EventArgs e)
        {
            string numero = lstTelefone.Text;
            string tipo = numero.Substring(numero.Length - 5).Replace("(", "").Replace(")", "");
            numero = numero.Substring(0, numero.Length - 5).Trim();
            cboTipoTelefone.SelectedIndex = cboTipoTelefone.FindString(tipo);
            txtTelefone.Text = numero;
            btnRem.PerformClick();
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;

            if (!char.IsDigit(tecla) && tecla != (char)Keys.Back && "()-".IndexOf(tecla) == -1)
            {
                e.Handled = true;
            }
        }
    }
}
