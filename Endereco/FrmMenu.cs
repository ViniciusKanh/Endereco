using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Endereco
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_Cidade form = new Cadastro.Cadastro_Cidade();
            form.Show();
        }

        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            pnlTopo.BackColor = Color.FromArgb(230, 230, 230);
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_Logradouro form = new Cadastro.Cadastro_Logradouro();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_Bairro form = new Cadastro.Cadastro_Bairro();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_TipoLogradouro form = new Cadastro.Cadastro_TipoLogradouro();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusSpot.Cadastro.Cadastro_Estado form = new BusSpot.Cadastro.Cadastro_Estado();
            form.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pnlTopo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuCadastro_Click(object sender, EventArgs e)
        {

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusSpot.Cadastro.Cadastro_Estado form = new BusSpot.Cadastro.Cadastro_Estado();
            form.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_Cidade form = new Cadastro.Cadastro_Cidade();
            form.Show();

        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_Bairro form = new Cadastro.Cadastro_Bairro();
            form.Show();
        }

        private void tipoDeLogradouroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_TipoLogradouro form = new Cadastro.Cadastro_TipoLogradouro();
            form.Show();
        }

        private void logradouroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_Logradouro form = new Cadastro.Cadastro_Logradouro();
            form.Show();
        }

        private void cEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_CEP form = new Cadastro.Cadastro_CEP();
            form.Show();
        }

          private void MenuSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cadastro.Cadastro_CEP form = new Cadastro.Cadastro_CEP();
            form.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
