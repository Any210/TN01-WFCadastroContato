using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string TipoTelefone;

            if (rdbPessoal.Checked)
            {
                TipoTelefone = "Pessoal";
            }
            else if (rdbComercial.Checked)
            {
                TipoTelefone = "Comercial";
            }
            else if (rdbRecado.Checked)
            {
                TipoTelefone = "Recado";
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

            MessageBox.Show("Cadastro realizado com sucesso!", "Info1", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparFormulario();
        }
    }
}
