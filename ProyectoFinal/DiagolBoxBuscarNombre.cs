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
    public partial class DiagolBoxBuscarNombre : Form
    {
        public DiagolBoxBuscarNombre()
        {
            InitializeComponent();
        }
        public string nombreproducto
        {
            get { return (textBox1.Text); }
        }
        private void DiagolBoxBuscarNombre_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
