namespace PetShop
{
    partial class frmAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnimal));
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.rdbCPF = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.lblNomeAnimal = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.cboRaca = new System.Windows.Forms.ComboBox();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.grpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.grpLista.SuspendLayout();
            this.grpDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::PetShop.Properties.Resources.FloppyDisks;
            this.btnGravar.Location = new System.Drawing.Point(12, 451);
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
            this.btnLimpar.Location = new System.Drawing.Point(181, 451);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 41);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::PetShop.Properties.Resources.exit;
            this.btnCancelar.Location = new System.Drawing.Point(350, 451);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 41);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(83, 22);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(245, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
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
            this.grpPesquisa.Controls.Add(this.rdbCPF);
            this.grpPesquisa.Controls.Add(this.rdbNome);
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Controls.Add(this.lblPesquisa);
            this.grpPesquisa.Location = new System.Drawing.Point(12, 12);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(453, 53);
            this.grpPesquisa.TabIndex = 0;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Dados para Pesquisa";
            // 
            // rdbCPF
            // 
            this.rdbCPF.AutoSize = true;
            this.rdbCPF.Location = new System.Drawing.Point(397, 24);
            this.rdbCPF.Name = "rdbCPF";
            this.rdbCPF.Size = new System.Drawing.Size(45, 17);
            this.rdbCPF.TabIndex = 2;
            this.rdbCPF.TabStop = true;
            this.rdbCPF.Text = "CPF";
            this.rdbCPF.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Checked = true;
            this.rdbNome.Location = new System.Drawing.Point(337, 23);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(53, 17);
            this.rdbNome.TabIndex = 1;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
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
            this.grdDados.RowHeadersWidth = 62;
            this.grdDados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDados.Size = new System.Drawing.Size(441, 190);
            this.grdDados.TabIndex = 0;
            this.grdDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDados_CellClick);
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.grdDados);
            this.grpLista.Location = new System.Drawing.Point(12, 71);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(453, 215);
            this.grpLista.TabIndex = 1;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Animais Cadastrados";
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Location = new System.Drawing.Point(52, 100);
            this.txtNomeAnimal.MaxLength = 100;
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(213, 20);
            this.txtNomeAnimal.TabIndex = 3;
            // 
            // lblNomeAnimal
            // 
            this.lblNomeAnimal.AutoSize = true;
            this.lblNomeAnimal.Location = new System.Drawing.Point(11, 103);
            this.lblNomeAnimal.Name = "lblNomeAnimal";
            this.lblNomeAnimal.Size = new System.Drawing.Size(35, 13);
            this.lblNomeAnimal.TabIndex = 44;
            this.lblNomeAnimal.Text = "Nome";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.txtCPF);
            this.grpDados.Controls.Add(this.label3);
            this.grpDados.Controls.Add(this.lblNome);
            this.grpDados.Controls.Add(this.txtNome);
            this.grpDados.Controls.Add(this.cboSexo);
            this.grpDados.Controls.Add(this.lblSexo);
            this.grpDados.Controls.Add(this.dtpDataNascimento);
            this.grpDados.Controls.Add(this.lblDataNascimento);
            this.grpDados.Controls.Add(this.cboRaca);
            this.grpDados.Controls.Add(this.cboEspecie);
            this.grpDados.Controls.Add(this.lblEspecie);
            this.grpDados.Controls.Add(this.lblRaca);
            this.grpDados.Controls.Add(this.lblNomeAnimal);
            this.grpDados.Controls.Add(this.txtNomeAnimal);
            this.grpDados.Location = new System.Drawing.Point(12, 292);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(453, 154);
            this.grpDados.TabIndex = 2;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados para Cadastro";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(43, 19);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(81, 20);
            this.txtCPF.TabIndex = 0;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(130, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 54;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(171, 19);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(276, 20);
            this.txtNome.TabIndex = 52;
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(52, 126);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(132, 21);
            this.cboSexo.TabIndex = 5;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(11, 129);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 50;
            this.lblSexo.Text = "Sexo";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(368, 100);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(79, 20);
            this.dtpDataNascimento.TabIndex = 4;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(271, 103);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.lblDataNascimento.TabIndex = 48;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // cboRaca
            // 
            this.cboRaca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboRaca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRaca.FormattingEnabled = true;
            this.cboRaca.Location = new System.Drawing.Point(52, 72);
            this.cboRaca.Name = "cboRaca";
            this.cboRaca.Size = new System.Drawing.Size(395, 21);
            this.cboRaca.TabIndex = 2;
            // 
            // cboEspecie
            // 
            this.cboEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Location = new System.Drawing.Point(62, 45);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(385, 21);
            this.cboEspecie.TabIndex = 1;
            this.cboEspecie.SelectedIndexChanged += new System.EventHandler(this.cboEspecie_SelectedIndexChanged);
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(11, 48);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(45, 13);
            this.lblEspecie.TabIndex = 45;
            this.lblEspecie.Text = "Espécie";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(13, 75);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(33, 13);
            this.lblRaca.TabIndex = 45;
            this.lblRaca.Text = "Raça";
            // 
            // frmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 498);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpPesquisa);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.grpDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetShop - Cadastro de Animais";
            this.Load += new System.EventHandler(this.frmAnimal_Load);
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.grpLista.ResumeLayout(false);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.Label lblNomeAnimal;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.ComboBox cboRaca;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rdbCPF;
        private System.Windows.Forms.RadioButton rdbNome;
    }
}