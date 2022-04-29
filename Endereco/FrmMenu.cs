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

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        }

        private void tipoDeLogradouroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logradouroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cEPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void onibusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuSair_Click(object sender, EventArgs e)
        {

        }
    }
}
