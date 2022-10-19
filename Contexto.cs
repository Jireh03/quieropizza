using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
   public class Contexto: Context
    {
        public Contexto(): base("QuieropizzaDB")
        {
                
        }
        public Dbset<Producto> Productos { get; set; }
    }
}
