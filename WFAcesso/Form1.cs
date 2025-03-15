namespace WFAcesso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarLista();
        }

        private void CarregarLista()
        {
            Usuario.ListaUsuarios.Add(new Usuario { Codigo = 001, Login = "admin", Senha = "admin", DataCadastro = new DateTime(2000, 01, 01) });
            Usuario.ListaUsuarios.Add(new Usuario { Codigo = 002, Login = "user", Senha = "user", DataCadastro = new DateTime(2010, 01, 01) });

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Usuario.ListaUsuarios)
            {
                if (usuario.Login == txtUsuario.Text && usuario.Senha == txtSenha.Text)
                {
                    MessageBox.Show("Login efetuado com sucesso!!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            MessageBox.Show("Usuário ou Senha Incorretos!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();

            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogar_Click(sender, e);

            }
        }
    }
}
