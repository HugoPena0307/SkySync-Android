using System.Data;

namespace SkySync
{
    public partial class Login : Form
    {
        ClasseConexao con = new ClasseConexao();
        DataTable dt = new DataTable();
        Compartilha cp = new Compartilha();
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            String senha = txtSenha.Text;
            dt = con.consultarDados("Select * from Id_LoginMecanica where Email='" + email + "' and Senha='" + senha + "'");

            if (dt.Rows[0]["Email"].ToString() == email && dt.Rows[0]["Senha"].ToString() == senha)
            {
                cp.setEmail(email);
                this.Hide();
                Menu frm2 = new Menu();
                frm2.Show();
            }

        }
    }
}
