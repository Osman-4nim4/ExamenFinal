using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        sucursales guate;
        sucursales jala;
        sucursales progre;

        private void recibirdatos()
        {
            Form1 form = Owner as Form1;
            guate = form.Guatemal;
            jala = form.Jalap;
            progre = form.Progres;

        }
        private void enviardatos()
        {
            Form1 form = Owner as Form1;
            form.Guatemal = guate;
            form.Jalap = jala;
            form.Progres = progre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboqueso.Items.Clear();
            if(Sucursalcombo.Text== guate.nombre)
            {
                foreach(pizzas pizza in guate.Listpizza)
                {
                    comboqueso.Items.Add(pizza.nombre);

                }
            }


            else if(Sucursalcombo.Text== jala.nombre)
                {
                    foreach(pizzas pizza in jala.Listpizza)
                    {
                        comboqueso.Items.Add(pizza.nombre);
                    }
                }
            else if (Sucursalcombo.Text == progre.nombre)
            {
                foreach(pizzas pizza in progre.Listpizza)
                {
                    comboqueso.Items.Add(pizza.nombre);
                }
            }
            }



        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            recibirdatos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

