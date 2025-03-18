using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WFUsandoListagem
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string Login = txtLogin.Text;

            if (Login == "")
            {
                MessageBox.Show("Informe o seu login!!");
                return;
            }
            else
            {
                Login = txtLogin.Text;
            }
            string Senha = txtCSenha.Text;

            if (Senha == "")
            {
                MessageBox.Show("Informe a sua senha!!");
                return;
            }
            else
            {
                Senha = txtCSenha.Text;
            }
            string ConfirmarSenha = txtCSenha.Text;

            if (ConfirmarSenha != Senha)
            {
                MessageBox.Show("Senha não compativel!!");
                return;
            }
            else
            {
                ConfirmarSenha = txtCSenha.Text;
            }

            
            MessageBox.Show( "Cadastro Concluido!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
