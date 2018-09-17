using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ejercicioclase06
{
    public partial class btnsalir : Form
    {
        private clasee05.pluma plumas;
        private clasee05.tinta tintas;
      
        
        public btnsalir( )
        {
            InitializeComponent();
        }

        private void tINTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formutinta formuti = new formutinta( );
            formuti.Show();
        }

        private void pLUMAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            formupluma formuplu = new formupluma();
            formuplu.Show();

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
