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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            panelContenedor = new Panel();
            Menu = new MenuStrip();
            btnInicioMenu = new ToolStripMenuItem();
            btnInicioInicio = new ToolStripMenuItem();
            cambiarRolDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            btnHospedajeMenu = new ToolStripMenuItem();
            btnTiendaMenu = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem1 = new ToolStripMenuItem();
            productosToolStripMenuItem1 = new ToolStripMenuItem();
            categoriasToolStripMenuItem2 = new ToolStripMenuItem();
            btnHabitacionesMenu = new ToolStripMenuItem();
            btnHabitaciones = new ToolStripMenuItem();
            btnCategorias = new ToolStripMenuItem();
            btnTareasPersonalMenu = new ToolStripMenuItem();
            personalToolStripMenuItem = new ToolStripMenuItem();
            btnEmpleado = new ToolStripMenuItem();
            btnCargo = new ToolStripMenuItem();
            btnAsignacion = new ToolStripMenuItem();
            btnReportesMenu = new ToolStripMenuItem();
            informeDeInventarioToolStripMenuItem = new ToolStripMenuItem();
            informeDeToolStripMenuItem = new ToolStripMenuItem();
            generadorDeNominaToolStripMenuItem = new ToolStripMenuItem();
            btnUsuariosMenu = new ToolStripMenuItem();
            btnUsuario = new ToolStripMenuItem();
            rolesDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            btnClientesMenu = new ToolStripMenuItem();
            btnAyudaMenu = new ToolStripMenuItem();
            panel1 = new Panel();
            lblUsuario = new Label();
            btnCambiarUsuario = new PictureBox();
            lblReloj = new Label();
            Reloj = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            label2 = new Label();
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
            Menu.Items.AddRange(new ToolStripItem[] { btnInicioMenu, btnHospedajeMenu, btnTiendaMenu, btnHabitacionesMenu, btnTareasPersonalMenu, btnReportesMenu, btnUsuariosMenu, btnClientesMenu, btnAyudaMenu });
            Menu.Name = "Menu";
            Menu.RenderMode = ToolStripRenderMode.Professional;
            Menu.ShowItemToolTips = true;
            // 
            // btnInicioMenu
            // 
            btnInicioMenu.DropDownItems.AddRange(new ToolStripItem[] { btnInicioInicio, cambiarRolDeUsuarioToolStripMenuItem });
            btnInicioMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnInicioMenu, "btnInicioMenu");
            btnInicioMenu.Margin = new Padding(0, 10, 0, 10);
            btnInicioMenu.Name = "btnInicioMenu";
            // 
            // btnInicioInicio
            // 
            btnInicioInicio.BackColor = Color.FromArgb(0, 51, 102);
            btnInicioInicio.ForeColor = Color.Beige;
            btnInicioInicio.Name = "btnInicioInicio";
            resources.ApplyResources(btnInicioInicio, "btnInicioInicio");
            btnInicioInicio.Click += btnInicioInicio_Click;
            // 
            // cambiarRolDeUsuarioToolStripMenuItem
            // 
            cambiarRolDeUsuarioToolStripMenuItem.BackColor = Color.FromArgb(0, 51, 102);
            cambiarRolDeUsuarioToolStripMenuItem.ForeColor = Color.Beige;
            cambiarRolDeUsuarioToolStripMenuItem.Name = "cambiarRolDeUsuarioToolStripMenuItem";
            resources.ApplyResources(cambiarRolDeUsuarioToolStripMenuItem, "cambiarRolDeUsuarioToolStripMenuItem");
            // 
            // btnHospedajeMenu
            // 
            btnHospedajeMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnHospedajeMenu, "btnHospedajeMenu");
            btnHospedajeMenu.Margin = new Padding(0, 10, 0, 10);
            btnHospedajeMenu.Name = "btnHospedajeMenu";
            btnHospedajeMenu.Click += btnHospedajeMenu_Click;
            // 
            // btnTiendaMenu
            // 
            btnTiendaMenu.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem, categoriasToolStripMenuItem1 });
            btnTiendaMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnTiendaMenu, "btnTiendaMenu");
            btnTiendaMenu.Margin = new Padding(0, 10, 0, 10);
            btnTiendaMenu.Name = "btnTiendaMenu";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            resources.ApplyResources(productosToolStripMenuItem, "productosToolStripMenuItem");
            // 
            // categoriasToolStripMenuItem1
            // 
            categoriasToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem1, categoriasToolStripMenuItem2 });
            categoriasToolStripMenuItem1.Name = "categoriasToolStripMenuItem1";
            resources.ApplyResources(categoriasToolStripMenuItem1, "categoriasToolStripMenuItem1");
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
            // btnTareasPersonalMenu
            // 
            btnTareasPersonalMenu.DropDownItems.AddRange(new ToolStripItem[] { personalToolStripMenuItem, btnAsignacion });
            btnTareasPersonalMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnTareasPersonalMenu, "btnTareasPersonalMenu");
            btnTareasPersonalMenu.Margin = new Padding(0, 10, 0, 10);
            btnTareasPersonalMenu.Name = "btnTareasPersonalMenu";
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
            // btnAsignacion
            // 
            btnAsignacion.Name = "btnAsignacion";
            resources.ApplyResources(btnAsignacion, "btnAsignacion");
            btnAsignacion.Click += btnAsignacion_Click;
            // 
            // btnReportesMenu
            // 
            btnReportesMenu.DropDownItems.AddRange(new ToolStripItem[] { informeDeInventarioToolStripMenuItem, informeDeToolStripMenuItem, generadorDeNominaToolStripMenuItem });
            btnReportesMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnReportesMenu, "btnReportesMenu");
            btnReportesMenu.Margin = new Padding(0, 10, 0, 10);
            btnReportesMenu.Name = "btnReportesMenu";
            // 
            // informeDeInventarioToolStripMenuItem
            // 
            informeDeInventarioToolStripMenuItem.Name = "informeDeInventarioToolStripMenuItem";
            resources.ApplyResources(informeDeInventarioToolStripMenuItem, "informeDeInventarioToolStripMenuItem");
            // 
            // informeDeToolStripMenuItem
            // 
            informeDeToolStripMenuItem.Name = "informeDeToolStripMenuItem";
            resources.ApplyResources(informeDeToolStripMenuItem, "informeDeToolStripMenuItem");
            // 
            // generadorDeNominaToolStripMenuItem
            // 
            generadorDeNominaToolStripMenuItem.Name = "generadorDeNominaToolStripMenuItem";
            resources.ApplyResources(generadorDeNominaToolStripMenuItem, "generadorDeNominaToolStripMenuItem");
            // 
            // btnUsuariosMenu
            // 
            btnUsuariosMenu.DropDownItems.AddRange(new ToolStripItem[] { btnUsuario, rolesDeUsuariosToolStripMenuItem });
            btnUsuariosMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnUsuariosMenu, "btnUsuariosMenu");
            btnUsuariosMenu.Margin = new Padding(0, 10, 0, 10);
            btnUsuariosMenu.Name = "btnUsuariosMenu";
            // 
            // btnUsuario
            // 
            btnUsuario.Name = "btnUsuario";
            resources.ApplyResources(btnUsuario, "btnUsuario");
            btnUsuario.Click += btnUsuario_Click;
            // 
            // rolesDeUsuariosToolStripMenuItem
            // 
            rolesDeUsuariosToolStripMenuItem.Name = "rolesDeUsuariosToolStripMenuItem";
            resources.ApplyResources(rolesDeUsuariosToolStripMenuItem, "rolesDeUsuariosToolStripMenuItem");
            // 
            // btnClientesMenu
            // 
            btnClientesMenu.ForeColor = Color.Beige;
            resources.ApplyResources(btnClientesMenu, "btnClientesMenu");
            btnClientesMenu.Margin = new Padding(0, 10, 0, 10);
            btnClientesMenu.Name = "btnClientesMenu";
            btnClientesMenu.Click += btnClientes_Click;
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
            resources.ApplyResources(btnCambiarUsuario, "btnCambiarUsuario");
            btnCambiarUsuario.Name = "btnCambiarUsuario";
            btnCambiarUsuario.TabStop = false;
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
            panel2.Controls.Add(label2);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Beige;
            label2.Name = "label2";
            // 
            // HomeView
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContenedor);
            Controls.Add(panel2);
            Controls.Add(Menu);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomeView";
            Load += HomeView_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCambiarUsuario).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelContenedor;
        private MenuStrip Menu;
        private ToolStripMenuItem btnInicioMenu;
        private ToolStripMenuItem cambiarRolDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem btnHospedajeMenu;
        private ToolStripMenuItem btnTiendaMenu;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem1;
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
        private ToolStripMenuItem btnInicioInicio;
        private ToolStripMenuItem btnUsuario;
        private ToolStripMenuItem rolesDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem informeDeInventarioToolStripMenuItem;
        private System.Windows.Forms.Timer Reloj;
        private Label lblReloj;
        private Label lblUsuario;
        private PictureBox btnCambiarUsuario;
        private ToolStripMenuItem btnTareasPersonalMenu;
        private ToolStripMenuItem personalToolStripMenuItem;
        private ToolStripMenuItem btnEmpleado;
        private ToolStripMenuItem btnCargo;
        private ToolStripMenuItem btnAsignacion;
        private ToolStripMenuItem informeDeToolStripMenuItem;
        private ToolStripMenuItem generadorDeNominaToolStripMenuItem;
        private Panel panel2;
        private Label label2;
    }
}