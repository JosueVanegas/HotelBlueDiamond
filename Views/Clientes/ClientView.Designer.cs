namespace Hotel.View.ClientesView
{
    partial class ClientView
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            lblTitulo = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panelContenedor = new Panel();
            btnAgregar = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)tbClientes).BeginInit();
            panel1.SuspendLayout();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // tbClientes
            // 
            tbClientes.AllowUserToAddRows = false;
            tbClientes.AllowUserToDeleteRows = false;
            tbClientes.AllowUserToResizeColumns = false;
            tbClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 204, 137);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            tbClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tbClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbClientes.BackgroundColor = Color.FromArgb(255, 255, 255);
            tbClientes.BorderStyle = BorderStyle.None;
            tbClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tbClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tbClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbClientes.Columns.AddRange(new DataGridViewColumn[] { ID, Cedula, Nombre, Apellido, Email, Telefono, Editar, Borrar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tbClientes.DefaultCellStyle = dataGridViewCellStyle3;
            tbClientes.Dock = DockStyle.Fill;
            tbClientes.EnableHeadersVisualStyles = false;
            tbClientes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbClientes.GridColor = Color.FromArgb(255, 255, 255);
            tbClientes.Location = new Point(0, 0);
            tbClientes.Margin = new Padding(3, 2, 3, 2);
            tbClientes.MultiSelect = false;
            tbClientes.Name = "tbClientes";
            tbClientes.ReadOnly = true;
            tbClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tbClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tbClientes.RowHeadersWidth = 51;
            tbClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbClientes.Size = new Size(892, 371);
            tbClientes.StandardTab = true;
            tbClientes.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
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
            // 
            // Cedula
            // 
            Cedula.HeaderText = "Cedula";
            Cedula.MinimumWidth = 6;
            Cedula.Name = "Cedula";
            Cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
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
            panel1.Size = new Size(892, 128);
            panel1.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(892, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Clientes";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(tbClientes);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 128);
            panelContenedor.Margin = new Padding(3, 2, 3, 2);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(892, 371);
            panelContenedor.TabIndex = 2;
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
            btnAgregar.Text = "Registrar nuevo cliente";
            btnAgregar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregar.UseAccentColor = false;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnRegistrar_Click;
            // 
            // ClientView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(892, 499);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClientView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)tbClientes).EndInit();
            panel1.ResumeLayout(false);
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView tbClientes;
        private Panel panel1;
        private Label lblTitulo;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Borrar;
        private Panel panelContenedor;
        private ReaLTaiizor.Controls.MaterialButton btnAgregar;
    }
}