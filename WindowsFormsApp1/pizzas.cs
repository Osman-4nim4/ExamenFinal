using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class pizzas
    {
        public string nombre;
        public string precios;
        public string descripcion;


        public pizzas(string nombre, string precio, string descripcion)
        {
            this.nombre = nombre;
            this.precios = precio;
            this.descripcion = descripcion;
        }
    }

}
