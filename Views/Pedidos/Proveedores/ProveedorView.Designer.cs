namespace Hotel.Views.Pedidos.Proveedores
{
    partial class ProveedorView
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tbProveedor = new ReaLTaiizor.Controls.PoisonDataGridView();
            ID = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Nacimiento = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Borrar = new DataGridViewButtonColumn();
            panel1 = new Panel();
            lblTitulo = new Label();
            btnAgregar = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)tbProveedor).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbProveedor
            // 
            tbProveedor.AllowUserToAddRows = false;
            tbProveedor.AllowUserToDeleteRows = false;
            tbProveedor.AllowUserToResizeColumns = false;
            tbProveedor.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(244, 204, 137);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            tbProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            tbProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbProveedor.BackgroundColor = Color.FromArgb(255, 255, 255);
            tbProveedor.BorderStyle = BorderStyle.None;
            tbProveedor.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbProveedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            tbProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            tbProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbProveedor.Columns.AddRange(new DataGridViewColumn[] { ID, Cedula, Nombre, Apellido, Nacimiento, Cargo, Column1, Editar, Borrar });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            tbProveedor.DefaultCellStyle = dataGridViewCellStyle7;
            tbProveedor.Dock = DockStyle.Fill;
            tbProveedor.EnableHeadersVisualStyles = false;
            tbProveedor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbProveedor.GridColor = Color.FromArgb(255, 255, 255);
            tbProveedor.Location = new Point(0, 128);
            tbProveedor.Margin = new Padding(3, 2, 3, 2);
            tbProveedor.MultiSelect = false;
            tbProveedor.Name = "tbProveedor";
            tbProveedor.ReadOnly = true;
            tbProveedor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            tbProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            tbProveedor.RowHeadersWidth = 51;
            tbProveedor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbProveedor.Size = new Size(985, 419);
            tbProveedor.StandardTab = true;
            tbProveedor.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            tbProveedor.TabIndex = 8;
            tbProveedor.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            tbProveedor.CellContentClick += cellContentClick;
            tbProveedor.CellPainting += cellPainting;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Cedula
            // 
            Cedula.HeaderText = "Empresa";
            Cedula.MinimumWidth = 6;
            Cedula.Name = "Cedula";
            Cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Contacto";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Cargo";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Nacimiento
            // 
            Nacimiento.HeaderText = "Telefono";
            Nacimiento.Name = "Nacimiento";
            Nacimiento.ReadOnly = true;
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Fax";
            Cargo.Name = "Cargo";
            Cargo.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Dirección";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            // 
            // Borrar
            // 
            Borrar.HeaderText = "Borrar";
            Borrar.MinimumWidth = 6;
            Borrar.Name = "Borrar";
            Borrar.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 128);
            panel1.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(985, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Proveedores";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = false;
            btnAgregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregar.Depth = 0;
            btnAgregar.HighEmphasis = true;
            btnAgregar.Icon = null;
            btnAgregar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAgregar.Location = new Point(4, 73);
            btnAgregar.Margin = new Padding(4, 6, 4, 6);
            btnAgregar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAgregar.Name = "btnAgregar";
            btnAgregar.NoAccentTextColor = Color.Empty;
            btnAgregar.Size = new Size(372, 49);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Registrar nuevo proveedor";
            btnAgregar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregar.UseAccentColor = false;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnRegistrar_Click;
            // 
            // ProveedorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 547);
            Controls.Add(tbProveedor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProveedorView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProveedorView";
            ((System.ComponentModel.ISupportInitialize)tbProveedor).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView tbProveedor;
        private Panel panel1;
        private Label lblTitulo;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nacimiento;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Borrar;
        private ReaLTaiizor.Controls.MaterialButton btnAgregar;
    }
}