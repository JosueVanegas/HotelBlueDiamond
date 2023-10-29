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
            btnRecepcion = new ToolStripMenuItem();
            btnIngreso = new ToolStripMenuItem();
            btnRecepcionSalida = new ToolStripMenuItem();
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
            panelContenedor.AutoScroll = true;
            panelContenedor.BackColor = Color.Beige;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(203, 44);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1181, 618);
            panelContenedor.TabIndex = 0;
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(0, 51, 102);
            Menu.Dock = DockStyle.Left;
            Menu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Menu.GripMargin = new Padding(2, 2, 0, 10);
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { btnInicioMenu, btnHospedajeMenu, btnTiendaMenu, btnHabitacionesMenu, btnTareasPersonalMenu, btnReportesMenu, btnUsuariosMenu, btnClientesMenu, btnAyudaMenu });
            Menu.Location = new Point(0, 44);
            Menu.Margin = new Padding(0, 0, 0, 40);
            Menu.Name = "Menu";
            Menu.RenderMode = ToolStripRenderMode.Professional;
            Menu.ShowItemToolTips = true;
            Menu.Size = new Size(203, 653);
            Menu.TabIndex = 3;
            Menu.Text = "menuStrip1";
            // 
            // btnInicioMenu
            // 
            btnInicioMenu.DropDownItems.AddRange(new ToolStripItem[] { btnInicioInicio, cambiarRolDeUsuarioToolStripMenuItem });
            btnInicioMenu.ForeColor = Color.Beige;
            btnInicioMenu.Image = (Image)resources.GetObject("btnInicioMenu.Image");
            btnInicioMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicioMenu.ImageScaling = ToolStripItemImageScaling.None;
            btnInicioMenu.Margin = new Padding(0, 10, 0, 10);
            btnInicioMenu.Name = "btnInicioMenu";
            btnInicioMenu.Size = new Size(190, 36);
            btnInicioMenu.Text = "Inicio";
            btnInicioMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnInicioMenu.ToolTipText = "Inicio";
            // 
            // btnInicioInicio
            // 
            btnInicioInicio.BackColor = Color.FromArgb(0, 51, 102);
            btnInicioInicio.ForeColor = Color.Beige;
            btnInicioInicio.Name = "btnInicioInicio";
            btnInicioInicio.Size = new Size(344, 36);
            btnInicioInicio.Text = "Inicio";
            btnInicioInicio.Click += btnInicioInicio_Click;
            // 
            // cambiarRolDeUsuarioToolStripMenuItem
            // 
            cambiarRolDeUsuarioToolStripMenuItem.BackColor = Color.FromArgb(0, 51, 102);
            cambiarRolDeUsuarioToolStripMenuItem.ForeColor = Color.Beige;
            cambiarRolDeUsuarioToolStripMenuItem.Name = "cambiarRolDeUsuarioToolStripMenuItem";
            cambiarRolDeUsuarioToolStripMenuItem.Size = new Size(344, 36);
            cambiarRolDeUsuarioToolStripMenuItem.Text = "Cambiar rol de usuario";
            // 
            // btnHospedajeMenu
            // 
            btnHospedajeMenu.DropDownItems.AddRange(new ToolStripItem[] { btnRecepcion, btnIngreso, btnRecepcionSalida });
            btnHospedajeMenu.ForeColor = Color.Beige;
            btnHospedajeMenu.Image = (Image)resources.GetObject("btnHospedajeMenu.Image");
            btnHospedajeMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnHospedajeMenu.ImageScaling = ToolStripItemImageScaling.None;
            btnHospedajeMenu.Margin = new Padding(0, 10, 0, 10);
            btnHospedajeMenu.Name = "btnHospedajeMenu";
            btnHospedajeMenu.Size = new Size(190, 36);
            btnHospedajeMenu.Text = "Hospedaje";
            btnHospedajeMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnHospedajeMenu.ToolTipText = "Hospedaje";
            // 
            // btnRecepcion
            // 
            btnRecepcion.Name = "btnRecepcion";
            btnRecepcion.Size = new Size(224, 36);
            btnRecepcion.Text = "Recepción";
            btnRecepcion.Click += btnRecepcion_Click;
            // 
            // btnIngreso
            // 
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(224, 36);
            btnIngreso.Text = "Ingreso";
            btnIngreso.Click += btnIngreso_Click;
            // 
            // btnRecepcionSalida
            // 
            btnRecepcionSalida.Name = "btnRecepcionSalida";
            btnRecepcionSalida.Size = new Size(224, 36);
            btnRecepcionSalida.Text = "Salidadas";
            btnRecepcionSalida.Click += btnRecepcionSalida_Click;
            // 
            // btnTiendaMenu
            // 
            btnTiendaMenu.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem, categoriasToolStripMenuItem1 });
            btnTiendaMenu.ForeColor = Color.Beige;
            btnTiendaMenu.Image = (Image)resources.GetObject("btnTiendaMenu.Image");
            btnTiendaMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTiendaMenu.ImageScaling = ToolStripItemImageScaling.None;
            btnTiendaMenu.Margin = new Padding(0, 10, 0, 10);
            btnTiendaMenu.Name = "btnTiendaMenu";
            btnTiendaMenu.Size = new Size(190, 36);
            btnTiendaMenu.Text = "Tienda";
            btnTiendaMenu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(224, 36);
            productosToolStripMenuItem.Text = "Vender";
            // 
            // categoriasToolStripMenuItem1
            // 
            categoriasToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem1, categoriasToolStripMenuItem2 });
            categoriasToolStripMenuItem1.Name = "categoriasToolStripMenuItem1";
            categoriasToolStripMenuItem1.Size = new Size(224, 36);
            categoriasToolStripMenuItem1.Text = "Inventario";
            // 
            // productosToolStripMenuItem1
            // 
            productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            productosToolStripMenuItem1.Size = new Size(214, 36);
            productosToolStripMenuItem1.Text = "Productos";
            // 
            // categoriasToolStripMenuItem2
            // 
            categoriasToolStripMenuItem2.Name = "categoriasToolStripMenuItem2";
            categoriasToolStripMenuItem2.Size = new Size(214, 36);
            categoriasToolStripMenuItem2.Text = "Categorias";
            // 
            // btnHabitacionesMenu
            // 
            btnHabitacionesMenu.DropDownItems.AddRange(new ToolStripItem[] { btnHabitaciones, btnCategorias });
            btnHabitacionesMenu.ForeColor = Color.Beige;
            btnHabitacionesMenu.Image = (Image)resources.GetObject("btnHabitacionesMenu.Image");
            btnHabitacionesMenu.ImageScaling = ToolStripItemImageScaling.None;
            btnHabitacionesMenu.Margin = new Padding(0, 10, 0, 10);
            btnHabitacionesMenu.Name = "btnHabitacionesMenu";
            btnHabitacionesMenu.Size = new Size(190, 36);
            btnHabitacionesMenu.Text = "Habitaciones";
            btnHabitacionesMenu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnHabitaciones
            // 
            btnHabitaciones.Name = "btnHabitaciones";
            btnHabitaciones.Size = new Size(239, 36);
            btnHabitaciones.Text = "Habitaciones";
            btnHabitaciones.Click += btnHabitaciones_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(239, 36);
            btnCategorias.Text = "Categorias";
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnTareasPersonalMenu
            // 
            btnTareasPersonalMenu.DropDownItems.AddRange(new ToolStripItem[] { personalToolStripMenuItem, btnAsignacion });
            btnTareasPersonalMenu.ForeColor = Color.Beige;
            btnTareasPersonalMenu.Image = (Image)resources.GetObject("btnTareasPersonalMenu.Image");
            btnTareasPersonalMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTareasPersonalMenu.ImageScaling = ToolStripItemImageScaling.None;
            btnTareasPersonalMenu.Margin = new Padding(0, 10, 0, 10);
            btnTareasPersonalMenu.Name = "btnTareasPersonalMenu";
            btnTareasPersonalMenu.Size = new Size(190, 36);
            btnTareasPersonalMenu.Text = "Empleados";
            btnTareasPersonalMenu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // personalToolStripMenuItem
            // 
            personalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnEmpleado, btnCargo });
            personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            personalToolStripMenuItem.Size = new Size(224, 36);
            personalToolStripMenuItem.Text = "Personal";
            // 
            // btnEmpleado
            // 
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(218, 36);
            btnEmpleado.Text = "Empleados";
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnCargo
            // 
            btnCargo.Name = "btnCargo";
            btnCargo.Size = new Size(218, 36);
            btnCargo.Text = "Cargos";
            btnCargo.Click += btnCargo_Click;
            // 
            // btnAsignacion
            // 
            btnAsignacion.Name = "btnAsignacion";
            btnAsignacion.Size = new Size(224, 36);
            btnAsignacion.Text = "Asignacion";
            btnAsignacion.Click += btnAsignacion_Click;
            // 
            // btnReportesMenu
            // 
            btnReportesMenu.DropDownItems.AddRange(new ToolStripItem[] { informeDeInventarioToolStripMenuItem, informeDeToolStripMenuItem, generadorDeNominaToolStripMenuItem });
            btnReportesMenu.ForeColor = Color.Beige;
            btnReportesMenu.Image = (Image)resources.GetObject("btnReportesMenu.Image");
            btnReportesMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportesMenu.ImageScaling = ToolStripItemImageScaling.None;
            btnReportesMenu.Margin = new Padding(0, 10, 0, 10);
            btnReportesMenu.Name = "btnReportesMenu";
            btnReportesMenu.Size = new Size(190, 36);
            btnReportesMenu.Text = "Reportes";
            btnReportesMenu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // informeDeInventarioToolStripMenuItem
            // 
            informeDeInventarioToolStripMenuItem.Name = "informeDeInventarioToolStripMenuItem";
            informeDeInventarioToolStripMenuItem.Size = new Size(347, 36);
            informeDeInventarioToolStripMenuItem.Text = "Informe de inventario";
            // 
            // informeDeToolStripMenuItem
            // 
            informeDeToolStripMenuItem.Name = "informeDeToolStripMenuItem";
            informeDeToolStripMenuItem.Size = new Size(347, 36);
            informeDeToolStripMenuItem.Text = "Informe de hospedajes";
            // 
            // generadorDeNominaToolStripMenuItem
            // 
            generadorDeNominaToolStripMenuItem.Name = "generadorDeNominaToolStripMenuItem";
            generadorDeNominaToolStripMenuItem.Size = new Size(347, 36);
            generadorDeNominaToolStripMenuItem.Text = "Generador de nomina";
            // 
            // btnUsuariosMenu
            // 
            btnUsuariosMenu.DropDownItems.AddRange(new ToolStripItem[] { btnUsuario, rolesDeUsuariosToolStripMenuItem });
            btnUsuariosMenu.ForeColor = Color.Beige;
            btnUsuariosMenu.Image = (Image)resources.GetObject("btnUsuariosMenu.Image");
            btnUsuariosMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuariosMenu.ImageScaling = ToolStripItemImageScaling.None;
            btnUsuariosMenu.Margin = new Padding(0, 10, 0, 10);
            btnUsuariosMenu.Name = "btnUsuariosMenu";
            btnUsuariosMenu.Size = new Size(190, 36);
            btnUsuariosMenu.Text = "Usuarios";
            btnUsuariosMenu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnUsuario
            // 
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(319, 36);
            btnUsuario.Text = "Administrar usuarios";
            btnUsuario.Click += btnUsuario_Click;
            // 
            // rolesDeUsuariosToolStripMenuItem
            // 
            rolesDeUsuariosToolStripMenuItem.Name = "rolesDeUsuariosToolStripMenuItem";
            rolesDeUsuariosToolStripMenuItem.Size = new Size(319, 36);
            rolesDeUsuariosToolStripMenuItem.Text = "Roles de Usuarios";
            // 
            // btnClientesMenu
            // 
            btnClientesMenu.ForeColor = Color.Beige;
            btnClientesMenu.Image = (Image)resources.GetObject("btnClientesMenu.Image");
            btnClientesMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientesMenu.ImageScaling = ToolStripItemImageScaling.None;
            btnClientesMenu.Margin = new Padding(0, 10, 0, 10);
            btnClientesMenu.Name = "btnClientesMenu";
            btnClientesMenu.Size = new Size(190, 36);
            btnClientesMenu.Text = "Clientes";
            btnClientesMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnClientesMenu.Click += btnClientes_Click;
            // 
            // btnAyudaMenu
            // 
            btnAyudaMenu.ForeColor = Color.Beige;
            btnAyudaMenu.Image = (Image)resources.GetObject("btnAyudaMenu.Image");
            btnAyudaMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnAyudaMenu.ImageScaling = ToolStripItemImageScaling.None;
            btnAyudaMenu.Margin = new Padding(0, 10, 0, 10);
            btnAyudaMenu.Name = "btnAyudaMenu";
            btnAyudaMenu.Size = new Size(190, 36);
            btnAyudaMenu.Text = "Ayuda";
            btnAyudaMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnAyudaMenu.Click += btnAyudaMenu_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 51, 102);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(btnCambiarUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1384, 44);
            panel1.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.Dock = DockStyle.Right;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.Beige;
            lblUsuario.Location = new Point(1137, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(215, 44);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "admin";
            lblUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCambiarUsuario
            // 
            btnCambiarUsuario.Dock = DockStyle.Right;
            btnCambiarUsuario.Image = (Image)resources.GetObject("btnCambiarUsuario.Image");
            btnCambiarUsuario.Location = new Point(1352, 0);
            btnCambiarUsuario.Name = "btnCambiarUsuario";
            btnCambiarUsuario.Size = new Size(32, 44);
            btnCambiarUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            btnCambiarUsuario.TabIndex = 2;
            btnCambiarUsuario.TabStop = false;
            // 
            // lblReloj
            // 
            lblReloj.Dock = DockStyle.Fill;
            lblReloj.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblReloj.ForeColor = Color.Beige;
            lblReloj.Location = new Point(430, 0);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(751, 35);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "00:00:00";
            lblReloj.TextAlign = ContentAlignment.MiddleRight;
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
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(203, 662);
            panel2.Name = "panel2";
            panel2.Size = new Size(1181, 35);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Beige;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(430, 35);
            label2.TabIndex = 3;
            label2.Text = "Conectado  a la base de datos";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1384, 697);
            Controls.Add(panelContenedor);
            Controls.Add(panel2);
            Controls.Add(Menu);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomeView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel dorado app";
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
        private ToolStripMenuItem btnRecepcion;
        private ToolStripMenuItem btnRecepcionSalida;
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
        private ToolStripMenuItem btnIngreso;
    }
}