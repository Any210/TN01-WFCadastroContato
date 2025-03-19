namespace WFCadastroProduto
{
    partial class FormCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            lblCodigo = new Label();
            lblCategorias = new Label();
            lblNomeP = new Label();
            lblPreco = new Label();
            lblDataVencimento = new Label();
            lblObservacao = new Label();
            txtNomeP = new TextBox();
            txtCodigo = new TextBox();
            txtObservacao = new TextBox();
            cbxCategorias = new ComboBox();
            dtpDataVencimento = new DateTimePicker();
            nudPreco = new NumericUpDown();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(22, 20);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(203, 20);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(63, 15);
            lblCategorias.TabIndex = 1;
            lblCategorias.Text = "Categorias";
            // 
            // lblNomeP
            // 
            lblNomeP.AutoSize = true;
            lblNomeP.Location = new Point(22, 89);
            lblNomeP.Name = "lblNomeP";
            lblNomeP.Size = new Size(103, 15);
            lblNomeP.TabIndex = 2;
            lblNomeP.Text = "Nome do Produto";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(22, 163);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 3;
            lblPreco.Text = "Preço";
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Location = new Point(151, 163);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(114, 15);
            lblDataVencimento.TabIndex = 4;
            lblDataVencimento.Text = "Data De Vencimento";
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(22, 233);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(69, 15);
            lblObservacao.TabIndex = 5;
            lblObservacao.Text = "Observação";
            // 
            // txtNomeP
            // 
            txtNomeP.Location = new Point(22, 118);
            txtNomeP.Name = "txtNomeP";
            txtNomeP.Size = new Size(363, 23);
            txtNomeP.TabIndex = 6;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(22, 50);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(154, 23);
            txtCodigo.TabIndex = 8;
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(22, 262);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(363, 112);
            txtObservacao.TabIndex = 9;
            // 
            // cbxCategorias
            // 
            cbxCategorias.FormattingEnabled = true;
            cbxCategorias.Location = new Point(203, 50);
            cbxCategorias.Name = "cbxCategorias";
            cbxCategorias.Size = new Size(182, 23);
            cbxCategorias.TabIndex = 11;
            // 
            // dtpDataVencimento
            // 
            dtpDataVencimento.Location = new Point(151, 190);
            dtpDataVencimento.Name = "dtpDataVencimento";
            dtpDataVencimento.Size = new Size(234, 23);
            dtpDataVencimento.TabIndex = 12;
            // 
            // nudPreco
            // 
            nudPreco.Location = new Point(22, 190);
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(113, 23);
            nudPreco.TabIndex = 13;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(310, 390);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 32);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 450);
            Controls.Add(btnSalvar);
            Controls.Add(nudPreco);
            Controls.Add(dtpDataVencimento);
            Controls.Add(cbxCategorias);
            Controls.Add(txtObservacao);
            Controls.Add(txtCodigo);
            Controls.Add(txtNomeP);
            Controls.Add(lblObservacao);
            Controls.Add(lblDataVencimento);
            Controls.Add(lblPreco);
            Controls.Add(lblNomeP);
            Controls.Add(lblCategorias);
            Controls.Add(lblCodigo);
            Name = "FormCadastroProduto";
            Text = "FormCadastroProduto";
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblCategorias;
        private Label lblNomeP;
        private Label lblPreco;
        private Label lblDataVencimento;
        private Label lblObservacao;
        private TextBox txtNomeP;
        private TextBox txtCodigo;
        private TextBox txtObservacao;
        private ComboBox cbxCategorias;
        private DateTimePicker dtpDataVencimento;
        private NumericUpDown nudPreco;
        private Button btnSalvar;
    }
}