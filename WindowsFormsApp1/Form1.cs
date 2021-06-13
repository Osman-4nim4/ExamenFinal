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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sucursales guate = new sucursales("Guatemala");
        sucursales jala = new sucursales("Jalapa");
        sucursales progre = new sucursales("Progreso");
        private sucursales guatemal;
        private sucursales jalap;
        private sucursales progres;

        internal sucursales Guatemal { get => guatemal; set => guatemal = value; }
        internal sucursales Jalap { get => jalap; set => jalap = value; }
        internal sucursales Progres { get => progres; set => progres = value; }

        private void asignar()
        {
            guatemal = guate;
            jalap = jala;
            progres = progre;
        }


        private void button1Admin_Click(object sender, EventArgs e)
        {
            //botones para poder acceder a administracion
            Form2 frm = new Form2();
            AddOwnedForm(frm);
            frm.Show();
            
            
            
        }

        private void button2Orden_Click(object sender, EventArgs e)
        {
            //botones para poder acceder a orden
            Form3 frm = new Form3();
            AddOwnedForm(frm);
            frm.Show();
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            asignar();
        }
    }
}
