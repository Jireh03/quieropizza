using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quieropizza.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ProductosBL = new ProductosBL();
            var listaProductos = ProductosBL.ObtenerProductos();
            foreach (var Productos in listadeProductos)
        }
        MessageBox.Show(Producto.Descripcion )
    }
}
