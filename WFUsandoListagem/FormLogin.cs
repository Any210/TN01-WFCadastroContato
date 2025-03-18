namespace WFUsandoListagem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            CarregarLista();
        }

        private void CarregarLista()
        {
            Usuario.ListaUsuarios.Add(new Usuario { Codigo = 1000, Login = "user", Senha = "123456", DataCadastro = new DateTime(2024, 01, 10) });
            

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Usuario.ListaUsuarios)
            {
                if (usuario.Login == txtLogin.Text && usuario.Senha == txtSenha.Text)
                {
                    FormMain form = new FormMain();
                    form.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Usuário ou Senha Incorretos!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
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
                btnAcessar_Click(sender, e);

            }
        }
    }
}
