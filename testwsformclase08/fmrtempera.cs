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
    public partial class fmrtempera : Form
    {
       
        private tempera mitempera;

        public tempera proptempera
        {
            get { return mitempera; }
           
        }


        public fmrtempera()
        {
           

            InitializeComponent();

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBox1.Items.Add(color);
            }


            this.comboBox1.SelectedItem = ConsoleColor.Blue;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = this.comboBox1.SelectedIndex;
           string seleccolor = this.comboBox1.Items[indice].ToString();
          ConsoleColor  color = (ConsoleColor)this.comboBox1.SelectedItem;

            string marca = this.textBox1.Text;
           sbyte cant = System.Convert.ToSByte (this.textBox2.Text);
            this.mitempera = new tempera(color, cant, marca);
            MessageBox.Show(seleccolor + marca + cant);
            this.DialogResult = DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
