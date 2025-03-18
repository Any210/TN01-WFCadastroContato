namespace WFUsandoListagem
{
    partial class FormCadastro
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
            btnCadastrar = new Button();
            lblLogin = new Label();
            lblSenha = new Label();
            lblCSenha = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            txtCSenha = new TextBox();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(40, 232);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(28, 25);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(28, 90);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // lblCSenha
            // 
            lblCSenha.AutoSize = true;
            lblCSenha.Location = new Point(28, 157);
            lblCSenha.Name = "lblCSenha";
            lblCSenha.Size = new Size(96, 15);
            lblCSenha.TabIndex = 3;
            lblCSenha.Text = "Confirmar Senha";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(28, 53);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(28, 119);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 5;
            // 
            // txtCSenha
            // 
            txtCSenha.Location = new Point(28, 186);
            txtCSenha.Name = "txtCSenha";
            txtCSenha.Size = new Size(100, 23);
            txtCSenha.TabIndex = 6;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(164, 284);
            Controls.Add(txtCSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblCSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(btnCadastrar);
            Name = "FormCadastro";
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Label lblLogin;
        private Label lblSenha;
        private Label lblCSenha;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private TextBox txtCSenha;
    }
}