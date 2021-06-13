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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void enviarDatos()
        {
            Form1 form = Owner as Form1;
            form.Guatemal = guate;
            form.Jalap = jala;
            form.Progres = progre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void selCsucursal(string nombreSucursal, pizzas pizza)
        {
            if(nombreSucursal == guate.nombre)
            {
                guate.agregarpizzas(pizza);
            }
            else if (nombreSucursal == jala.nombre)
            {
                jala.agregarpizzas(pizza);
            }
            else if (nombreSucursal == progre.nombre)
            {
                progre.agregarpizzas(pizza);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            pizzas pizza= new pizzas(txtnombre.Text, txtprecio.Text, txtdescipcion.Text);
            selCsucursal(ComboSucursales.Text, pizza);

            enviarDatos();

            //Nuevo renglon 
            int n = dataGridView1Pizza.Rows.Add();
            //informacion
            dataGridView1Pizza.Rows[n].Cells[0].Value = txtnombre.Text;
            dataGridView1Pizza.Rows[n].Cells[1].Value = txtdescipcion.Text;
            dataGridView1Pizza.Rows[n].Cells[2].Value = txtprecio.Text;
            //limpiar 
            txtnombre.Text = "";
            txtdescipcion.Text = "";
            txtprecio.Text = "";
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            recibirdatos();
        }

        private void Sucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            recibirdatos();
            ComboSucursales.Items.Add(guate.nombre);
            ComboSucursales.Items.Add(jala.nombre);
            ComboSucursales.Items.Add(progre.nombre);



        }
    }
}
