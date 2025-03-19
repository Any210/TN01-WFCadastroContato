using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUsandoListagem
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                Erro("O login não podem ser vazio!");
                return;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                Erro("As Senhas não podem ser vazias!");
                return;
            }

            if (txtSenha.Text != txtCSenha.Text)
            {
                Erro("As Senhas devem ser iguais!");
                return;
            }

            Usuario novoUs = new Usuario();
            novoUs.Codigo = Usuario.ListaUsuarios.Count + 1;
            novoUs.Login = txtLogin.Text;
            novoUs.Senha = txtSenha.Text;
            novoUs.DataCadastro = DateTime.Now;

            Usuario.ListaUsuarios.Add(novoUs);

            Close();

            FormListagem form = new FormListagem();
            form.ShowDialog();

        }
    }
}