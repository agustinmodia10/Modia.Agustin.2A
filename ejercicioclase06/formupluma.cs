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
    public partial class formupluma : Form
    {
        ttinta objtinta = new ttinta();


        


        ttinta h = new ttinta();

        public static etipotinta tintah;
        public static ConsoleColor colorh;

        string selectinta;
        string selecmarca;
        int seleccant;

        int indicetinta;
        int indice;

        public static ArrayList altinta = new ArrayList();
        public static ArrayList almarca = new ArrayList();
        public static ArrayList alcant = new ArrayList();

        clasee05.tinta objt;

        List<clasee05.pluma> listobjplumas = new List<clasee05.pluma>();

        static int indiceh;
        ConsoleColor[] listobjcolor;
        etipotinta[] listobjtinta;

        public formupluma()
        {



            
            InitializeComponent();

            indiceh = formutinta.indiceaft; ;

            listobjcolor = new ConsoleColor[indiceh];
            listobjtinta = new etipotinta[indiceh];

            String[] alist = new string[indiceh];
           
           
           formutinta.hcolor.CopyTo(listobjcolor);

           

            formutinta.htinta.CopyTo(listobjtinta);

            formutinta.h.CopyTo(alist);



            for (int i = 0; i< indiceh; i++)
            {
                ttinta objtinta = new ttinta(listobjcolor[i], listobjtinta[i]);
               
               this.cmbtintas.Items.Add(ttinta.Mostrar(objtinta));

            }
                

            
           
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            
            indice = cmbtintas.SelectedIndex;

            selectinta =cmbtintas.Items[indice].ToString();

            objt = new clasee05.tinta(listobjcolor[indice], listobjtinta[indice]);


               





        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            altinta.Add(selectinta);

            indicetinta = altinta.Count;
            label1.Text = selectinta;

            almarca.Add(selecmarca);
            label2.Text = selecmarca;

            alcant.Add(seleccant);
            label3.Text = seleccant.ToString();


            clasee05.pluma objpluma = new clasee05.pluma(seleccant, selecmarca, objt);

            MessageBox.Show(objpluma);


            listobjplumas.Add(objpluma);
            textBox2.Text = "--------------------";


            int indicelistobjpluma;

            indicelistobjpluma = listobjplumas.Count;

            textBox2.AppendText(Environment.NewLine);

        
            for ( int i = 0; i < indicelistobjpluma; i++)
            {
                textBox2.Text = "   \n" + textBox2.Text + objpluma + " \n     ||    ";

            }

            //foreach (clasee05.pluma pluma in listobjplumas)
            //{


            //    textBox2.Text = "   \n" + textBox2.Text + objpluma + " \n     ||    ";

            //}



        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbmarca_TextChanged(object sender, EventArgs e)
        {
            selecmarca = cmbmarca.Text;

            

        }

        private void formupluma_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void selecnumero_ValueChanged(object sender, EventArgs e)
        {
            seleccant = (int) selecnumero.Value;
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
