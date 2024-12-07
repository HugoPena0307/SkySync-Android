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

namespace SkySync
{
    public partial class Menu : Form
    {
        ClasseConexao con = new ClasseConexao();
        DataTable dt = new DataTable();
        Compartilha cp = new Compartilha();
        public Menu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String email = cp.getEmail();
            lblBemVindo.Text = "Bem-vindo '" + email + "'";

            lblBemVindo.Left = (this.ClientSize.Width - lblBemVindo.Width) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login frm1 = new Login();
            this.Close();
            frm1.ShowDialog();
        }

        private void picAgendamento_Click(object sender, EventArgs e)
        {
            Agendamentos frmAgenda = new Agendamentos();
            this.Hide();
            frmAgenda.ShowDialog();
        }

        private void picCadastro_Click(object sender, EventArgs e)
        {
            //bug
        }

        private void picConsulta_Click(object sender, EventArgs e)
        {
            Consulta frmConsulta = new Consulta();
            this.Hide();
            frmConsulta.ShowDialog();
        }

        private void picVeiculos_Click(object sender, EventArgs e)
        {
            Veiculos frmVeiculos = new Veiculos();
            this.Hide();
            frmVeiculos.ShowDialog();
        }

        private void picCadastro_Click_1(object sender, EventArgs e)
        {
            Cadastro frmCadastro = new Cadastro();
            this.Hide();
            frmCadastro.ShowDialog();
        }
    }
}
