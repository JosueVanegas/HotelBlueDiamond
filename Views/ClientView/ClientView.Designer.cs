namespace Hotel_Dorado_DesktopApp.View.ClientesView
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
            btnRegistrar = new ReaLTaiizor.Controls.RoyalButton();
            lblTitulo = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panelContenedor = new Panel();
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
            tbClientes.BackgroundColor = Color.FromArgb(255, 255, 255);
            tbClientes.BorderStyle = BorderStyle.None;
            tbClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 177, 89);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tbClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tbClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbClientes.Columns.AddRange(new DataGridViewColumn[] { ID, Cedula, Nombre, Apellido, Email, Telefono, Editar, Borrar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tbClientes.DefaultCellStyle = dataGridViewCellStyle3;
            tbClientes.EnableHeadersVisualStyles = false;
            tbClientes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbClientes.GridColor = Color.FromArgb(255, 255, 255);
            tbClientes.Location = new Point(138, 29);
            tbClientes.MultiSelect = false;
            tbClientes.Name = "tbClientes";
            tbClientes.ReadOnly = true;
            tbClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 177, 89);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tbClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tbClientes.RowHeadersWidth = 51;
            tbClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbClientes.Size = new Size(758, 426);
            tbClientes.StandardTab = true;
            tbClientes.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            tbClientes.TabIndex = 0;
            tbClientes.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
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
            Editar.ReadOnly = true;
            Editar.Width = 40;
            // 
            // Borrar
            // 
            Borrar.HeaderText = "Borrar";
            Borrar.MinimumWidth = 6;
            Borrar.Name = "Borrar";
            Borrar.ReadOnly = true;
            Borrar.Width = 40;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 170);
            panel1.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.White;
            btnRegistrar.BackgroundImageLayout = ImageLayout.None;
            btnRegistrar.BorderColor = Color.LimeGreen;
            btnRegistrar.BorderThickness = 2;
            btnRegistrar.DrawBorder = true;
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.HotTrackColor = Color.FromArgb(221, 221, 221);
            btnRegistrar.Image = null;
            btnRegistrar.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            btnRegistrar.Location = new Point(272, 97);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.PressedColor = Color.FromArgb(244, 204, 137);
            btnRegistrar.PressedForeColor = Color.White;
            btnRegistrar.Size = new Size(229, 50);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Añadir nuevo cliente";
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1019, 76);
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
            panelContenedor.Location = new Point(0, 170);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1019, 495);
            panelContenedor.TabIndex = 2;
            // 
            // ClientView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1019, 665);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
        private ReaLTaiizor.Controls.RoyalButton btnRegistrar;
        private Panel panelContenedor;
    }
}