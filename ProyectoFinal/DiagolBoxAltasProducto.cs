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
    public partial class DiagolBoxAltasProducto : Form
    {
        public DiagolBoxAltasProducto()
        {
            InitializeComponent();
        }
        public string fechaproducto
        {
            get { return (dateTimePicker1.Text); }
        }
        public string nombreproducto
        {
            get { return (textBox1.Text); }
        }
        public string cantidad
        {
            get { return (textBox2.Text); }
        }
        public string precio
        {
            get { return (textBox3.Text); }
        }
        public string total
        {
            get { return (textBox4.Text); }
        }
        private void DiagolBoxAltasProducto_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== 13)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox4.Focus();
                textBox4.Text = (int.Parse(textBox2.Text) * int.Parse(textBox3.Text)).ToString();

            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button3.Focus();
            }
        }
        private void button3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1.Focus();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (int.Parse(textBox4.Text) > int.Parse(textBox5.Text))
                {
                    MessageBox.Show("No se pudo completar el pago", "Tienda Doña Chachi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textBox6.Enabled = true;
                    textBox6.Text = (int.Parse(textBox5.Text) - int.Parse(textBox4.Text)).ToString();
                }
            }

            if (radioButton2.Checked == true)
            {
                this.textBox5.Text = textBox4.Text;
                textBox6.Text = "0";
            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
