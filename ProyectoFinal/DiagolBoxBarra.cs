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
    public partial class DiagolBoxBarra : Form
    {
        public DiagolBoxBarra()
        {
            InitializeComponent();
        }
        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            label1.Text = "Cargando... Guardando Datos en el archivo" + progressBar1.Value + "%";
            if (x <= 100)
            {
                progressBar1.Value = x;
                x++;
                if(x == 100)
                {
                    MessageBox.Show("Datos del producto guardados en el archivo", "Archivos Secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer1.Enabled = false;
                    this.Close();
                }
            }
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            DiagolBoxBarra pBar = new DiagolBoxBarra();
        }

        private void DiagolBoxBarra_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
