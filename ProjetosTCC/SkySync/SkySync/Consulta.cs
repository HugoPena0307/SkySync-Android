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
    public partial class Consulta : Form
    {
        ClasseConexao con = new ClasseConexao();
        DataTable dt;
        Compartilha cp = new Compartilha();

        public Consulta()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            String email;
            String id;

            dt = con.consultarDados("select * from Cliente where Nome ='" + nome + "'");
            email = dt.Rows[0]["Email"].ToString();
            id = dt.Rows[0]["IdCli"].ToString();
            cp.setemailConsulta(email);
            cp.setidConsulta(id);

            Cadastro frmCadastro = new Cadastro();
            this.Hide();
            frmCadastro.ShowDialog();
        }
    }
}
