using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArchivoSecuenciales obj = new ArchivoSecuenciales();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void altaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.AltasProducto();
        }

        private void generalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.ConsultaGeneral(listView1);
        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.ModificarProducto(listView1);
        }

        private void eliminarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.Bajas(listView1);
        }

        private void nombreDelProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.BuscarNombre(listView1);
        }

        private void ventaMasAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.VentaAlta(listView1);
        }

        private void mostrarVentasDeUnDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.MostrarFecha(listView1);
        }

        private void ventaMasBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.VentaBaja(listView1);
        }
    }
}
