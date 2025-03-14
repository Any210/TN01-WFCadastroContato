namespace TN01_WFCadastroContato
{
    partial class FormCadastroContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroContato));
            lblNome = new Label();
            lblSobrenome = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            txtNome = new TextBox();
            txtSobrenome = new TextBox();
            txtEmail = new TextBox();
            mkdTelefone = new MaskedTextBox();
            label6 = new Label();
            label5 = new Label();
            gbxTipoTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            btnVoltar = new Button();
            btnSalvar = new Button();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(13, 11);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(219, 13);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(71, 15);
            lblSobrenome.TabIndex = 1;
            lblSobrenome.Text = "Sobrenome:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(14, 100);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(83, 15);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "DDD/Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(18, 201);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "E-mail:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(14, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(164, 23);
            txtNome.TabIndex = 4;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(219, 31);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(172, 23);
            txtSobrenome.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(14, 230);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(377, 23);
            txtEmail.TabIndex = 6;
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(12, 126);
            mkdTelefone.Mask = "(99) 00000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(100, 23);
            mkdTelefone.TabIndex = 7;
            mkdTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(13, 77);
            label6.Name = "label6";
            label6.Size = new Size(378, 1);
            label6.TabIndex = 9;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(13, 185);
            label5.Name = "label5";
            label5.Size = new Size(378, 1);
            label5.TabIndex = 10;
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Location = new Point(146, 100);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(246, 66);
            gbxTipoTelefone.TabIndex = 11;
            gbxTipoTelefone.TabStop = false;
            gbxTipoTelefone.Text = "Tipo de Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(170, 30);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(85, 30);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(15, 30);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(235, 286);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 37);
            btnVoltar.TabIndex = 12;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextAlign = ContentAlignment.MiddleRight;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(321, 286);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(71, 37);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastroContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 450);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(mkdTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtSobrenome);
            Controls.Add(txtNome);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblSobrenome);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroContato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Contato";
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblSobrenome;
        private Label lblTelefone;
        private Label lblEmail;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private TextBox txtEmail;
        private MaskedTextBox mkdTelefone;
        private Label label6;
        private Label label5;
        private GroupBox gbxTipoTelefone;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
        private RadioButton rdbRecado;
        private Button btnVoltar;
        private Button btnSalvar;
    }
}