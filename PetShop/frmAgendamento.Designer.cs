namespace PetShop
{
    partial class frmAgendamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendamento));
            this.grpAgendamento = new System.Windows.Forms.GroupBox();
            this.grdAgendamento = new System.Windows.Forms.DataGridView();
            this.cboSituacao = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpAnimais = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.cboAnimais = new System.Windows.Forms.ComboBox();
            this.lblNomeAnimal = new System.Windows.Forms.Label();
            this.cboProfissional = new System.Windows.Forms.ComboBox();
            this.lblProfissional = new System.Windows.Forms.Label();
            this.dtpAgendamento = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.grpObservacoes = new System.Windows.Forms.GroupBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.grpAgendamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgendamento)).BeginInit();
            this.grpAnimais.SuspendLayout();
            this.grpObservacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAgendamento
            // 
            this.grpAgendamento.Controls.Add(this.grdAgendamento);
            this.grpAgendamento.Location = new System.Drawing.Point(12, 43);
            this.grpAgendamento.Name = "grpAgendamento";
            this.grpAgendamento.Size = new System.Drawing.Size(749, 354);
            this.grpAgendamento.TabIndex = 3;
            this.grpAgendamento.TabStop = false;
            this.grpAgendamento.Text = "Agendamentos";
            // 
            // grdAgendamento
            // 
            this.grdAgendamento.AllowUserToAddRows = false;
            this.grdAgendamento.AllowUserToDeleteRows = false;
            this.grdAgendamento.AllowUserToResizeColumns = false;
            this.grdAgendamento.AllowUserToResizeRows = false;
            this.grdAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAgendamento.Location = new System.Drawing.Point(6, 16);
            this.grdAgendamento.MultiSelect = false;
            this.grdAgendamento.Name = "grdAgendamento";
            this.grdAgendamento.ReadOnly = true;
            this.grdAgendamento.RowHeadersVisible = false;
            this.grdAgendamento.RowHeadersWidth = 62;
            this.grdAgendamento.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.grdAgendamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAgendamento.Size = new System.Drawing.Size(738, 330);
            this.grdAgendamento.TabIndex = 0;
            // 
            // cboSituacao
            // 
            this.cboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Location = new System.Drawing.Point(138, 403);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(238, 21);
            this.cboSituacao.TabIndex = 33;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(15, 407);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(118, 13);
            this.lblSituacao.TabIndex = 34;
            this.lblSituacao.Text = "Situação Agendamento";
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::PetShop.Properties.Resources.FloppyDisks;
            this.btnGravar.Location = new System.Drawing.Point(18, 434);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(115, 41);
            this.btnGravar.TabIndex = 42;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::PetShop.Properties.Resources.eraser;
            this.btnLimpar.Location = new System.Drawing.Point(140, 434);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 41);
            this.btnLimpar.TabIndex = 43;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::PetShop.Properties.Resources.exit;
            this.btnCancelar.Location = new System.Drawing.Point(262, 434);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 41);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpAnimais
            // 
            this.grpAnimais.Controls.Add(this.txtCPF);
            this.grpAnimais.Controls.Add(this.label3);
            this.grpAnimais.Controls.Add(this.txtSexo);
            this.grpAnimais.Controls.Add(this.lblNome);
            this.grpAnimais.Controls.Add(this.txtDataNascimento);
            this.grpAnimais.Controls.Add(this.txtNomeCliente);
            this.grpAnimais.Controls.Add(this.lblSexo);
            this.grpAnimais.Controls.Add(this.lblDataNascimento);
            this.grpAnimais.Controls.Add(this.lblRaca);
            this.grpAnimais.Controls.Add(this.txtRaca);
            this.grpAnimais.Controls.Add(this.lblEspecie);
            this.grpAnimais.Controls.Add(this.txtEspecie);
            this.grpAnimais.Controls.Add(this.cboAnimais);
            this.grpAnimais.Controls.Add(this.lblNomeAnimal);
            this.grpAnimais.Location = new System.Drawing.Point(767, 12);
            this.grpAnimais.Name = "grpAnimais";
            this.grpAnimais.Size = new System.Drawing.Size(372, 190);
            this.grpAnimais.TabIndex = 45;
            this.grpAnimais.TabStop = false;
            this.grpAnimais.Text = "Animais";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(50, 23);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(81, 20);
            this.txtCPF.TabIndex = 56;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "CPF";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(277, 154);
            this.txtSexo.MaxLength = 100;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(82, 20);
            this.txtSexo.TabIndex = 54;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 52);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 13);
            this.lblNome.TabIndex = 58;
            this.lblNome.Text = "Nome Cliente";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(112, 154);
            this.txtDataNascimento.MaxLength = 100;
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.ReadOnly = true;
            this.txtDataNascimento.Size = new System.Drawing.Size(122, 20);
            this.txtDataNascimento.TabIndex = 53;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(85, 49);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(274, 20);
            this.txtNomeCliente.TabIndex = 57;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(240, 164);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 52;
            this.lblSexo.Text = "Sexo";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(9, 157);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.lblDataNascimento.TabIndex = 51;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(9, 131);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(33, 13);
            this.lblRaca.TabIndex = 50;
            this.lblRaca.Text = "Raça";
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(56, 128);
            this.txtRaca.MaxLength = 100;
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.ReadOnly = true;
            this.txtRaca.Size = new System.Drawing.Size(303, 20);
            this.txtRaca.TabIndex = 49;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(9, 105);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(45, 13);
            this.lblEspecie.TabIndex = 48;
            this.lblEspecie.Text = "Espécie";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(68, 102);
            this.txtEspecie.MaxLength = 100;
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.ReadOnly = true;
            this.txtEspecie.Size = new System.Drawing.Size(291, 20);
            this.txtEspecie.TabIndex = 47;
            // 
            // cboAnimais
            // 
            this.cboAnimais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnimais.FormattingEnabled = true;
            this.cboAnimais.Location = new System.Drawing.Point(112, 75);
            this.cboAnimais.Name = "cboAnimais";
            this.cboAnimais.Size = new System.Drawing.Size(247, 21);
            this.cboAnimais.TabIndex = 46;
            this.cboAnimais.SelectedIndexChanged += new System.EventHandler(this.cboAnimais_SelectedIndexChanged);
            // 
            // lblNomeAnimal
            // 
            this.lblNomeAnimal.AutoSize = true;
            this.lblNomeAnimal.Location = new System.Drawing.Point(9, 78);
            this.lblNomeAnimal.Name = "lblNomeAnimal";
            this.lblNomeAnimal.Size = new System.Drawing.Size(69, 13);
            this.lblNomeAnimal.TabIndex = 45;
            this.lblNomeAnimal.Text = "Nome Animal";
            // 
            // cboProfissional
            // 
            this.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfissional.FormattingEnabled = true;
            this.cboProfissional.Location = new System.Drawing.Point(81, 18);
            this.cboProfissional.Name = "cboProfissional";
            this.cboProfissional.Size = new System.Drawing.Size(271, 21);
            this.cboProfissional.TabIndex = 46;
            // 
            // lblProfissional
            // 
            this.lblProfissional.AutoSize = true;
            this.lblProfissional.Location = new System.Drawing.Point(15, 21);
            this.lblProfissional.Name = "lblProfissional";
            this.lblProfissional.Size = new System.Drawing.Size(60, 13);
            this.lblProfissional.TabIndex = 49;
            this.lblProfissional.Text = "Profissional";
            // 
            // dtpAgendamento
            // 
            this.dtpAgendamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAgendamento.Location = new System.Drawing.Point(392, 18);
            this.dtpAgendamento.Name = "dtpAgendamento";
            this.dtpAgendamento.Size = new System.Drawing.Size(96, 20);
            this.dtpAgendamento.TabIndex = 48;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(358, 21);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 47;
            this.lblData.Text = "Data";
            // 
            // grpObservacoes
            // 
            this.grpObservacoes.Controls.Add(this.txtObservacoes);
            this.grpObservacoes.Location = new System.Drawing.Point(767, 208);
            this.grpObservacoes.Name = "grpObservacoes";
            this.grpObservacoes.Size = new System.Drawing.Size(372, 272);
            this.grpObservacoes.TabIndex = 50;
            this.grpObservacoes.TabStop = false;
            this.grpObservacoes.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(6, 19);
            this.txtObservacoes.MaxLength = 11;
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(360, 247);
            this.txtObservacoes.TabIndex = 57;
            // 
            // frmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 488);
            this.Controls.Add(this.grpObservacoes);
            this.Controls.Add(this.cboProfissional);
            this.Controls.Add(this.lblProfissional);
            this.Controls.Add(this.dtpAgendamento);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.grpAnimais);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboSituacao);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.grpAgendamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetShop - Agendamentos";
            this.Load += new System.EventHandler(this.frmAgendamento_Load);
            this.grpAgendamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAgendamento)).EndInit();
            this.grpAnimais.ResumeLayout(false);
            this.grpAnimais.PerformLayout();
            this.grpObservacoes.ResumeLayout(false);
            this.grpObservacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgendamento;
        private System.Windows.Forms.DataGridView grdAgendamento;
        private System.Windows.Forms.ComboBox cboSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpAnimais;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.ComboBox cboAnimais;
        private System.Windows.Forms.Label lblNomeAnimal;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.ComboBox cboProfissional;
        private System.Windows.Forms.Label lblProfissional;
        private System.Windows.Forms.DateTimePicker dtpAgendamento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox grpObservacoes;
        private System.Windows.Forms.TextBox txtObservacoes;
    }
}