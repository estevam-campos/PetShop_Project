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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        Usuario usuario;
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            usuario = new Usuario();
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            try
            {
                grdDados.DataSource = usuario.Consultar();

                grdDados.Columns[0].Visible = false;
                grdDados.Columns[3].Visible = false;
                grdDados.Columns[4].Visible = false;

                grdDados.Columns[1].HeaderText = "Nome";
                grdDados.Columns[2].HeaderText = "Usuário";

                grdDados.Columns[1].Width = 240;
                grdDados.Columns[2].Width = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Usuários",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            usuario = new Usuario();
            usuario.nome = txtPesquisa.Text;
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
                usuario = new Usuario();
                usuario.id = Convert.ToInt32(grdDados.SelectedRows[0].Cells[0].Value);
                usuario.Consultar();
                PreencherFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro--> " + ex.Message, "Cadastro de Usuários",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherFormulario()
        {
            txtNome.Text = usuario.nome;
            txtUsuario.Text = usuario.user;
            txtSenha.Text = usuario.password;
            txtConfirmacao.Text = usuario.password;
            rdbAtivo.Checked = usuario.ativo;
            rdbInativo.Checked = !usuario.ativo;
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtUsuario.Clear();
            txtConfirmacao.Clear();
            txtSenha.Clear();
            rdbAtivo.Checked = true;
            txtPesquisa.Clear();
            txtPesquisa.Focus();
            usuario = new Usuario();
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
        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;

            if (txtNome.Text == string.Empty)
            {
                msgErro = "Preenchar o campo NOME.\n";
            }
            if (txtUsuario.Text == string.Empty)
            {
                msgErro += "Preencha o campo USUÁRIO.\n";
            }
            else
            {
                Usuario u = new Usuario();
                u.user = txtUsuario.Text;
                u.Consultar();
                //Novo Cadastro com usuário já existente
                if ((usuario.id == 0 && u.id != 0) ||
                    //Alteração com usuário já existente diferente do usuário original
                    (usuario.id != 0 && u.id != 0 && usuario.id != u.id))                    
                {
                    msgErro += "USUÁRIO está indisponível para utilização.\n";
                }
            }
            if (txtSenha.Text == string.Empty)
            {
                msgErro += "Preencha o campo SENHA.\n";
            }
            else if (txtSenha.Text != txtConfirmacao.Text)
            {
                msgErro += "CONFIRMAÇÃO da Senha incorreta.\n";
            }

            return msgErro;
        }
        private void PreencherClasse()
        {
            usuario.nome = txtNome.Text;
            usuario.user = txtUsuario.Text;
            if (txtSenha.Text != usuario.password)
            {
                usuario.password = Global.CriptografarSenha(txtSenha.Text);
            }
            usuario.ativo = rdbAtivo.Checked;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem = ValidarPreenchimento();
                if (mensagem != string.Empty)
                {
                    MessageBox.Show(mensagem, "Cadastro de Usuários",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PreencherClasse();
                usuario.Gravar();
                MessageBox.Show("Usuário gravado com sucesso.", 
                    "Cadastro de Usuários",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Cadastro de Usuários",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
