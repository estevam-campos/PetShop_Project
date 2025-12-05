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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        DateTime dttLogin;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            dttLogin = DateTime.Now;
            tmrTempo.Enabled = true;
            Left = 0;
            Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            lblUsuario.Text = $"Usuário: {Global.nome} ({Global.user})";
            lblServidor.Text = $"Servidor: {Global.servidor}";
            lblBanco.Text = $"Banco: {Global.banco}";
        }
        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now.Subtract(dttLogin);
            lblTempo.Text =
                $"{ts.Hours.ToString("00")}:" +
                $"{ts.Minutes.ToString("00")}:" +
                $"{ts.Seconds.ToString("00")}";
        }
        private void mnuSaida_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação?", "PetShop",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmUsuario());
        }
        private void AbrirForm(Form form)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (form.Name == filho.Name)
                {
                    filho.Activate();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }
        private void mnuEspecie_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmEspecie());
        }
        private void mnuSexo_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmSexo());
        }
        private void mnuTipoTelefone_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmTipoTelefone());
        }
        private void mnuRaca_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmRaca());
        }
        private void mnuProprietarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmProprietario());
        }
        private void mnuAnimais_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAnimal());
        }
        private void mnuSobre_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmSobre());
        }
        private void mnuSituacao_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmSituacao());
        }
        private void mnuAgendamentos_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAgendamento());
        }
        private void mnuProfissionais_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmProfissional());
        }
    }
}
