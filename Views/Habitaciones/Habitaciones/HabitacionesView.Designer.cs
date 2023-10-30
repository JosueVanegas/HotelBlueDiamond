namespace Hotel_Dorado_DesktopApp.Views.Habitaciones
{
    partial class HabitacionesView
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
            lblTitulo = new Label();
            panel1 = new Panel();
            btnRegistrar = new ReaLTaiizor.Controls.RoyalButton();
            tbHabitaciones = new ReaLTaiizor.Controls.PoisonDataGridView();
            ID = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Tarifa = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Borrar = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbHabitaciones).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1205, 66);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Habitaciones";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1205, 159);
            panel1.TabIndex = 5;
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
            btnRegistrar.Location = new Point(3, 103);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.PressedColor = Color.FromArgb(244, 204, 137);
            btnRegistrar.PressedForeColor = Color.White;
            btnRegistrar.Size = new Size(229, 50);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Añadir nueva habitación";
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbHabitaciones
            // 
            tbHabitaciones.AllowUserToAddRows = false;
            tbHabitaciones.AllowUserToDeleteRows = false;
            tbHabitaciones.AllowUserToResizeColumns = false;
            tbHabitaciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 204, 137);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            tbHabitaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tbHabitaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbHabitaciones.BackgroundColor = Color.FromArgb(255, 255, 255);
            tbHabitaciones.BorderStyle = BorderStyle.None;
            tbHabitaciones.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbHabitaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 196, 37);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 201, 57);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tbHabitaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tbHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbHabitaciones.Columns.AddRange(new DataGridViewColumn[] { ID, Numero, Categoria, Email, Tarifa, Editar, Borrar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 201, 57);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tbHabitaciones.DefaultCellStyle = dataGridViewCellStyle3;
            tbHabitaciones.Dock = DockStyle.Fill;
            tbHabitaciones.EnableHeadersVisualStyles = false;
            tbHabitaciones.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbHabitaciones.GridColor = Color.FromArgb(255, 255, 255);
            tbHabitaciones.Location = new Point(0, 159);
            tbHabitaciones.MultiSelect = false;
            tbHabitaciones.Name = "tbHabitaciones";
            tbHabitaciones.ReadOnly = true;
            tbHabitaciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 196, 37);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 201, 57);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tbHabitaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tbHabitaciones.RowHeadersWidth = 51;
            tbHabitaciones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbHabitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbHabitaciones.Size = new Size(1205, 543);
            tbHabitaciones.StandardTab = true;
            tbHabitaciones.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Yellow;
            tbHabitaciones.TabIndex = 4;
            tbHabitaciones.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            tbHabitaciones.CellContentClick += cellContentClick;
            tbHabitaciones.CellPainting += cellPainting;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Numero
            // 
            Numero.HeaderText = "# Habitación";
            Numero.MinimumWidth = 6;
            Numero.Name = "Numero";
            Numero.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Piso";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Tarifa
            // 
            Tarifa.HeaderText = "Tarifa por noche";
            Tarifa.MinimumWidth = 6;
            Tarifa.Name = "Tarifa";
            Tarifa.ReadOnly = true;
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
            // HabitacionesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 702);
            Controls.Add(tbHabitaciones);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HabitacionesView";
            Text = "HabitacionesView";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbHabitaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private ReaLTaiizor.Controls.RoyalButton btnRegistrar;
        private ReaLTaiizor.Controls.PoisonDataGridView tbHabitaciones;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Tarifa;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Borrar;
    }
}