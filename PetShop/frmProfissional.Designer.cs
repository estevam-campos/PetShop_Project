namespace PetShop
{
    partial class frmProfissional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfissional));
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblAtuacao = new System.Windows.Forms.Label();
            this.txtAtuacao = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.grpLista.SuspendLayout();
            this.grpDados.SuspendLayout();
            this.grpPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.rdbInativo);
            this.grpStatus.Controls.Add(this.rdbAtivo);
            this.grpStatus.Location = new System.Drawing.Point(281, 9);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(67, 61);
            this.grpStatus.TabIndex = 2;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Location = new System.Drawing.Point(6, 36);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(57, 17);
            this.rdbInativo.TabIndex = 1;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Checked = true;
            this.rdbAtivo.Location = new System.Drawing.Point(6, 15);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdbAtivo.TabIndex = 0;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // grdDados
            // 
            this.grdDados.AllowUserToAddRows = false;
            this.grdDados.AllowUserToDeleteRows = false;
            this.grdDados.AllowUserToResizeColumns = false;
            this.grdDados.AllowUserToResizeRows = false;
            this.grdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDados.Location = new System.Drawing.Point(6, 19);
            this.grdDados.MultiSelect = false;
            this.grdDados.Name = "grdDados";
            this.grdDados.ReadOnly = true;
            this.grdDados.RowHeadersVisible = false;
            this.grdDados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDados.Size = new System.Drawing.Size(342, 190);
            this.grdDados.TabIndex = 0;
            this.grdDados.TabStop = false;
            this.grdDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDados_CellClick);
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.grdDados);
            this.grpLista.Location = new System.Drawing.Point(12, 71);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(360, 215);
            this.grpLista.TabIndex = 1;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Profissionais Cadastrados";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.grpStatus);
            this.grpDados.Controls.Add(this.label5);
            this.grpDados.Controls.Add(this.txtNome);
            this.grpDados.Controls.Add(this.lblAtuacao);
            this.grpDados.Controls.Add(this.txtAtuacao);
            this.grpDados.Location = new System.Drawing.Point(12, 292);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(360, 77);
            this.grpDados.TabIndex = 2;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados para Cadastro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 18);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblAtuacao
            // 
            this.lblAtuacao.AutoSize = true;
            this.lblAtuacao.Location = new System.Drawing.Point(9, 47);
            this.lblAtuacao.Name = "lblAtuacao";
            this.lblAtuacao.Size = new System.Drawing.Size(47, 13);
            this.lblAtuacao.TabIndex = 19;
            this.lblAtuacao.Text = "Atuação";
            // 
            // txtAtuacao
            // 
            this.txtAtuacao.Location = new System.Drawing.Point(60, 44);
            this.txtAtuacao.MaxLength = 20;
            this.txtAtuacao.Name = "txtAtuacao";
            this.txtAtuacao.Size = new System.Drawing.Size(215, 20);
            this.txtAtuacao.TabIndex = 1;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(6, 25);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(71, 13);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquisar por";
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Controls.Add(this.lblPesquisa);
            this.grpPesquisa.Location = new System.Drawing.Point(12, 12);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(360, 53);
            this.grpPesquisa.TabIndex = 0;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Dados para Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(83, 22);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(265, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::PetShop.Properties.Resources.exit;
            this.btnCancelar.Location = new System.Drawing.Point(256, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 41);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::PetShop.Properties.Resources.FloppyDisks;
            this.btnGravar.Location = new System.Drawing.Point(12, 375);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(115, 41);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::PetShop.Properties.Resources.eraser;
            this.btnLimpar.Location = new System.Drawing.Point(134, 375);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 41);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 425);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grpPesquisa);
            this.Controls.Add(this.btnLimpar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProfissional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetShop - Cadastro de Profissionais";
            this.Load += new System.EventHandler(this.frmProfissional_Load);
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.grpLista.ResumeLayout(false);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblAtuacao;
        private System.Windows.Forms.TextBox txtAtuacao;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnLimpar;
    }
}