namespace Hotel_Dorado_DesktopApp.Views.Habitaciones
{
    partial class CategoriasHabitacionView
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
            tbCategorias = new ReaLTaiizor.Controls.PoisonDataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Borrar = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1206, 66);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Categorias de habitaciones";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 159);
            panel1.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.White;
            btnRegistrar.BackgroundImageLayout = ImageLayout.None;
            btnRegistrar.BorderColor = Color.ForestGreen;
            btnRegistrar.BorderThickness = 2;
            btnRegistrar.DrawBorder = true;
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.HotTrackColor = Color.FromArgb(221, 221, 221);
            btnRegistrar.Image = null;
            btnRegistrar.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            btnRegistrar.Location = new Point(283, 83);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.PressedColor = Color.FromArgb(244, 204, 137);
            btnRegistrar.PressedForeColor = Color.White;
            btnRegistrar.Size = new Size(229, 50);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Añadir nueva categoria";
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbCategorias
            // 
            tbCategorias.AllowUserToAddRows = false;
            tbCategorias.AllowUserToDeleteRows = false;
            tbCategorias.AllowUserToResizeColumns = false;
            tbCategorias.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 204, 137);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            tbCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tbCategorias.BackgroundColor = Color.FromArgb(255, 255, 255);
            tbCategorias.BorderStyle = BorderStyle.None;
            tbCategorias.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 177, 89);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tbCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tbCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbCategorias.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Cantidad, Editar, Borrar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tbCategorias.DefaultCellStyle = dataGridViewCellStyle3;
            tbCategorias.EnableHeadersVisualStyles = false;
            tbCategorias.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCategorias.GridColor = Color.FromArgb(255, 255, 255);
            tbCategorias.Location = new Point(283, 181);
            tbCategorias.MultiSelect = false;
            tbCategorias.Name = "tbCategorias";
            tbCategorias.ReadOnly = true;
            tbCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 177, 89);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tbCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tbCategorias.RowHeadersWidth = 51;
            tbCategorias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbCategorias.Size = new Size(632, 425);
            tbCategorias.StandardTab = true;
            tbCategorias.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            tbCategorias.TabIndex = 4;
            tbCategorias.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            tbCategorias.CellContentClick += cellContentClick;
            tbCategorias.CellPainting += cellPainting;
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
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 200;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad de huéspedes permitida";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 300;
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
            // CategoriasHabitacionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 714);
            Controls.Add(panel1);
            Controls.Add(tbCategorias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoriasHabitacionView";
            Text = "CategoriasHabitacionView";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private ReaLTaiizor.Controls.RoyalButton btnRegistrar;
        private ReaLTaiizor.Controls.PoisonDataGridView tbCategorias;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Borrar;
    }
}