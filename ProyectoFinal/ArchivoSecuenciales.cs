


 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinal
{
    class ArchivoSecuenciales
    {
        public int FechaProducto;
        public string NombreProducto;
        public int Cantidad;
        public int Precio;
        public int Total;

        public int fechaproducto
        {
            set { value = FechaProducto; }
            get { return (FechaProducto); }
        }
        public string nombreproducto
        {
            set { value = NombreProducto; }
            get { return (NombreProducto); }
        }
        public int cantidad
        {
            set { value = Cantidad; }
            get { return (Cantidad); }
        }
        public int precio
        {
            set { value = Precio; }
            get { return (Precio); }
        }
        public int total
        {
            set { value = Total; }
            get { return (Total); }
        }

        public void AltasProducto()
        {
            DiagolBoxBarra fp = new DiagolBoxBarra();
            StreamWriter sw = new StreamWriter("..ArchivoProducto.txt", true, Encoding.ASCII);
            DiagolBoxAltasProducto altas = new DiagolBoxAltasProducto();
            if (altas.ShowDialog() == DialogResult.OK)
            {
                sw.WriteLine(altas.fechaproducto);
                sw.WriteLine(altas.nombreproducto);
                sw.WriteLine(altas.cantidad);
                sw.WriteLine(altas.precio);
                sw.WriteLine(altas.total);
                fp.Show();

            }
            sw.Close();
        }

        public void ConsultaGeneral(ListView caja)
        {
            StreamReader sr = new StreamReader("..ArchivoProducto.txt");
    
            string fechaproducto = sr.ReadLine();
            string nombreproducto = sr.ReadLine();
            string cantidad = sr.ReadLine();
            string precio = sr.ReadLine();
            string total = sr.ReadLine();
            while (cantidad != null)
            {
                ListViewItem datos = new ListViewItem(fechaproducto);
                datos.SubItems.Add(nombreproducto);
                datos.SubItems.Add(cantidad);
                datos.SubItems.Add(precio);
                datos.SubItems.Add(total);
                caja.Items.Add(datos);
                fechaproducto = sr.ReadLine();
                nombreproducto = sr.ReadLine();
                cantidad = sr.ReadLine();
                precio = sr.ReadLine();
                total=sr.ReadLine();
            }
            sr.Close();
        }

        public void ModificarProducto(ListView caja)
        {
            bool bandera = false;
            DiagolBoxModificarProducto bajas = new DiagolBoxModificarProducto();
            if (bajas.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader("..ArchivoProducto.txt");
                StreamWriter sw = new StreamWriter("..Auxiliar.txt", false, Encoding.ASCII);
                string fechaproducto = sr.ReadLine();
                string nombreproducto = sr.ReadLine();
                string cantidad = sr.ReadLine();
                string precio = sr.ReadLine();
                string total = sr.ReadLine();
                while (fechaproducto != null)
                {
                    if (fechaproducto != bajas.fechaproducto)
                    {
                        sw.WriteLine(fechaproducto);
                        sw.WriteLine(nombreproducto);
                        sw.WriteLine(cantidad);
                        sw.WriteLine(precio);
                        sw.WriteLine(total);

                    }
                    if (fechaproducto == bajas.fechaproducto)
                    {
                        bandera = true;
                        fechaproducto = sr.ReadLine();
                        nombreproducto = sr.ReadLine();
                        cantidad = sr.ReadLine();
                        precio = sr.ReadLine();
                        total = sr.ReadLine();
                        DiagolBoxAltasProducto modificar = new DiagolBoxAltasProducto();
                        if (modificar.ShowDialog() == DialogResult.OK)
                        {
                            sw.WriteLine(modificar.fechaproducto);
                            sw.WriteLine(modificar.nombreproducto);
                            sw.WriteLine(modificar.cantidad);
                            sw.WriteLine(modificar.precio);
                            sw.WriteLine(modificar.total);

                        }
                    }
                    sw.Close();
                    sr.Close();

                    StreamReader sr1 = new StreamReader("..Auxiliar.txt");
                    StreamWriter sw1 = new StreamWriter("..ArchivoProducto.txt", false, Encoding.ASCII);
                    fechaproducto = sr1.ReadLine();
                    nombreproducto = sr1.ReadLine();
                    cantidad = sr1.ReadLine();
                    precio = sr1.ReadLine();
                    total = sr1.ReadLine();
                    while (fechaproducto != null)
                    {
                        sw1.WriteLine(fechaproducto);
                        sw1.WriteLine(nombreproducto);
                        sw1.WriteLine(cantidad);
                        sw1.WriteLine(precio);
                        sw1.WriteLine(total);
                        fechaproducto = sr1.ReadLine();
                        nombreproducto = sr1.ReadLine();
                        cantidad = sr1.ReadLine();
                        precio = sr1.ReadLine();
                        total = sr1.ReadLine();

                    }
                    sr1.Close();
                    sw1.Close();
                }
                if (bandera == false)
                {
                    MessageBox.Show("El producto que deseas modificar no existe", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Los datos del producto se modificaron", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sr.Close();
            }
        }
        public void Bajas(ListView caja)
        {
            StreamReader sr = new StreamReader("..ArchivoProducto.txt");
            StreamWriter sw = new StreamWriter("..Auxiliar.txt", false, Encoding.ASCII);
            bool bl = false;
            DiagolBoxEliminarProductos baja = new DiagolBoxEliminarProductos();
            if (baja.ShowDialog() == DialogResult.OK)
            {

                string fechaproducto = sr.ReadLine();
                string nombreproducto = sr.ReadLine();
                string cantidad = sr.ReadLine();
                string precio = sr.ReadLine();
                string total = sr.ReadLine();
                while (fechaproducto != null)
                {
                    if (fechaproducto == baja.fechaproducto)
                    {
                        bl = true;
                    }
                    if (fechaproducto != baja.fechaproducto)

                    {
                        sw.WriteLine(fechaproducto);
                        sw.WriteLine(nombreproducto);
                        sw.WriteLine(cantidad);
                        sw.WriteLine(precio);
                        sw.WriteLine(total);
                    }
                    fechaproducto = sr.ReadLine();
                    nombreproducto = sr.ReadLine();
                    cantidad = sr.ReadLine();
                    precio = sr.ReadLine();
                    total = sr.ReadLine();

                }
                sw.Close();
                sr.Close();

                StreamReader sr1 = new StreamReader("..Auxiliar.txt");
                StreamWriter sw1 = new StreamWriter("..ArchivoProducto.txt", false, Encoding.ASCII);
                fechaproducto = sr1.ReadLine();
                nombreproducto = sr1.ReadLine();
                cantidad = sr1.ReadLine();
                precio = sr1.ReadLine();
                total = sr1.ReadLine();
                while (nombreproducto != null)
                {
                    sw1.WriteLine(fechaproducto);
                    sw1.WriteLine(nombreproducto);
                    sw1.WriteLine(cantidad);
                    sw1.WriteLine(precio);
                    sw1.WriteLine(total);
                    fechaproducto = sr1.ReadLine();
                    nombreproducto = sr1.ReadLine();
                    cantidad = sr1.ReadLine();
                    precio = sr1.ReadLine();
                    total = sr1.ReadLine();
                }
                sr1.Close();
                sw1.Close();
                if (bl == false)
                {
                    MessageBox.Show("El producto no existe en los datos del archivo", "Archivos secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Los datos del producto se eliminaron del archivo", "Archivos secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }
        public void BuscarNombre(ListView caja)
        {
            bool bl = false;
            StreamReader sr = new StreamReader("..ArchivoProducto.txt");
            DiagolBoxBuscarNombre buscar = new DiagolBoxBuscarNombre();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                string fechaproducto = sr.ReadLine();
                string nombreproducto = sr.ReadLine();
                string cantidad = sr.ReadLine();
                string precio = sr.ReadLine();
                string total = sr.ReadLine();
                while (fechaproducto != null)
                {

                    if (nombreproducto.ToLower() == buscar.nombreproducto.ToLower())
                    {
                        bl = true;
                        ListViewItem datos = new ListViewItem(fechaproducto);
                        datos.SubItems.Add(nombreproducto);
                        datos.SubItems.Add(cantidad);
                        datos.SubItems.Add(precio);
                        datos.SubItems.Add(total);
                        caja.Items.Add(datos);


                    }
                    fechaproducto = sr.ReadLine();
                    nombreproducto = sr.ReadLine();
                    cantidad = sr.ReadLine();
                    precio = sr.ReadLine();
                    total = sr.ReadLine();

                }
               
            }
            if (bl == false)
            {
                MessageBox.Show("No se encontro el nombre del producto", "Archivos secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            sr.Close();
        }


        public void VentaAlta(ListView caja)
        {
            double totalmayor = 0;
            string fechamayor = "";
            string nombremayor = "";
            string cantidadmayor = "";
            string preciomayor = "";
            StreamReader sr = new StreamReader("..ArchivoProducto.txt");
            string fechaproducto = sr.ReadLine();
            string nombreproducto = sr.ReadLine();
            string cantidad = sr.ReadLine();
            string precio = sr.ReadLine();
            string total = sr.ReadLine();
            while (fechaproducto != null)
            {
                if (totalmayor < double.Parse(total))
                {
                    fechamayor = fechaproducto;
                    nombremayor = nombreproducto;
                    cantidadmayor = cantidad;
                    preciomayor = precio;
                    totalmayor = double.Parse(total);
                }
                fechaproducto = sr.ReadLine();
                nombreproducto = sr.ReadLine();
                cantidad = sr.ReadLine();
                precio = sr.ReadLine();
                total = sr.ReadLine();
            }
           
            ListViewItem datos = new ListViewItem(fechamayor);
            datos.SubItems.Add(nombremayor);
            datos.SubItems.Add(cantidadmayor);
            datos.SubItems.Add(preciomayor);
            datos.SubItems.Add(totalmayor.ToString());
            caja.Items.Add(datos);


            sr.Close();
        }
        public void MostrarFecha(ListView caja)
        {
            double suma = 0;
            bool bl = false;
            StreamReader sr = new StreamReader("..ArchivoProducto.txt");
            DiagolBoxMostrarFecha buscar = new DiagolBoxMostrarFecha();
            string fechaproducto = sr.ReadLine();
            string nombreproducto = sr.ReadLine();
            string cantidad = sr.ReadLine();
            string precio = sr.ReadLine();
            string total = sr.ReadLine();


            if (buscar.ShowDialog() == DialogResult.OK)
            {
                
                while (fechaproducto != null)
                {

                    if (fechaproducto == buscar.fechaproducto)
                    {
                        bl = true;
                        suma += double.Parse(total);
                        ListViewItem datos = new ListViewItem(fechaproducto);
                        datos.SubItems.Add(nombreproducto);
                        datos.SubItems.Add(cantidad);
                        datos.SubItems.Add(precio);
                        datos.SubItems.Add(total);
                        caja.Items.Add(datos);


                    }
                    fechaproducto = sr.ReadLine();
                    nombreproducto = sr.ReadLine();
                    cantidad = sr.ReadLine();
                    precio = sr.ReadLine();
                    total = sr.ReadLine();

                }
                MessageBox.Show("" + suma);
                sr.Close();
            }
            if (bl == false)
            {
                MessageBox.Show("No se encontro la fecha de venta", "Archivos secuenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public void VentaBaja(ListView caja)
        {

            double totalmenor = 100;
            string fechamenor = "";
            string nombremenor = "";
            string cantidadmenor = "";
            string preciomenor = "";
            StreamReader sr = new StreamReader("..ArchivoProducto.txt");
            string fechaproducto = sr.ReadLine();
            string nombreproducto = sr.ReadLine();
            string cantidad = sr.ReadLine();
            string precio = sr.ReadLine();
            string total = sr.ReadLine();
            while (fechaproducto != null)
            {
                if (totalmenor > double.Parse(total))
                {
                    fechamenor = fechaproducto;
                    nombremenor = nombreproducto;
                    cantidadmenor = cantidad;
                    preciomenor = precio;
                    totalmenor = double.Parse(total);
                }
                fechaproducto = sr.ReadLine();
                nombreproducto = sr.ReadLine();
                cantidad = sr.ReadLine();
                precio = sr.ReadLine();
                total = sr.ReadLine();
            }
            ListViewItem datos = new ListViewItem(fechamenor);
            datos.SubItems.Add(nombremenor);
            datos.SubItems.Add(cantidadmenor);
            datos.SubItems.Add(preciomenor);
            datos.SubItems.Add(totalmenor.ToString());
            caja.Items.Add(datos);


            sr.Close();
        }

    } 
}