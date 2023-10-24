namespace Hotel_Dorado_DesktopApp.View.ClientesView
{
    partial class FormClientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tbClientes = new ReaLTaiizor.Controls.PoisonDataGridView();
            ID = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Borrar = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnsalir = new ReaLTaiizor.Controls.HopeRoundButton();
            lblTitulo = new Label();
            btnNuevoRegistro = new ReaLTaiizor.Controls.MaterialButton();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)tbClientes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbClientes
            // 
            tbClientes.AllowUserToAddRows = false;
            tbClientes.AllowUserToOrderColumns = true;
            tbClientes.AllowUserToResizeRows = false;
            tbClientes.BackgroundColor = Color.FromArgb(255, 255, 255);
            tbClientes.BorderStyle = BorderStyle.None;
            tbClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(63, 81, 181);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(70, 140, 180);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbClientes.Columns.AddRange(new DataGridViewColumn[] { ID, Cedula, Nombre, Apellido, Email, Telefono, Editar, Borrar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbClientes.DefaultCellStyle = dataGridViewCellStyle2;
            tbClientes.EnableHeadersVisualStyles = false;
            tbClientes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbClientes.GridColor = Color.FromArgb(255, 255, 255);
            tbClientes.Location = new Point(54, 165);
            tbClientes.Name = "tbClientes";
            tbClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tbClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tbClientes.RowHeadersWidth = 51;
            tbClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbClientes.Size = new Size(755, 319);
            tbClientes.TabIndex = 0;
            tbClientes.CellContentClick += cellContentClick;
            tbClientes.CellPainting += cellPainting;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 125;
            // 
            // Cedula
            // 
            Cedula.HeaderText = "Cedula";
            Cedula.MinimumWidth = 6;
            Cedula.Name = "Cedula";
            Cedula.ReadOnly = true;
            Cedula.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 125;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.Width = 40;
            // 
            // Borrar
            // 
            Borrar.HeaderText = "Borrar";
            Borrar.MinimumWidth = 6;
            Borrar.Name = "Borrar";
            Borrar.Width = 40;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnsalir);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(btnNuevoRegistro);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 159);
            panel1.TabIndex = 1;
            // 
            // btnsalir
            // 
            btnsalir.BorderColor = Color.FromArgb(220, 223, 230);
            btnsalir.ButtonType = ReaLTaiizor.Util.HopeButtonType.Danger;
            btnsalir.DangerColor = Color.FromArgb(245, 108, 108);
            btnsalir.DefaultColor = Color.FromArgb(255, 255, 255);
            btnsalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsalir.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnsalir.InfoColor = Color.FromArgb(144, 147, 153);
            btnsalir.Location = new Point(54, 95);
            btnsalir.Name = "btnsalir";
            btnsalir.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnsalir.Size = new Size(98, 50);
            btnsalir.SuccessColor = Color.FromArgb(103, 194, 58);
            btnsalir.TabIndex = 2;
            btnsalir.Text = "Salir";
            btnsalir.TextColor = Color.White;
            btnsalir.WarningColor = Color.FromArgb(230, 162, 60);
            btnsalir.Click += btnsalir_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(855, 66);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Clientes";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNuevoRegistro
            // 
            btnNuevoRegistro.AutoSize = false;
            btnNuevoRegistro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNuevoRegistro.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNuevoRegistro.Depth = 0;
            btnNuevoRegistro.HighEmphasis = true;
            btnNuevoRegistro.Icon = null;
            btnNuevoRegistro.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNuevoRegistro.Location = new Point(326, 95);
            btnNuevoRegistro.Margin = new Padding(4, 6, 4, 6);
            btnNuevoRegistro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNuevoRegistro.Name = "btnNuevoRegistro";
            btnNuevoRegistro.NoAccentTextColor = Color.Empty;
            btnNuevoRegistro.Size = new Size(198, 52);
            btnNuevoRegistro.TabIndex = 0;
            btnNuevoRegistro.Text = "Crear nuevo registro";
            btnNuevoRegistro.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNuevoRegistro.UseAccentColor = false;
            btnNuevoRegistro.UseVisualStyleBackColor = true;
            btnNuevoRegistro.Click += btnNuevoRegistro_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 496);
            Controls.Add(panel1);
            Controls.Add(tbClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)tbClientes).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView tbClientes;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialButton btnNuevoRegistro;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.HopeRoundButton btnsalir;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Borrar;
    }
}