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

namespace TN01_WFCadastroContato
{
    public partial class FormCadastroContato : Form
    {
        public FormCadastroContato()
        {
            InitializeComponent();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            mkdTelefone.Clear();
            rdbPessoal.Checked = false;
            rdbComercial.Checked = false;
            rdbRecado.Checked = false;
            txtEmail.Clear();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;

            if (Nome == "")
            {
                MessageBox.Show("Informe o seu nome!!");
                return;
            }
            else
            {
                Nome = txtNome.Text;
            }
            string Sobrenome = txtSobrenome.Text;

            if (Sobrenome == "")
            {
                MessageBox.Show("Informe o seu sobrenome!!");
                return;
            }
            else
            {
                Sobrenome = txtSobrenome.Text;
            }
            string DddTelefone = mkdTelefone.Text;

            if (DddTelefone == "")
            {
                MessageBox.Show("Informe o seu telefone!!");
                return;
            }
            else
            {
                Nome = txtNome.Text;
            }
            ETipoTelefone tipoTelefone;

            if (rdbPessoal.Checked)
            {
                tipoTelefone = ETipoTelefone.Pessoal;
            }
            else if (rdbComercial.Checked)
            {
                tipoTelefone = ETipoTelefone.Comercial;
            }
            else if (rdbRecado.Checked)
            {
                tipoTelefone = ETipoTelefone.Recado;
            }
            else
            {
                MessageBox.Show("Informe o Tipo de telefone!!");
                return;

            }
            string Email = txtEmail.Text;

            if (Email == "")
            {
                MessageBox.Show("Informe o seu E-mail!!");
                return;
            }
            else
            {
                Email = txtEmail.Text;

            }

            Contato c1 = new Contato();
            c1.Nome = txtNome.Text;
            c1.Sobrenome = txtSobrenome.Text;
            c1.Email = txtEmail.Text;
            c1.Codigo = 0;
            c1.TipoTelefone = tipoTelefone;
            c1.Ddd = mkdTelefone.Text.Substring(0, 2);
            c1.Telefone = mkdTelefone.Text.Substring(2);

            Contato.ListaContatos.Add(c1);



            string mensagem = "Cadastro realizado com sucesso!" + "\n" + "Nome:" + Nome + "\n" +
                "Sobrenome: " + Sobrenome + "\n" +
                "Telefone: " + DddTelefone + "\n" +
                "Tipo de Telefone: " + tipoTelefone + "\n" +
                "Email: " + Email + "\n";
            MessageBox.Show(mensagem, "Cadastro Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparFormulario();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
