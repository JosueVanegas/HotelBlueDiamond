namespace Hotel.Views.Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            panelContenedor = new Panel();
            Menu = new MenuStrip();
            btnInicioMenu = new ToolStripMenuItem();
            btnRecepcionMenu = new ToolStripMenuItem();
            btnTiendaMenu = new ToolStripMenuItem();
            btnServicioHabitacion = new ToolStripMenuItem();
            btnCompraSubMenu = new ToolStripMenuItem();
            btnInventarioSubMenu = new ToolStripMenuItem();
            productosToolStripMenuItem1 = new ToolStripMenuItem();
            categoriasToolStripMenuItem2 = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            btnHabitacionesMenu = new ToolStripMenuItem();
            btnHabitaciones = new ToolStripMenuItem();
            btnCategorias = new ToolStripMenuItem();
            btnEmpleadosMenu = new ToolStripMenuItem();
            btnAsignacion = new ToolStripMenuItem();
            personalToolStripMenuItem = new ToolStripMenuItem();
            btnEmpleado = new ToolStripMenuItem();
            btnCargo = new ToolStripMenuItem();
            btnClientesMenu = new ToolStripMenuItem();
            btnUsuariosMenu = new ToolStripMenuItem();
            btnReportesMenu = new ToolStripMenuItem();
            btnInformeInventario = new ToolStripMenuItem();
            btnInformeHospedajes = new ToolStripMenuItem();
            btnInformeNomina = new ToolStripMenuItem();
            btnAyudaMenu = new ToolStripMenuItem();
            panel1 = new Panel();
            lblUsuario = new Label();
            btnCambiarUsuario = new PictureBox();
            lblReloj = new Label();
            Reloj = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            lblConexion = new Label();
            Menu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCambiarUsuario).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            resources.ApplyResources(panelContenedor, "panelContenedor");
            panelContenedor.BackColor = Color.Beige;
            panelContenedor.Name = "panelContenedor";
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(0, 51, 102);
            resources.ApplyResources(Menu, "Menu");
            Menu.GripMargin = new Padding(2, 2, 0, 10);
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { btnInicioMenu, btnRecepcionMenu, btnTiendaMenu, btnHabitacionesMenu, btnEmpleadosMenu, btnClientesMenu, btnUsuariosMenu, btnReportesMenu, btnAyudaMenu });
            Menu.Name = "Menu";
            Menu.RenderMode = ToolStripRenderMode.Professional;
            Menu.ShowItemToolTips = true;
            // 
            // btnInicioMenu
            // 
            btnInicioMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnInicioMenu, "btnInicioMenu");
            btnInicioMenu.Margin = new Padding(0, 10, 0, 10);
            btnInicioMenu.Name = "btnInicioMenu";
            btnInicioMenu.Click += btnInicioMenu_Click;
            // 
            // btnRecepcionMenu
            // 
            btnRecepcionMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnRecepcionMenu, "btnRecepcionMenu");
            btnRecepcionMenu.Margin = new Padding(0, 10, 0, 10);
            btnRecepcionMenu.Name = "btnRecepcionMenu";
            btnRecepcionMenu.Click += btnHospedajeMenu_Click;
            // 
            // btnTiendaMenu
            // 
            btnTiendaMenu.DropDownItems.AddRange(new ToolStripItem[] { btnServicioHabitacion, btnCompraSubMenu, btnInventarioSubMenu });
            btnTiendaMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnTiendaMenu, "btnTiendaMenu");
            btnTiendaMenu.Margin = new Padding(0, 10, 0, 10);
            btnTiendaMenu.Name = "btnTiendaMenu";
            // 
            // btnServicioHabitacion
            // 
            btnServicioHabitacion.Name = "btnServicioHabitacion";
            resources.ApplyResources(btnServicioHabitacion, "btnServicioHabitacion");
            btnServicioHabitacion.Click += productosToolStripMenuItem_Click;
            // 
            // btnCompraSubMenu
            // 
            btnCompraSubMenu.Name = "btnCompraSubMenu";
            resources.ApplyResources(btnCompraSubMenu, "btnCompraSubMenu");
            btnCompraSubMenu.Click += comprarToolStripMenuItem_Click;
            // 
            // btnInventarioSubMenu
            // 
            btnInventarioSubMenu.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem1, categoriasToolStripMenuItem2, proveedoresToolStripMenuItem });
            btnInventarioSubMenu.Name = "btnInventarioSubMenu";
            resources.ApplyResources(btnInventarioSubMenu, "btnInventarioSubMenu");
            // 
            // productosToolStripMenuItem1
            // 
            productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            resources.ApplyResources(productosToolStripMenuItem1, "productosToolStripMenuItem1");
            productosToolStripMenuItem1.Click += productosToolStripMenuItem1_Click;
            // 
            // categoriasToolStripMenuItem2
            // 
            categoriasToolStripMenuItem2.Name = "categoriasToolStripMenuItem2";
            resources.ApplyResources(categoriasToolStripMenuItem2, "categoriasToolStripMenuItem2");
            categoriasToolStripMenuItem2.Click += categoriasToolStripMenuItem2_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            resources.ApplyResources(proveedoresToolStripMenuItem, "proveedoresToolStripMenuItem");
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click;
            // 
            // btnHabitacionesMenu
            // 
            btnHabitacionesMenu.DropDownItems.AddRange(new ToolStripItem[] { btnHabitaciones, btnCategorias });
            btnHabitacionesMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnHabitacionesMenu, "btnHabitacionesMenu");
            btnHabitacionesMenu.Margin = new Padding(0, 10, 0, 10);
            btnHabitacionesMenu.Name = "btnHabitacionesMenu";
            // 
            // btnHabitaciones
            // 
            btnHabitaciones.Name = "btnHabitaciones";
            resources.ApplyResources(btnHabitaciones, "btnHabitaciones");
            btnHabitaciones.Click += btnHabitaciones_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Name = "btnCategorias";
            resources.ApplyResources(btnCategorias, "btnCategorias");
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnEmpleadosMenu
            // 
            btnEmpleadosMenu.DropDownItems.AddRange(new ToolStripItem[] { btnAsignacion, personalToolStripMenuItem });
            btnEmpleadosMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnEmpleadosMenu, "btnEmpleadosMenu");
            btnEmpleadosMenu.Margin = new Padding(0, 10, 0, 10);
            btnEmpleadosMenu.Name = "btnEmpleadosMenu";
            // 
            // btnAsignacion
            // 
            btnAsignacion.Name = "btnAsignacion";
            resources.ApplyResources(btnAsignacion, "btnAsignacion");
            btnAsignacion.Click += btnAsignacion_Click;
            // 
            // personalToolStripMenuItem
            // 
            personalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnEmpleado, btnCargo });
            personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            resources.ApplyResources(personalToolStripMenuItem, "personalToolStripMenuItem");
            // 
            // btnEmpleado
            // 
            btnEmpleado.Name = "btnEmpleado";
            resources.ApplyResources(btnEmpleado, "btnEmpleado");
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnCargo
            // 
            btnCargo.Name = "btnCargo";
            resources.ApplyResources(btnCargo, "btnCargo");
            btnCargo.Click += btnCargo_Click;
            // 
            // btnClientesMenu
            // 
            btnClientesMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnClientesMenu, "btnClientesMenu");
            btnClientesMenu.Margin = new Padding(0, 10, 0, 10);
            btnClientesMenu.Name = "btnClientesMenu";
            btnClientesMenu.Click += btnClientes_Click;
            // 
            // btnUsuariosMenu
            // 
            btnUsuariosMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnUsuariosMenu, "btnUsuariosMenu");
            btnUsuariosMenu.Margin = new Padding(0, 10, 0, 10);
            btnUsuariosMenu.Name = "btnUsuariosMenu";
            btnUsuariosMenu.Click += btnUsuariosMenu_Click;
            // 
            // btnReportesMenu
            // 
            btnReportesMenu.DropDownItems.AddRange(new ToolStripItem[] { btnInformeInventario, btnInformeHospedajes, btnInformeNomina });
            btnReportesMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnReportesMenu, "btnReportesMenu");
            btnReportesMenu.Margin = new Padding(0, 10, 0, 10);
            btnReportesMenu.Name = "btnReportesMenu";
            // 
            // btnInformeInventario
            // 
            btnInformeInventario.Name = "btnInformeInventario";
            resources.ApplyResources(btnInformeInventario, "btnInformeInventario");
            btnInformeInventario.Click += informeDeInventarioToolStripMenuItem_Click;
            // 
            // btnInformeHospedajes
            // 
            btnInformeHospedajes.Name = "btnInformeHospedajes";
            resources.ApplyResources(btnInformeHospedajes, "btnInformeHospedajes");
            btnInformeHospedajes.Click += btnInformeHospedajes_Click;
            // 
            // btnInformeNomina
            // 
            btnInformeNomina.Name = "btnInformeNomina";
            resources.ApplyResources(btnInformeNomina, "btnInformeNomina");
            btnInformeNomina.Click += btnInformeNomina_Click;
            // 
            // btnAyudaMenu
            // 
            btnAyudaMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnAyudaMenu, "btnAyudaMenu");
            btnAyudaMenu.Margin = new Padding(0, 10, 0, 10);
            btnAyudaMenu.Name = "btnAyudaMenu";
            btnAyudaMenu.Click += btnAyudaMenu_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 51, 102);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(btnCambiarUsuario);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(lblUsuario, "lblUsuario");
            lblUsuario.ForeColor = Color.Beige;
            lblUsuario.Name = "lblUsuario";
            // 
            // btnCambiarUsuario
            // 
            btnCambiarUsuario.Cursor = Cursors.Hand;
            resources.ApplyResources(btnCambiarUsuario, "btnCambiarUsuario");
            btnCambiarUsuario.Name = "btnCambiarUsuario";
            btnCambiarUsuario.TabStop = false;
            btnCambiarUsuario.Click += btnCambiarUsuario_Click;
            // 
            // lblReloj
            // 
            resources.ApplyResources(lblReloj, "lblReloj");
            lblReloj.ForeColor = Color.Beige;
            lblReloj.Name = "lblReloj";
            // 
            // Reloj
            // 
            Reloj.Tick += Reloj_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 51, 102);
            panel2.Controls.Add(lblReloj);
            panel2.Controls.Add(lblConexion);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // lblConexion
            // 
            resources.ApplyResources(lblConexion, "lblConexion");
            lblConexion.ForeColor = Color.Beige;
            lblConexion.Name = "lblConexion";
            // 
            // HomeView
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContenedor);
            Controls.Add(panel2);
            Controls.Add(Menu);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "HomeView";
            WindowState = FormWindowState.Maximized;
            Load += HomeView_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCambiarUsuario).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelContenedor;
        private MenuStrip Menu;
        private ToolStripMenuItem btnInicioMenu;
        private ToolStripMenuItem btnRecepcionMenu;
        private ToolStripMenuItem btnTiendaMenu;
        private ToolStripMenuItem btnServicioHabitacion;
        private ToolStripMenuItem btnInventarioSubMenu;
        private ToolStripMenuItem btnHabitacionesMenu;
        private ToolStripMenuItem btnHabitaciones;
        private ToolStripMenuItem btnCategorias;
        private ToolStripMenuItem btnReportesMenu;
        private ToolStripMenuItem btnUsuariosMenu;
        private ToolStripMenuItem btnClientesMenu;
        private ToolStripMenuItem btnAyudaMenu;
        private ToolStripMenuItem productosToolStripMenuItem1;
        private ToolStripMenuItem categoriasToolStripMenuItem2;
        private Panel panel1;
        private ToolStripMenuItem btnInformeInventario;
        private System.Windows.Forms.Timer Reloj;
        private Label lblReloj;
        private Label lblUsuario;
        private PictureBox btnCambiarUsuario;
        private ToolStripMenuItem btnEmpleadosMenu;
        private ToolStripMenuItem personalToolStripMenuItem;
        private ToolStripMenuItem btnEmpleado;
        private ToolStripMenuItem btnCargo;
        private ToolStripMenuItem btnAsignacion;
        private ToolStripMenuItem btnInformeHospedajes;
        private ToolStripMenuItem btnInformeNomina;
        private Panel panel2;
        private Label lblConexion;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem btnCompraSubMenu;
    }
}