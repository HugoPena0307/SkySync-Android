using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SkySync
{
    public partial class Cadastro : Form
    {
        ClasseConexao con; 
        DataTable dt = new DataTable();
        Compartilha cp = new Compartilha();
        int count = 0;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            String emailConsulta = cp.getemailConsulta();
            preencherDados(emailConsulta);
            lblCadastrar.Left = (this.ClientSize.Width - lblCadastrar.Width) / 2;
            cp.setemailConsulta("");

        }

        public void preencherDados(String emailConsulta)
        {
            con = new ClasseConexao();
            if (emailConsulta != "")
            {
                dt = con.consultarDados("select * from Cliente where Email ='" + emailConsulta + "'");

                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtNome.Text = dt.Rows[0]["Nome"].ToString();
                txtCPF.Text = dt.Rows[0]["Cpf"].ToString();
                txtFone.Text = dt.Rows[0]["Fone"].ToString();
                txtEndereco.Text = dt.Rows[0]["Endereco"].ToString();
                txtCEP.Text = dt.Rows[0]["Cep"].ToString();
                txtCidade.Text = dt.Rows[0]["Cidade"].ToString();

                lblCadastrar.Text = "Editar Cadastro Cliente";
                btnCadastrar.Text = "Atualizar";

                if(txtEmail.Text != "" )
                {
                    dt = con.consultarDados("select * from Cliente where Email ='" + emailConsulta + "'");
                    txtSenha.Enabled = true;
                    txtSenha.Text = dt.Rows[0]["Senha"].ToString();
                }
                else
                {
                    txtSenha.Enabled = false;
                    txtSenha.Text = dt.Rows[0]["Senha"].ToString();
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            dt = new DataTable();
            String email = txtEmail.Text;
            String nome = txtNome.Text;
            String CPF = txtCPF.Text;
            String fone = txtFone.Text;
            String endereco = txtEndereco.Text;
            String CEP = txtCEP.Text;
            String cidade = txtCidade.Text;
            String senha = txtSenha.Text;

            if (cp.getidConsulta() == "")
            {
                dt = con.consultarDados("insert into Cliente (Nome, Cpf, Email, Senha, Fone, Endereco, Cep, Cidade) values " +
               "('" + nome + "', '" + CPF + "', '" + email + "', '" + 1234 + "', '" + fone + "', '" + endereco + "', '" + CEP + "', '" + cidade + "')");

                MessageBox.Show("Dados da Conta\n\nLogin: " + email + "\nSenha: 1234", "Cadastro Realizado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Menu frmMenu = new Menu();
                this.Hide();
                frmMenu.ShowDialog();
            }
            else
            {
                dt = con.consultarDados("update Cliente set Nome = '" + nome + "', Cpf = '" + CPF + "', Email = '" + email + "', Senha= '" + senha + "', " +
                "Fone = '" + fone + "', Endereco = '" + endereco + "', Cep = '" + CEP + "', Cidade = '" + cidade + "' where idCli = " + cp.getidConsulta() + ";");

                MessageBox.Show("Dados da Conta\n\nLogin: " + email + "\nSenha: " + senha + "", "Atualização Realizada com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Menu frmMenu = new Menu();
                this.Hide();
                frmMenu.ShowDialog();
            }
            
            cp.setemailConsulta("");
            cp.setidConsulta("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.ShowDialog();
        }
    }
}
