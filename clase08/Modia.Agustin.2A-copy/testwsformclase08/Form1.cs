using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entindades._07;


namespace testwsformclase08
{
    public partial class Form1 : Form
    {

        paletas mipaleta;
        public Form1()
        {
         mipaleta = 5;      

            
            InitializeComponent();

            this.groupBox1.Text = "paleta de colores";
            this.textBox1.Multiline = true;
            this.button1.Text = "+";
            this.button2.Text = "-";
            this.groupBox1.Visible = true;
            this.agregarPaletaToolStripMenuItem.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmrtempera tempera = new fmrtempera();
              DialogResult resultado = tempera.ShowDialog();
            tempera.Show();
         
            if (resultado == DialogResult.OK)
            {
                this.mipaleta += tempera.proptempera;
         
                this.textBox1.Text = tempera.proptempera;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
