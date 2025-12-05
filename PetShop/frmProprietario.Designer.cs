namespace PetShop
{
    partial class frmProprietario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProprietario));
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.grpTelefone = new System.Windows.Forms.GroupBox();
            this.cboTipoTelefone = new System.Windows.Forms.ComboBox();
            this.lstTelefone = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRem = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grpAnimais = new System.Windows.Forms.GroupBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.cboAnimais = new System.Windows.Forms.ComboBox();
            this.lblNomeAnimal = new System.Windows.Forms.Label();
            this.grpAtendimentos = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tabAtendimentos = new System.Windows.Forms.TabControl();
            this.tabHistorico = new System.Windows.Forms.TabPage();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.grdHistorico = new System.Windows.Forms.DataGridView();
            this.tabMedicamento = new System.Windows.Forms.TabPage();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.grdMedicamento = new System.Windows.Forms.DataGridView();
            this.tabVacina = new System.Windows.Forms.TabPage();
            this.txtVacina = new System.Windows.Forms.TextBox();
            this.grdVacina = new System.Windows.Forms.DataGridView();
            this.tabVermifugo = new System.Windows.Forms.TabPage();
            this.txtVermifugo = new System.Windows.Forms.TextBox();
            this.grdVermifugo = new System.Windows.Forms.DataGridView();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.grpDados.SuspendLayout();
            this.grpTelefone.SuspendLayout();
            this.grpAnimais.SuspendLayout();
            this.grpAtendimentos.SuspendLayout();
            this.tabAtendimentos.SuspendLayout();
            this.tabHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorico)).BeginInit();
            this.tabMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicamento)).BeginInit();
            this.tabVacina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVacina)).BeginInit();
            this.tabVermifugo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVermifugo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.grdDados);
            this.grpLista.Location = new System.Drawing.Point(8, 71);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(453, 215);
            this.grpLista.TabIndex = 1;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Proprietários Cadastradas";
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
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Controls.Add(this.lblPesquisa);
            this.grpPesquisa.Location = new System.Drawing.Point(8, 12);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(453, 53);
            this.grpPesquisa.TabIndex = 0;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Dados para Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(83, 22);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(364, 20);
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
            // grpDados
            // 
            this.grpDados.Controls.Add(this.grpTelefone);
            this.grpDados.Controls.Add(this.cboEstado);
            this.grpDados.Controls.Add(this.label15);
            this.grpDados.Controls.Add(this.cboCidade);
            this.grpDados.Controls.Add(this.label14);
            this.grpDados.Controls.Add(this.txtComplemento);
            this.grpDados.Controls.Add(this.label13);
            this.grpDados.Controls.Add(this.txtBairro);
            this.grpDados.Controls.Add(this.label12);
            this.grpDados.Controls.Add(this.txtNumero);
            this.grpDados.Controls.Add(this.label11);
            this.grpDados.Controls.Add(this.txtCEP);
            this.grpDados.Controls.Add(this.label10);
            this.grpDados.Controls.Add(this.txtEndereco);
            this.grpDados.Controls.Add(this.label8);
            this.grpDados.Controls.Add(this.txtCPF);
            this.grpDados.Controls.Add(this.label3);
            this.grpDados.Controls.Add(this.label2);
            this.grpDados.Controls.Add(this.txtNome);
            this.grpDados.Location = new System.Drawing.Point(8, 292);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(453, 241);
            this.grpDados.TabIndex = 2;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados para Cadastro";
            // 
            // grpTelefone
            // 
            this.grpTelefone.Controls.Add(this.cboTipoTelefone);
            this.grpTelefone.Controls.Add(this.lstTelefone);
            this.grpTelefone.Controls.Add(this.label9);
            this.grpTelefone.Controls.Add(this.btnRem);
            this.grpTelefone.Controls.Add(this.txtTelefone);
            this.grpTelefone.Controls.Add(this.btnAdd);
            this.grpTelefone.Controls.Add(this.label6);
            this.grpTelefone.Location = new System.Drawing.Point(6, 128);
            this.grpTelefone.Name = "grpTelefone";
            this.grpTelefone.Size = new System.Drawing.Size(441, 108);
            this.grpTelefone.TabIndex = 57;
            this.grpTelefone.TabStop = false;
            this.grpTelefone.Text = "Telefones";
            // 
            // cboTipoTelefone
            // 
            this.cboTipoTelefone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTipoTelefone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoTelefone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTelefone.FormattingEnabled = true;
            this.cboTipoTelefone.Location = new System.Drawing.Point(97, 57);
            this.cboTipoTelefone.Name = "cboTipoTelefone";
            this.cboTipoTelefone.Size = new System.Drawing.Size(134, 21);
            this.cboTipoTelefone.TabIndex = 59;
            // 
            // lstTelefone
            // 
            this.lstTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstTelefone.FormattingEnabled = true;
            this.lstTelefone.Location = new System.Drawing.Point(297, 19);
            this.lstTelefone.Name = "lstTelefone";
            this.lstTelefone.Size = new System.Drawing.Size(134, 82);
            this.lstTelefone.TabIndex = 0;
            this.lstTelefone.SelectedIndexChanged += new System.EventHandler(this.lstTelefone_SelectedIndexChanged);
            this.lstTelefone.DoubleClick += new System.EventHandler(this.lstTelefone_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Tipo Telefone";
            // 
            // btnRem
            // 
            this.btnRem.Image = global::PetShop.Properties.Resources.Minus_16;
            this.btnRem.Location = new System.Drawing.Point(248, 61);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(40, 40);
            this.btnRem.TabIndex = 56;
            this.btnRem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRem.UseVisualStyleBackColor = true;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(70, 30);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(161, 20);
            this.txtTelefone.TabIndex = 58;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PetShop.Properties.Resources.add_16;
            this.btnAdd.Location = new System.Drawing.Point(248, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Telefone";
            // 
            // cboEstado
            // 
            this.cboEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(405, 97);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(42, 21);
            this.cboEstado.TabIndex = 7;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(362, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Estado";
            // 
            // cboCidade
            // 
            this.cboCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(51, 97);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(305, 21);
            this.cboCidade.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Cidade";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(83, 71);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(130, 20);
            this.txtComplemento.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Complemento";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(257, 71);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(190, 20);
            this.txtBairro.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(219, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Bairro";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(416, 45);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(31, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(391, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Nº";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(44, 45);
            this.txtCEP.MaxLength = 8;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(58, 20);
            this.txtCEP.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "CEP";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(164, 45);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(221, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Endereço";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(366, 19);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(81, 20);
            this.txtCPF.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(51, 19);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(276, 20);
            this.txtNome.TabIndex = 0;
            // 
            // grpAnimais
            // 
            this.grpAnimais.Controls.Add(this.txtSexo);
            this.grpAnimais.Controls.Add(this.txtDataNascimento);
            this.grpAnimais.Controls.Add(this.lblSexo);
            this.grpAnimais.Controls.Add(this.lblDataNascimento);
            this.grpAnimais.Controls.Add(this.lblRaca);
            this.grpAnimais.Controls.Add(this.txtRaca);
            this.grpAnimais.Controls.Add(this.lblEspecie);
            this.grpAnimais.Controls.Add(this.txtEspecie);
            this.grpAnimais.Controls.Add(this.cboAnimais);
            this.grpAnimais.Controls.Add(this.lblNomeAnimal);
            this.grpAnimais.Location = new System.Drawing.Point(467, 12);
            this.grpAnimais.Name = "grpAnimais";
            this.grpAnimais.Size = new System.Drawing.Size(371, 134);
            this.grpAnimais.TabIndex = 7;
            this.grpAnimais.TabStop = false;
            this.grpAnimais.Text = "Animais";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(277, 101);
            this.txtSexo.MaxLength = 100;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(82, 20);
            this.txtSexo.TabIndex = 54;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(112, 101);
            this.txtDataNascimento.MaxLength = 100;
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.ReadOnly = true;
            this.txtDataNascimento.Size = new System.Drawing.Size(122, 20);
            this.txtDataNascimento.TabIndex = 53;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(240, 104);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 52;
            this.lblSexo.Text = "Sexo";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(17, 104);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.lblDataNascimento.TabIndex = 51;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(17, 78);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(33, 13);
            this.lblRaca.TabIndex = 50;
            this.lblRaca.Text = "Raça";
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(56, 75);
            this.txtRaca.MaxLength = 100;
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.ReadOnly = true;
            this.txtRaca.Size = new System.Drawing.Size(303, 20);
            this.txtRaca.TabIndex = 49;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(17, 52);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(45, 13);
            this.lblEspecie.TabIndex = 48;
            this.lblEspecie.Text = "Espécie";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(68, 49);
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
            this.cboAnimais.Location = new System.Drawing.Point(57, 22);
            this.cboAnimais.Name = "cboAnimais";
            this.cboAnimais.Size = new System.Drawing.Size(184, 21);
            this.cboAnimais.TabIndex = 46;
            this.cboAnimais.SelectedIndexChanged += new System.EventHandler(this.cboAnimais_SelectedIndexChanged);
            // 
            // lblNomeAnimal
            // 
            this.lblNomeAnimal.AutoSize = true;
            this.lblNomeAnimal.Location = new System.Drawing.Point(16, 25);
            this.lblNomeAnimal.Name = "lblNomeAnimal";
            this.lblNomeAnimal.Size = new System.Drawing.Size(35, 13);
            this.lblNomeAnimal.TabIndex = 45;
            this.lblNomeAnimal.Text = "Nome";
            // 
            // grpAtendimentos
            // 
            this.grpAtendimentos.Controls.Add(this.btnAdicionar);
            this.grpAtendimentos.Controls.Add(this.tabAtendimentos);
            this.grpAtendimentos.Location = new System.Drawing.Point(467, 152);
            this.grpAtendimentos.Name = "grpAtendimentos";
            this.grpAtendimentos.Size = new System.Drawing.Size(364, 428);
            this.grpAtendimentos.TabIndex = 8;
            this.grpAtendimentos.TabStop = false;
            this.grpAtendimentos.Text = "Histórico de Atendimentos";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = global::PetShop.Properties.Resources.Historico;
            this.btnAdicionar.Location = new System.Drawing.Point(3, 381);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(354, 41);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "&Adicionar Histórico";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tabAtendimentos
            // 
            this.tabAtendimentos.Controls.Add(this.tabHistorico);
            this.tabAtendimentos.Controls.Add(this.tabMedicamento);
            this.tabAtendimentos.Controls.Add(this.tabVacina);
            this.tabAtendimentos.Controls.Add(this.tabVermifugo);
            this.tabAtendimentos.Location = new System.Drawing.Point(3, 14);
            this.tabAtendimentos.Name = "tabAtendimentos";
            this.tabAtendimentos.SelectedIndex = 0;
            this.tabAtendimentos.Size = new System.Drawing.Size(358, 362);
            this.tabAtendimentos.TabIndex = 0;
            this.tabAtendimentos.SelectedIndexChanged += new System.EventHandler(this.tabAtendimentos_SelectedIndexChanged);
            // 
            // tabHistorico
            // 
            this.tabHistorico.Controls.Add(this.txtHistorico);
            this.tabHistorico.Controls.Add(this.grdHistorico);
            this.tabHistorico.Location = new System.Drawing.Point(4, 22);
            this.tabHistorico.Name = "tabHistorico";
            this.tabHistorico.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorico.Size = new System.Drawing.Size(350, 336);
            this.tabHistorico.TabIndex = 0;
            this.tabHistorico.Text = "Histórico";
            this.tabHistorico.UseVisualStyleBackColor = true;
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(3, 201);
            this.txtHistorico.MaxLength = 100;
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.Size = new System.Drawing.Size(344, 129);
            this.txtHistorico.TabIndex = 49;
            // 
            // grdHistorico
            // 
            this.grdHistorico.AllowUserToAddRows = false;
            this.grdHistorico.AllowUserToDeleteRows = false;
            this.grdHistorico.AllowUserToResizeColumns = false;
            this.grdHistorico.AllowUserToResizeRows = false;
            this.grdHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistorico.Location = new System.Drawing.Point(3, 3);
            this.grdHistorico.MultiSelect = false;
            this.grdHistorico.Name = "grdHistorico";
            this.grdHistorico.ReadOnly = true;
            this.grdHistorico.RowHeadersVisible = false;
            this.grdHistorico.RowHeadersWidth = 62;
            this.grdHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHistorico.Size = new System.Drawing.Size(344, 192);
            this.grdHistorico.TabIndex = 1;
            this.grdHistorico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdHistorico_CellClick);
            // 
            // tabMedicamento
            // 
            this.tabMedicamento.Controls.Add(this.txtMedicamento);
            this.tabMedicamento.Controls.Add(this.grdMedicamento);
            this.tabMedicamento.Location = new System.Drawing.Point(4, 22);
            this.tabMedicamento.Name = "tabMedicamento";
            this.tabMedicamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedicamento.Size = new System.Drawing.Size(350, 336);
            this.tabMedicamento.TabIndex = 1;
            this.tabMedicamento.Text = "Medicamentos";
            this.tabMedicamento.UseVisualStyleBackColor = true;
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(3, 201);
            this.txtMedicamento.MaxLength = 100;
            this.txtMedicamento.Multiline = true;
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.ReadOnly = true;
            this.txtMedicamento.Size = new System.Drawing.Size(344, 129);
            this.txtMedicamento.TabIndex = 49;
            // 
            // grdMedicamento
            // 
            this.grdMedicamento.AllowUserToAddRows = false;
            this.grdMedicamento.AllowUserToDeleteRows = false;
            this.grdMedicamento.AllowUserToResizeColumns = false;
            this.grdMedicamento.AllowUserToResizeRows = false;
            this.grdMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMedicamento.Location = new System.Drawing.Point(3, 3);
            this.grdMedicamento.MultiSelect = false;
            this.grdMedicamento.Name = "grdMedicamento";
            this.grdMedicamento.ReadOnly = true;
            this.grdMedicamento.RowHeadersVisible = false;
            this.grdMedicamento.RowHeadersWidth = 62;
            this.grdMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMedicamento.Size = new System.Drawing.Size(344, 192);
            this.grdMedicamento.TabIndex = 2;
            this.grdMedicamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMedicamento_CellClick);
            // 
            // tabVacina
            // 
            this.tabVacina.Controls.Add(this.txtVacina);
            this.tabVacina.Controls.Add(this.grdVacina);
            this.tabVacina.Location = new System.Drawing.Point(4, 22);
            this.tabVacina.Name = "tabVacina";
            this.tabVacina.Size = new System.Drawing.Size(350, 336);
            this.tabVacina.TabIndex = 2;
            this.tabVacina.Text = "Vacinas";
            this.tabVacina.UseVisualStyleBackColor = true;
            // 
            // txtVacina
            // 
            this.txtVacina.Location = new System.Drawing.Point(3, 201);
            this.txtVacina.MaxLength = 100;
            this.txtVacina.Multiline = true;
            this.txtVacina.Name = "txtVacina";
            this.txtVacina.ReadOnly = true;
            this.txtVacina.Size = new System.Drawing.Size(344, 129);
            this.txtVacina.TabIndex = 49;
            // 
            // grdVacina
            // 
            this.grdVacina.AllowUserToAddRows = false;
            this.grdVacina.AllowUserToDeleteRows = false;
            this.grdVacina.AllowUserToResizeColumns = false;
            this.grdVacina.AllowUserToResizeRows = false;
            this.grdVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVacina.Location = new System.Drawing.Point(3, 3);
            this.grdVacina.MultiSelect = false;
            this.grdVacina.Name = "grdVacina";
            this.grdVacina.ReadOnly = true;
            this.grdVacina.RowHeadersVisible = false;
            this.grdVacina.RowHeadersWidth = 62;
            this.grdVacina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVacina.Size = new System.Drawing.Size(344, 192);
            this.grdVacina.TabIndex = 2;
            this.grdVacina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVacina_CellClick);
            // 
            // tabVermifugo
            // 
            this.tabVermifugo.Controls.Add(this.txtVermifugo);
            this.tabVermifugo.Controls.Add(this.grdVermifugo);
            this.tabVermifugo.Location = new System.Drawing.Point(4, 22);
            this.tabVermifugo.Name = "tabVermifugo";
            this.tabVermifugo.Size = new System.Drawing.Size(350, 336);
            this.tabVermifugo.TabIndex = 3;
            this.tabVermifugo.Text = "Vermífugos";
            this.tabVermifugo.UseVisualStyleBackColor = true;
            // 
            // txtVermifugo
            // 
            this.txtVermifugo.Location = new System.Drawing.Point(3, 201);
            this.txtVermifugo.MaxLength = 100;
            this.txtVermifugo.Multiline = true;
            this.txtVermifugo.Name = "txtVermifugo";
            this.txtVermifugo.ReadOnly = true;
            this.txtVermifugo.Size = new System.Drawing.Size(344, 129);
            this.txtVermifugo.TabIndex = 48;
            // 
            // grdVermifugo
            // 
            this.grdVermifugo.AllowUserToAddRows = false;
            this.grdVermifugo.AllowUserToDeleteRows = false;
            this.grdVermifugo.AllowUserToResizeColumns = false;
            this.grdVermifugo.AllowUserToResizeRows = false;
            this.grdVermifugo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVermifugo.Location = new System.Drawing.Point(3, 3);
            this.grdVermifugo.MultiSelect = false;
            this.grdVermifugo.Name = "grdVermifugo";
            this.grdVermifugo.ReadOnly = true;
            this.grdVermifugo.RowHeadersVisible = false;
            this.grdVermifugo.RowHeadersWidth = 62;
            this.grdVermifugo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVermifugo.Size = new System.Drawing.Size(344, 192);
            this.grdVermifugo.TabIndex = 2;
            this.grdVermifugo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVermifugo_CellClick);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Image = global::PetShop.Properties.Resources.Dog;
            this.btnVisualizar.Location = new System.Drawing.Point(348, 539);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(115, 41);
            this.btnVisualizar.TabIndex = 6;
            this.btnVisualizar.Text = "&Visualizar Animais";
            this.btnVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::PetShop.Properties.Resources.FloppyDisks;
            this.btnGravar.Location = new System.Drawing.Point(6, 539);
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
            this.btnLimpar.Location = new System.Drawing.Point(120, 539);
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
            this.btnCancelar.Location = new System.Drawing.Point(234, 539);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 41);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 586);
            this.Controls.Add(this.grpAtendimentos);
            this.Controls.Add(this.grpAnimais);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.grpPesquisa);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProprietario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetShop - Cadastro de Proprietários";
            this.Load += new System.EventHandler(this.frmProprietario_Load);
            this.grpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.grpTelefone.ResumeLayout(false);
            this.grpTelefone.PerformLayout();
            this.grpAnimais.ResumeLayout(false);
            this.grpAnimais.PerformLayout();
            this.grpAtendimentos.ResumeLayout(false);
            this.tabAtendimentos.ResumeLayout(false);
            this.tabHistorico.ResumeLayout(false);
            this.tabHistorico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorico)).EndInit();
            this.tabMedicamento.ResumeLayout(false);
            this.tabMedicamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicamento)).EndInit();
            this.tabVacina.ResumeLayout(false);
            this.tabVacina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVacina)).EndInit();
            this.tabVermifugo.ResumeLayout(false);
            this.tabVermifugo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVermifugo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.GroupBox grpAnimais;
        private System.Windows.Forms.ComboBox cboAnimais;
        private System.Windows.Forms.Label lblNomeAnimal;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.GroupBox grpAtendimentos;
        private System.Windows.Forms.TabControl tabAtendimentos;
        private System.Windows.Forms.TabPage tabHistorico;
        private System.Windows.Forms.TabPage tabMedicamento;
        private System.Windows.Forms.TabPage tabVacina;
        private System.Windows.Forms.TabPage tabVermifugo;
        private System.Windows.Forms.DataGridView grdHistorico;
        private System.Windows.Forms.DataGridView grdMedicamento;
        private System.Windows.Forms.DataGridView grdVacina;
        private System.Windows.Forms.DataGridView grdVermifugo;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.TextBox txtVacina;
        private System.Windows.Forms.TextBox txtVermifugo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cboTipoTelefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpTelefone;
        private System.Windows.Forms.ListBox lstTelefone;
    }
}