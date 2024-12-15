
namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProductosPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDelProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaMasAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaMasBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarVentasDeUnDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeProductosToolStripMenuItem,
            this.consultaDeProductosPorToolStripMenuItem,
            this.modificarDatosToolStripMenuItem,
            this.eliminarProductosToolStripMenuItem});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // altaDeProductosToolStripMenuItem
            // 
            this.altaDeProductosToolStripMenuItem.Name = "altaDeProductosToolStripMenuItem";
            this.altaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.altaDeProductosToolStripMenuItem.Text = "Alta de productos";
            this.altaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.altaDeProductosToolStripMenuItem_Click);
            // 
            // consultaDeProductosPorToolStripMenuItem
            // 
            this.consultaDeProductosPorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalesToolStripMenuItem,
            this.nombreDelProductoToolStripMenuItem,
            this.ventaMasAltaToolStripMenuItem,
            this.ventaMasBajaToolStripMenuItem,
            this.mostrarVentasDeUnDiaToolStripMenuItem});
            this.consultaDeProductosPorToolStripMenuItem.Name = "consultaDeProductosPorToolStripMenuItem";
            this.consultaDeProductosPorToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.consultaDeProductosPorToolStripMenuItem.Text = "Consulta de productos por...";
            // 
            // generalesToolStripMenuItem
            // 
            this.generalesToolStripMenuItem.Name = "generalesToolStripMenuItem";
            this.generalesToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.generalesToolStripMenuItem.Text = "Generales";
            this.generalesToolStripMenuItem.Click += new System.EventHandler(this.generalesToolStripMenuItem_Click);
            // 
            // nombreDelProductoToolStripMenuItem
            // 
            this.nombreDelProductoToolStripMenuItem.Name = "nombreDelProductoToolStripMenuItem";
            this.nombreDelProductoToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.nombreDelProductoToolStripMenuItem.Text = "Nombre del producto";
            this.nombreDelProductoToolStripMenuItem.Click += new System.EventHandler(this.nombreDelProductoToolStripMenuItem_Click);
            // 
            // ventaMasAltaToolStripMenuItem
            // 
            this.ventaMasAltaToolStripMenuItem.Name = "ventaMasAltaToolStripMenuItem";
            this.ventaMasAltaToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.ventaMasAltaToolStripMenuItem.Text = "Venta mas alta";
            this.ventaMasAltaToolStripMenuItem.Click += new System.EventHandler(this.ventaMasAltaToolStripMenuItem_Click);
            // 
            // ventaMasBajaToolStripMenuItem
            // 
            this.ventaMasBajaToolStripMenuItem.Name = "ventaMasBajaToolStripMenuItem";
            this.ventaMasBajaToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.ventaMasBajaToolStripMenuItem.Text = "Venta mas baja";
            this.ventaMasBajaToolStripMenuItem.Click += new System.EventHandler(this.ventaMasBajaToolStripMenuItem_Click);
            // 
            // mostrarVentasDeUnDiaToolStripMenuItem
            // 
            this.mostrarVentasDeUnDiaToolStripMenuItem.Name = "mostrarVentasDeUnDiaToolStripMenuItem";
            this.mostrarVentasDeUnDiaToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.mostrarVentasDeUnDiaToolStripMenuItem.Text = "Mostrar ventas de un dia";
            this.mostrarVentasDeUnDiaToolStripMenuItem.Click += new System.EventHandler(this.mostrarVentasDeUnDiaToolStripMenuItem_Click);
            // 
            // modificarDatosToolStripMenuItem
            // 
            this.modificarDatosToolStripMenuItem.Name = "modificarDatosToolStripMenuItem";
            this.modificarDatosToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.modificarDatosToolStripMenuItem.Text = "Modificar Productos";
            this.modificarDatosToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosToolStripMenuItem_Click);
            // 
            // eliminarProductosToolStripMenuItem
            // 
            this.eliminarProductosToolStripMenuItem.Name = "eliminarProductosToolStripMenuItem";
            this.eliminarProductosToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.eliminarProductosToolStripMenuItem.Text = "Eliminar productos";
            this.eliminarProductosToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductosToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(102, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(550, 183);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha de venta";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre del producto";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantidad";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(706, 293);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tienda Doña Chahi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProductosPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductosToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem generalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDelProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaMasAltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaMasBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarVentasDeUnDiaToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

