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
    public partial class DiagolBoxEliminarProductos : Form
    {
        public DiagolBoxEliminarProductos()
        {
            InitializeComponent();
        }
        public string fechaproducto
        {
            get { return (dateTimePicker1.Text); }
        }
        private void DiagolBoxEliminarProductos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
