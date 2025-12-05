namespace PetShop
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblServidor = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBanco = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrTempo = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProprietarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnimais = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfissionais = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAgendamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDominios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRaca = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEspecie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSexo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTipoTelefone = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSituacao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblServidor,
            this.lblBanco,
            this.lblTempo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(196, 17);
            this.lblUsuario.Spring = true;
            this.lblUsuario.Text = "Usuário:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServidor
            // 
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(196, 17);
            this.lblServidor.Spring = true;
            this.lblServidor.Text = "Servidor:";
            // 
            // lblBanco
            // 
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(196, 17);
            this.lblBanco.Spring = true;
            this.lblBanco.Text = "Banco:";
            // 
            // lblTempo
            // 
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(196, 17);
            this.lblTempo.Spring = true;
            this.lblTempo.Text = "Tempo: 00:00:00";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrTempo
            // 
            this.tmrTempo.Interval = 1000;
            this.tmrTempo.Tick += new System.EventHandler(this.tmrTempo_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastro,
            this.mnuAgendamentos,
            this.mnuDominios,
            this.mnuSaida,
            this.mnuSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuProprietarios,
            this.mnuAnimais,
            this.mnuProfissionais});
            this.mnuCadastro.Image = global::PetShop.Properties.Resources.note;
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(82, 20);
            this.mnuCadastro.Text = "&Cadastro";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Image = global::PetShop.Properties.Resources.businesspeople;
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mnuUsuarios.Text = "&Usuários";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mnuProprietarios
            // 
            this.mnuProprietarios.Image = global::PetShop.Properties.Resources.businesswoman2;
            this.mnuProprietarios.Name = "mnuProprietarios";
            this.mnuProprietarios.Size = new System.Drawing.Size(180, 22);
            this.mnuProprietarios.Text = "&Proprietários";
            this.mnuProprietarios.Click += new System.EventHandler(this.mnuProprietarios_Click);
            // 
            // mnuAnimais
            // 
            this.mnuAnimais.Image = global::PetShop.Properties.Resources.Dog;
            this.mnuAnimais.Name = "mnuAnimais";
            this.mnuAnimais.Size = new System.Drawing.Size(180, 22);
            this.mnuAnimais.Text = "&Animais";
            this.mnuAnimais.Click += new System.EventHandler(this.mnuAnimais_Click);
            // 
            // mnuProfissionais
            // 
            this.mnuProfissionais.Image = global::PetShop.Properties.Resources.stockbroker3;
            this.mnuProfissionais.Name = "mnuProfissionais";
            this.mnuProfissionais.Size = new System.Drawing.Size(180, 22);
            this.mnuProfissionais.Text = "Pro&fissionais";
            this.mnuProfissionais.Click += new System.EventHandler(this.mnuProfissionais_Click);
            // 
            // mnuAgendamentos
            // 
            this.mnuAgendamentos.Image = global::PetShop.Properties.Resources.calendar;
            this.mnuAgendamentos.Name = "mnuAgendamentos";
            this.mnuAgendamentos.Size = new System.Drawing.Size(116, 20);
            this.mnuAgendamentos.Text = "&Agendamentos";
            this.mnuAgendamentos.Click += new System.EventHandler(this.mnuAgendamentos_Click);
            // 
            // mnuDominios
            // 
            this.mnuDominios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRaca,
            this.mnuEspecie,
            this.mnuSexo,
            this.mnuTipoTelefone,
            this.mnuSituacao});
            this.mnuDominios.Image = global::PetShop.Properties.Resources.notebook;
            this.mnuDominios.Name = "mnuDominios";
            this.mnuDominios.Size = new System.Drawing.Size(86, 20);
            this.mnuDominios.Text = "&Domínios";
            // 
            // mnuRaca
            // 
            this.mnuRaca.Image = global::PetShop.Properties.Resources.raca;
            this.mnuRaca.Name = "mnuRaca";
            this.mnuRaca.Size = new System.Drawing.Size(198, 22);
            this.mnuRaca.Text = "&Raça";
            this.mnuRaca.Click += new System.EventHandler(this.mnuRaca_Click);
            // 
            // mnuEspecie
            // 
            this.mnuEspecie.Image = global::PetShop.Properties.Resources.especie;
            this.mnuEspecie.Name = "mnuEspecie";
            this.mnuEspecie.Size = new System.Drawing.Size(198, 22);
            this.mnuEspecie.Text = "&Espécie";
            this.mnuEspecie.Click += new System.EventHandler(this.mnuEspecie_Click);
            // 
            // mnuSexo
            // 
            this.mnuSexo.Image = global::PetShop.Properties.Resources.sexo;
            this.mnuSexo.Name = "mnuSexo";
            this.mnuSexo.Size = new System.Drawing.Size(198, 22);
            this.mnuSexo.Text = "&Sexo";
            this.mnuSexo.Click += new System.EventHandler(this.mnuSexo_Click);
            // 
            // mnuTipoTelefone
            // 
            this.mnuTipoTelefone.Image = global::PetShop.Properties.Resources.telephone2;
            this.mnuTipoTelefone.Name = "mnuTipoTelefone";
            this.mnuTipoTelefone.Size = new System.Drawing.Size(198, 22);
            this.mnuTipoTelefone.Text = "&Tipo Telefone";
            this.mnuTipoTelefone.Click += new System.EventHandler(this.mnuTipoTelefone_Click);
            // 
            // mnuSituacao
            // 
            this.mnuSituacao.Image = global::PetShop.Properties.Resources.calendar;
            this.mnuSituacao.Name = "mnuSituacao";
            this.mnuSituacao.Size = new System.Drawing.Size(198, 22);
            this.mnuSituacao.Text = "Situação &Agendamento";
            this.mnuSituacao.Click += new System.EventHandler(this.mnuSituacao_Click);
            // 
            // mnuSaida
            // 
            this.mnuSaida.Image = global::PetShop.Properties.Resources.door2_open;
            this.mnuSaida.Name = "mnuSaida";
            this.mnuSaida.Size = new System.Drawing.Size(63, 20);
            this.mnuSaida.Text = "&Saída";
            this.mnuSaida.Click += new System.EventHandler(this.mnuSaida_Click);
            // 
            // mnuSobre
            // 
            this.mnuSobre.Image = global::PetShop.Properties.Resources.information;
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(65, 20);
            this.mnuSobre.Text = "Sobr&e";
            this.mnuSobre.Click += new System.EventHandler(this.mnuSobre_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "PetShop - Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblServidor;
        private System.Windows.Forms.ToolStripStatusLabel lblBanco;
        private System.Windows.Forms.ToolStripStatusLabel lblTempo;
        private System.Windows.Forms.Timer tmrTempo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuProprietarios;
        private System.Windows.Forms.ToolStripMenuItem mnuAnimais;
        private System.Windows.Forms.ToolStripMenuItem mnuAgendamentos;
        private System.Windows.Forms.ToolStripMenuItem mnuDominios;
        private System.Windows.Forms.ToolStripMenuItem mnuRaca;
        private System.Windows.Forms.ToolStripMenuItem mnuEspecie;
        private System.Windows.Forms.ToolStripMenuItem mnuSexo;
        private System.Windows.Forms.ToolStripMenuItem mnuTipoTelefone;
        private System.Windows.Forms.ToolStripMenuItem mnuSaida;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.ToolStripMenuItem mnuSituacao;
        private System.Windows.Forms.ToolStripMenuItem mnuProfissionais;
    }
}

