using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class sucursales
    {
        public string nombre;
        public List<pizzas> Listpizza = new List<pizzas>();


        public sucursales(string nombre)
        {
            this.nombre = nombre;

        }
        public void agregarpizzas(pizzas pizza)
        {
            Listpizza.Add(pizza);
        }

        
    }
}
