namespace Hotel.Views.Usuarios
{
    partial class UsuariosView
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
            lblTitulo = new Label();
            panel1 = new Panel();
            tbUsuario = new ReaLTaiizor.Controls.PoisonDataGridView();
            ID = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Borrar = new DataGridViewButtonColumn();
            btnAgregar = new ReaLTaiizor.Controls.MaterialButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbUsuario).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(997, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Usuarios";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.Size = new Size(997, 128);
            panel1.TabIndex = 3;
            // 
            // tbUsuario
            // 
            tbUsuario.AllowUserToAddRows = false;
            tbUsuario.AllowUserToDeleteRows = false;
            tbUsuario.AllowUserToResizeColumns = false;
            tbUsuario.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(244, 204, 137);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            tbUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            tbUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbUsuario.BackgroundColor = Color.FromArgb(255, 255, 255);
            tbUsuario.BorderStyle = BorderStyle.None;
            tbUsuario.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            tbUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            tbUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbUsuario.Columns.AddRange(new DataGridViewColumn[] { ID, Usuario, Nombre, Apellido, Rol, Editar, Borrar });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            tbUsuario.DefaultCellStyle = dataGridViewCellStyle7;
            tbUsuario.Dock = DockStyle.Fill;
            tbUsuario.EnableHeadersVisualStyles = false;
            tbUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUsuario.GridColor = Color.FromArgb(255, 255, 255);
            tbUsuario.Location = new Point(0, 128);
            tbUsuario.Margin = new Padding(3, 2, 3, 2);
            tbUsuario.MultiSelect = false;
            tbUsuario.Name = "tbUsuario";
            tbUsuario.ReadOnly = true;
            tbUsuario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            tbUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            tbUsuario.RowHeadersWidth = 51;
            tbUsuario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbUsuario.Size = new Size(997, 473);
            tbUsuario.StandardTab = true;
            tbUsuario.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            tbUsuario.TabIndex = 2;
            tbUsuario.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            tbUsuario.CellContentClick += cellContentClick;
            tbUsuario.CellPainting += cellPainting;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
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
            // Rol
            // 
            Rol.HeaderText = "Rol ";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
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
            btnAgregar.Text = "Crear nuevo usuario";
            btnAgregar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregar.UseAccentColor = false;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnRegistrar_Click;
            // 
            // UsuariosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 601);
            Controls.Add(tbUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UsuariosView";
            Text = "UsuariosView";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private ReaLTaiizor.Controls.PoisonDataGridView tbUsuario;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Borrar;
        private ReaLTaiizor.Controls.MaterialButton btnAgregar;
    }
}