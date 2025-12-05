namespace PetShop
{
    partial class frmGenerico
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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.grpGenerico = new System.Windows.Forms.GroupBox();
            this.txtGenerico = new System.Windows.Forms.TextBox();
            this.lblGenerico = new System.Windows.Forms.Label();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.grpGenerico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            this.grpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(45, 18);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(79, 20);
            this.dtpData.TabIndex = 49;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(8, 21);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 50;
            this.lblData.Text = "Data";
            // 
            // grpGenerico
            // 
            this.grpGenerico.Controls.Add(this.txtGenerico);
            this.grpGenerico.Controls.Add(this.lblGenerico);
            this.grpGenerico.Controls.Add(this.nudPeso);
            this.grpGenerico.Controls.Add(this.lblPeso);
            this.grpGenerico.Controls.Add(this.lblData);
            this.grpGenerico.Controls.Add(this.dtpData);
            this.grpGenerico.Location = new System.Drawing.Point(7, 220);
            this.grpGenerico.Name = "grpGenerico";
            this.grpGenerico.Size = new System.Drawing.Size(430, 260);
            this.grpGenerico.TabIndex = 51;
            this.grpGenerico.TabStop = false;
            this.grpGenerico.Text = "Dados do Atendimento";
            // 
            // txtGenerico
            // 
            this.txtGenerico.Location = new System.Drawing.Point(4, 72);
            this.txtGenerico.MaxLength = 100;
            this.txtGenerico.Multiline = true;
            this.txtGenerico.Name = "txtGenerico";
            this.txtGenerico.Size = new System.Drawing.Size(421, 181);
            this.txtGenerico.TabIndex = 54;
            // 
            // lblGenerico
            // 
            this.lblGenerico.AutoSize = true;
            this.lblGenerico.Location = new System.Drawing.Point(8, 52);
            this.lblGenerico.Name = "lblGenerico";
            this.lblGenerico.Size = new System.Drawing.Size(50, 13);
            this.lblGenerico.TabIndex = 53;
            this.lblGenerico.Text = "Genérico";
            // 
            // nudPeso
            // 
            this.nudPeso.DecimalPlaces = 1;
            this.nudPeso.Location = new System.Drawing.Point(181, 19);
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(65, 20);
            this.nudPeso.TabIndex = 52;
            this.nudPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(145, 22);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 51;
            this.lblPeso.Text = "Peso";
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::PetShop.Properties.Resources.FloppyDisks;
            this.btnGravar.Location = new System.Drawing.Point(11, 486);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(115, 41);
            this.btnGravar.TabIndex = 52;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::PetShop.Properties.Resources.eraser;
            this.btnLimpar.Location = new System.Drawing.Point(166, 486);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 41);
            this.btnLimpar.TabIndex = 53;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::PetShop.Properties.Resources.exit;
            this.btnCancelar.Location = new System.Drawing.Point(320, 486);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 41);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.grdDados);
            this.grpLista.Location = new System.Drawing.Point(7, 12);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(430, 202);
            this.grpLista.TabIndex = 55;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Históricos Cadastrados";
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
            this.grdDados.Size = new System.Drawing.Size(419, 177);
            this.grdDados.TabIndex = 0;
            this.grdDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDados_CellClick);
            // 
            // frmGenerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 539);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpGenerico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenerico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "0";
            this.Text = "frmGenerico";
            this.Load += new System.EventHandler(this.frmGenerico_Load);
            this.grpGenerico.ResumeLayout(false);
            this.grpGenerico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            this.grpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox grpGenerico;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblGenerico;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.TextBox txtGenerico;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.DataGridView grdDados;
    }
}