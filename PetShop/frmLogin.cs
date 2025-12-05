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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty || txtSenha.Text == string.Empty)
            {
                return;
            }
            string mensagem = string.Empty;
            Usuario usuario = new Usuario();
            usuario.user = txtUsuario.Text;
            if (usuario.Autenticar(txtSenha.Text))
            {
                if (!usuario.ativo)
                {
                    mensagem = "Usuário inativo! Entre em contato com o administrador.";
                    MessageBox.Show(mensagem, "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mensagem = $"Seja bem vindo {usuario.nome}!!!";
                MessageBox.Show(mensagem, "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Global.nome = usuario.nome;
                Global.user = usuario.user;
                Global.idUsuario = usuario.id;
                Close();
            }
            else
            {
                mensagem = "Usuário e/ou senha inválidos!!!";
                MessageBox.Show(mensagem, "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
