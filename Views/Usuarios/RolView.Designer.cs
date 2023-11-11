namespace Hotel_Dorado_DesktopApp.Views.Usuarios
{
    partial class RolView
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
            tbRoles = new ReaLTaiizor.Controls.PoisonDataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Borrar = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnRegistrar = new ReaLTaiizor.Controls.RoyalButton();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)tbRoles).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbRoles
            // 
            tbRoles.AllowUserToAddRows = false;
            tbRoles.AllowUserToDeleteRows = false;
            tbRoles.AllowUserToResizeColumns = false;
            tbRoles.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(244, 204, 137);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            tbRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            tbRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbRoles.BackgroundColor = Color.FromArgb(255, 255, 255);
            tbRoles.BorderStyle = BorderStyle.None;
            tbRoles.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbRoles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 196, 37);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 201, 57);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            tbRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            tbRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbRoles.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion, Fecha, Editar, Borrar });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 201, 57);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            tbRoles.DefaultCellStyle = dataGridViewCellStyle7;
            tbRoles.Dock = DockStyle.Fill;
            tbRoles.EnableHeadersVisualStyles = false;
            tbRoles.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbRoles.GridColor = Color.FromArgb(255, 255, 255);
            tbRoles.Location = new Point(0, 128);
            tbRoles.Margin = new Padding(3, 2, 3, 2);
            tbRoles.MultiSelect = false;
            tbRoles.Name = "tbRoles";
            tbRoles.ReadOnly = true;
            tbRoles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 196, 37);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 201, 57);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            tbRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            tbRoles.RowHeadersWidth = 51;
            tbRoles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbRoles.Size = new Size(884, 395);
            tbRoles.StandardTab = true;
            tbRoles.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Yellow;
            tbRoles.TabIndex = 2;
            tbRoles.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha de registro";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
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
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 128);
            panel1.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.White;
            btnRegistrar.BackgroundImageLayout = ImageLayout.None;
            btnRegistrar.BorderColor = Color.Gold;
            btnRegistrar.BorderThickness = 2;
            btnRegistrar.DrawBorder = true;
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.HotTrackColor = Color.FromArgb(221, 221, 221);
            btnRegistrar.Image = null;
            btnRegistrar.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            btnRegistrar.Location = new Point(10, 86);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.PressedColor = Color.FromArgb(244, 204, 137);
            btnRegistrar.PressedForeColor = Color.White;
            btnRegistrar.Size = new Size(200, 38);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Añadir nuevo rol";
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(884, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Roles de usuarios";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RolView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 523);
            Controls.Add(tbRoles);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RolView";
            Text = "RolView";
            ((System.ComponentModel.ISupportInitialize)tbRoles).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView tbRoles;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Borrar;
        private Panel panel1;
        private ReaLTaiizor.Controls.RoyalButton btnRegistrar;
        private Label lblTitulo;
    }
}