using System;
using System.Collections;
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
   
    public partial class formutinta : Form
    {
        public static string asignotinta;
        public static string selectinta;
        public static string seleccolor;
       public static etipotinta tintah;
       public static ConsoleColor colorh;

       public static ArrayList h = new ArrayList();
        List<ttinta> hlist = new List<ttinta>();
        public static ArrayList hcolor = new ArrayList();
        public static ArrayList htinta = new ArrayList();

        public static int indiceaft;


        public formutinta( )
        {
              

        InitializeComponent();
             
            
            


            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cmbcolor.Items.Add(color);
            }


            this.cmbcolor.SelectedItem = ConsoleColor.Blue;
            this.cmbcolor.DropDownStyle = ComboBoxStyle.DropDownList;

            
         

            foreach (etipotinta tipo in Enum.GetValues(typeof(etipotinta)))
                this.cmbtinta.Items.Add(tipo);
            this.cmbtinta.SelectedItem = etipotinta.conBrillito;
            this.cmbtinta.DropDownStyle = ComboBoxStyle.DropDownList;

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) /*BOTON AGREGAR*/
        {

            //asignotinta = seleccolor + " " + selectinta;

            //label3.Text = asignotinta;
           



        


         



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbcolor.SelectedIndex;

          

            seleccolor = cmbcolor.Items[indice].ToString();

            colorh= (ConsoleColor) Enum.Parse(typeof(ConsoleColor), seleccolor);
           

            



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbtinta.SelectedIndex;
            
            selectinta = cmbtinta.Items[indice].ToString();

            tintah = (etipotinta)Enum.Parse(typeof(etipotinta), selectinta);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // BOTON CANCELAR
        {
            this.Close();
                
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            ttinta objtinta = new ttinta(colorh, tintah);

            label3.Text = ttinta.Mostrar(objtinta);


                hlist.Add(objtinta); // lista de objectos

                hcolor.Add(colorh);
                htinta.Add(tintah);

          

               h.Add(ttinta.Mostrar(objtinta)); // arraylist de string

             indiceaft = h.Count;




        }
    }
}
