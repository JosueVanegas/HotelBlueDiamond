namespace Hotel_Dorado_DesktopApp.View
{
    partial class HomeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContenedor = new Panel();
            menuStrip1 = new MenuStrip();
            btnInicio = new ToolStripMenuItem();
            btnSalir = new ToolStripMenuItem();
            cambiarRolDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            gestionarToolStripMenuItem = new ToolStripMenuItem();
            btnRecepcion = new ToolStripMenuItem();
            btnRecepcionSalida = new ToolStripMenuItem();
            tiendaToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem1 = new ToolStripMenuItem();
            productosToolStripMenuItem1 = new ToolStripMenuItem();
            categoriasToolStripMenuItem2 = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            btnHabitaciones = new ToolStripMenuItem();
            btnPisos = new ToolStripMenuItem();
            btnCategorias = new ToolStripMenuItem();
            reportesToolStripMenuItem1 = new ToolStripMenuItem();
            btnUsuarios = new ToolStripMenuItem();
            btnClientes = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 28);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1364, 815);
            panelContenedor.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(244, 204, 137);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnInicio, gestionarToolStripMenuItem, tiendaToolStripMenuItem, reportesToolStripMenuItem, reportesToolStripMenuItem1, btnUsuarios, btnClientes, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1364, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnInicio
            // 
            btnInicio.DropDownItems.AddRange(new ToolStripItem[] { btnSalir, cambiarRolDeUsuarioToolStripMenuItem });
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(59, 24);
            btnInicio.Text = "Inicio";
            btnInicio.Click += btnInicio_Click;
            // 
            // btnSalir
            // 
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(243, 26);
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // cambiarRolDeUsuarioToolStripMenuItem
            // 
            cambiarRolDeUsuarioToolStripMenuItem.Name = "cambiarRolDeUsuarioToolStripMenuItem";
            cambiarRolDeUsuarioToolStripMenuItem.Size = new Size(243, 26);
            cambiarRolDeUsuarioToolStripMenuItem.Text = "Cambiar rol de usuario";
            // 
            // gestionarToolStripMenuItem
            // 
            gestionarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnRecepcion, btnRecepcionSalida });
            gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            gestionarToolStripMenuItem.Size = new Size(86, 24);
            gestionarToolStripMenuItem.Text = "Gestionar";
            // 
            // btnRecepcion
            // 
            btnRecepcion.Name = "btnRecepcion";
            btnRecepcion.Size = new Size(224, 26);
            btnRecepcion.Text = "Recepción";
            btnRecepcion.Click += btnRecepcion_Click;
            // 
            // btnRecepcionSalida
            // 
            btnRecepcionSalida.Name = "btnRecepcionSalida";
            btnRecepcionSalida.Size = new Size(224, 26);
            btnRecepcionSalida.Text = "Salida";
            // 
            // tiendaToolStripMenuItem
            // 
            tiendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem, categoriasToolStripMenuItem1 });
            tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            tiendaToolStripMenuItem.Size = new Size(68, 24);
            tiendaToolStripMenuItem.Text = "Tienda";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(158, 26);
            productosToolStripMenuItem.Text = "Vender";
            // 
            // categoriasToolStripMenuItem1
            // 
            categoriasToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem1, categoriasToolStripMenuItem2 });
            categoriasToolStripMenuItem1.Name = "categoriasToolStripMenuItem1";
            categoriasToolStripMenuItem1.Size = new Size(158, 26);
            categoriasToolStripMenuItem1.Text = "Inventario";
            // 
            // productosToolStripMenuItem1
            // 
            productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            productosToolStripMenuItem1.Size = new Size(163, 26);
            productosToolStripMenuItem1.Text = "Productos";
            // 
            // categoriasToolStripMenuItem2
            // 
            categoriasToolStripMenuItem2.Name = "categoriasToolStripMenuItem2";
            categoriasToolStripMenuItem2.Size = new Size(163, 26);
            categoriasToolStripMenuItem2.Text = "Categorias";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnHabitaciones, btnPisos, btnCategorias });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(124, 24);
            reportesToolStripMenuItem.Text = "Mantenimiento";
            // 
            // btnHabitaciones
            // 
            btnHabitaciones.Name = "btnHabitaciones";
            btnHabitaciones.Size = new Size(224, 26);
            btnHabitaciones.Text = "Habitaciones";
            btnHabitaciones.Click += btnHabitaciones_Click;
            // 
            // btnPisos
            // 
            btnPisos.Name = "btnPisos";
            btnPisos.Size = new Size(224, 26);
            btnPisos.Text = "Pisos";
            btnPisos.Click += btnPisos_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(224, 26);
            btnCategorias.Text = "Categorias";
            btnCategorias.Click += btnCategorias_Click;
            // 
            // reportesToolStripMenuItem1
            // 
            reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            reportesToolStripMenuItem1.Size = new Size(82, 24);
            reportesToolStripMenuItem1.Text = "Reportes";
            // 
            // btnUsuarios
            // 
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(79, 24);
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnClientes
            // 
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(75, 24);
            btnClientes.Text = "Clientes";
            btnClientes.Click += btnClientes_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1364, 843);
            Controls.Add(panelContenedor);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel dorado app";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelContenedor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem btnInicio;
        private ToolStripMenuItem btnSalir;
        private ToolStripMenuItem cambiarRolDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem gestionarToolStripMenuItem;
        private ToolStripMenuItem btnRecepcion;
        private ToolStripMenuItem btnRecepcionSalida;
        private ToolStripMenuItem tiendaToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem1;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem btnHabitaciones;
        private ToolStripMenuItem btnPisos;
        private ToolStripMenuItem btnCategorias;
        private ToolStripMenuItem reportesToolStripMenuItem1;
        private ToolStripMenuItem btnUsuarios;
        private ToolStripMenuItem btnClientes;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem1;
        private ToolStripMenuItem categoriasToolStripMenuItem2;
    }
}