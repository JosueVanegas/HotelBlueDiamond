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
            btnInicio = new ToolStripMenuItem();
            btnInicioInicio = new ToolStripMenuItem();
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
            btnCategorias = new ToolStripMenuItem();
            tareasPersonalToolStripMenuItem = new ToolStripMenuItem();
            personalToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            cargosToolStripMenuItem = new ToolStripMenuItem();
            asignacionToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem1 = new ToolStripMenuItem();
            informeDeInventarioToolStripMenuItem = new ToolStripMenuItem();
            informeDeToolStripMenuItem = new ToolStripMenuItem();
            generadorDeNominaToolStripMenuItem = new ToolStripMenuItem();
            btnUsuarios = new ToolStripMenuItem();
            administrarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            rolesDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            btnClientes = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            lblReloj = new Label();
            lblUsuario = new Label();
            btnCambiarUsuario = new PictureBox();
            btnSalir = new PictureBox();
            Reloj = new System.Windows.Forms.Timer(components);
            Menu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCambiarUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.AutoScroll = true;
            panelContenedor.BackColor = Color.White;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(171, 35);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1213, 662);
            panelContenedor.TabIndex = 0;
            // 
            // Menu
            // 
            Menu.BackColor = Color.White;
            Menu.Dock = DockStyle.Left;
            Menu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Menu.GripMargin = new Padding(2, 2, 0, 10);
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { btnInicio, gestionarToolStripMenuItem, tiendaToolStripMenuItem, reportesToolStripMenuItem, tareasPersonalToolStripMenuItem, reportesToolStripMenuItem1, btnUsuarios, btnClientes, ayudaToolStripMenuItem });
            Menu.Location = new Point(0, 35);
            Menu.Margin = new Padding(0, 0, 0, 10);
            Menu.Name = "Menu";
            Menu.RenderMode = ToolStripRenderMode.Professional;
            Menu.ShowItemToolTips = true;
            Menu.Size = new Size(171, 662);
            Menu.TabIndex = 3;
            Menu.Text = "menuStrip1";
            // 
            // btnInicio
            // 
            btnInicio.DropDownItems.AddRange(new ToolStripItem[] { btnInicioInicio, cambiarRolDeUsuarioToolStripMenuItem });
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(158, 36);
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnInicioInicio
            // 
            btnInicioInicio.Name = "btnInicioInicio";
            btnInicioInicio.Size = new Size(344, 36);
            btnInicioInicio.Text = "Inicio";
            btnInicioInicio.Click += btnInicioInicio_Click;
            // 
            // cambiarRolDeUsuarioToolStripMenuItem
            // 
            cambiarRolDeUsuarioToolStripMenuItem.Name = "cambiarRolDeUsuarioToolStripMenuItem";
            cambiarRolDeUsuarioToolStripMenuItem.Size = new Size(344, 36);
            cambiarRolDeUsuarioToolStripMenuItem.Text = "Cambiar rol de usuario";
            // 
            // gestionarToolStripMenuItem
            // 
            gestionarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnRecepcion, btnRecepcionSalida });
            gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            gestionarToolStripMenuItem.Size = new Size(158, 36);
            gestionarToolStripMenuItem.Text = "Hospedaje";
            gestionarToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRecepcion
            // 
            btnRecepcion.Name = "btnRecepcion";
            btnRecepcion.Size = new Size(211, 36);
            btnRecepcion.Text = "Recepción";
            btnRecepcion.Click += btnRecepcion_Click;
            // 
            // btnRecepcionSalida
            // 
            btnRecepcionSalida.Name = "btnRecepcionSalida";
            btnRecepcionSalida.Size = new Size(211, 36);
            btnRecepcionSalida.Text = "Salidadas";
            // 
            // tiendaToolStripMenuItem
            // 
            tiendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem, categoriasToolStripMenuItem1 });
            tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            tiendaToolStripMenuItem.Size = new Size(158, 36);
            tiendaToolStripMenuItem.Text = "Tienda";
            tiendaToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(209, 36);
            productosToolStripMenuItem.Text = "Vender";
            // 
            // categoriasToolStripMenuItem1
            // 
            categoriasToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem1, categoriasToolStripMenuItem2 });
            categoriasToolStripMenuItem1.Name = "categoriasToolStripMenuItem1";
            categoriasToolStripMenuItem1.Size = new Size(209, 36);
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
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnHabitaciones, btnCategorias });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(158, 36);
            reportesToolStripMenuItem.Text = "Habitaciones";
            reportesToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
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
            // tareasPersonalToolStripMenuItem
            // 
            tareasPersonalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personalToolStripMenuItem, asignacionToolStripMenuItem });
            tareasPersonalToolStripMenuItem.Name = "tareasPersonalToolStripMenuItem";
            tareasPersonalToolStripMenuItem.Size = new Size(158, 36);
            tareasPersonalToolStripMenuItem.Text = "Empleados";
            tareasPersonalToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // personalToolStripMenuItem
            // 
            personalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { empleadosToolStripMenuItem, cargosToolStripMenuItem });
            personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            personalToolStripMenuItem.Size = new Size(218, 36);
            personalToolStripMenuItem.Text = "Personal";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(218, 36);
            empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // cargosToolStripMenuItem
            // 
            cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            cargosToolStripMenuItem.Size = new Size(218, 36);
            cargosToolStripMenuItem.Text = "Cargos";
            // 
            // asignacionToolStripMenuItem
            // 
            asignacionToolStripMenuItem.Name = "asignacionToolStripMenuItem";
            asignacionToolStripMenuItem.Size = new Size(218, 36);
            asignacionToolStripMenuItem.Text = "Asignacion";
            // 
            // reportesToolStripMenuItem1
            // 
            reportesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { informeDeInventarioToolStripMenuItem, informeDeToolStripMenuItem, generadorDeNominaToolStripMenuItem });
            reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            reportesToolStripMenuItem1.Size = new Size(158, 36);
            reportesToolStripMenuItem1.Text = "Reportes";
            reportesToolStripMenuItem1.TextAlign = ContentAlignment.MiddleLeft;
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
            // btnUsuarios
            // 
            btnUsuarios.DropDownItems.AddRange(new ToolStripItem[] { administrarUsuariosToolStripMenuItem, rolesDeUsuariosToolStripMenuItem });
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(158, 36);
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // administrarUsuariosToolStripMenuItem
            // 
            administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            administrarUsuariosToolStripMenuItem.Size = new Size(319, 36);
            administrarUsuariosToolStripMenuItem.Text = "Administrar usuarios";
            // 
            // rolesDeUsuariosToolStripMenuItem
            // 
            rolesDeUsuariosToolStripMenuItem.Name = "rolesDeUsuariosToolStripMenuItem";
            rolesDeUsuariosToolStripMenuItem.Size = new Size(319, 36);
            rolesDeUsuariosToolStripMenuItem.Text = "Roles de Usuarios";
            // 
            // btnClientes
            // 
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(158, 36);
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.Click += btnClientes_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(158, 36);
            ayudaToolStripMenuItem.Text = "Ayuda";
            ayudaToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblReloj);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(btnCambiarUsuario);
            panel1.Controls.Add(btnSalir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1384, 35);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(475, 0);
            label1.Name = "label1";
            label1.Size = new Size(445, 35);
            label1.TabIndex = 4;
            label1.Text = "Hotel Dorado";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReloj
            // 
            lblReloj.Dock = DockStyle.Left;
            lblReloj.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblReloj.Location = new Point(0, 0);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(345, 35);
            lblReloj.TabIndex = 0;
            lblReloj.Text = "00:00:00";
            lblReloj.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            lblUsuario.Dock = DockStyle.Right;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(920, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(351, 35);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "admin";
            lblUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCambiarUsuario
            // 
            btnCambiarUsuario.Dock = DockStyle.Right;
            btnCambiarUsuario.Image = (Image)resources.GetObject("btnCambiarUsuario.Image");
            btnCambiarUsuario.Location = new Point(1271, 0);
            btnCambiarUsuario.Name = "btnCambiarUsuario";
            btnCambiarUsuario.Size = new Size(64, 35);
            btnCambiarUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            btnCambiarUsuario.TabIndex = 2;
            btnCambiarUsuario.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(1335, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(49, 35);
            btnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnSalir.TabIndex = 1;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseLeave += btnSalir_MouseLeave;
            btnSalir.MouseHover += btnSalir_MouseHover;
            // 
            // Reloj
            // 
            Reloj.Tick += Reloj_Tick;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1384, 697);
            Controls.Add(panelContenedor);
            Controls.Add(Menu);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel dorado app";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCambiarUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelContenedor;
        private MenuStrip Menu;
        private ToolStripMenuItem btnInicio;
        private ToolStripMenuItem cambiarRolDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem gestionarToolStripMenuItem;
        private ToolStripMenuItem btnRecepcion;
        private ToolStripMenuItem btnRecepcionSalida;
        private ToolStripMenuItem tiendaToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem1;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem btnHabitaciones;
        private ToolStripMenuItem btnCategorias;
        private ToolStripMenuItem reportesToolStripMenuItem1;
        private ToolStripMenuItem btnUsuarios;
        private ToolStripMenuItem btnClientes;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem1;
        private ToolStripMenuItem categoriasToolStripMenuItem2;
        private Panel panel1;
        private ToolStripMenuItem btnInicioInicio;
        private ToolStripMenuItem administrarUsuariosToolStripMenuItem;
        private ToolStripMenuItem rolesDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem informeDeInventarioToolStripMenuItem;
        private System.Windows.Forms.Timer Reloj;
        private Label lblReloj;
        private PictureBox btnSalir;
        private Label lblUsuario;
        private PictureBox btnCambiarUsuario;
        private Label label1;
        private ToolStripMenuItem tareasPersonalToolStripMenuItem;
        private ToolStripMenuItem personalToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem cargosToolStripMenuItem;
        private ToolStripMenuItem asignacionToolStripMenuItem;
        private ToolStripMenuItem informeDeToolStripMenuItem;
        private ToolStripMenuItem generadorDeNominaToolStripMenuItem;
    }
}