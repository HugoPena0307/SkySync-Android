using System.Data;

namespace SkySync
{
    public partial class Form1 : Form
    {
        ClasseConexao con = new ClasseConexao();
        DataTable dt = new DataTable();
        public Form1()
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
                Form2 frm2 = new Form2();
                frm2.Show();
            }

        }
    }
}
