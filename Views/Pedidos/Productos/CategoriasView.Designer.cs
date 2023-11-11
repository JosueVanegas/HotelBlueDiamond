namespace Hotel_Dorado_DesktopApp.Views.Pedidos.Productos
{
    partial class CategoriasView
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
            tbCategoria = new ReaLTaiizor.Controls.PoisonDataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descipcion = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Borrar = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnRegistrar = new ReaLTaiizor.Controls.RoyalButton();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)tbCategoria).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbCategoria
            // 
            tbCategoria.AllowUserToAddRows = false;
            tbCategoria.AllowUserToDeleteRows = false;
            tbCategoria.AllowUserToResizeColumns = false;
            tbCategoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 204, 137);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            tbCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tbCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbCategoria.BackgroundColor = Color.FromArgb(255, 255, 255);
            tbCategoria.BorderStyle = BorderStyle.None;
            tbCategoria.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbCategoria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 196, 37);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 201, 57);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tbCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tbCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbCategoria.Columns.AddRange(new DataGridViewColumn[] { ID, Descipcion, Editar, Borrar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 201, 57);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tbCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            tbCategoria.Dock = DockStyle.Fill;
            tbCategoria.EnableHeadersVisualStyles = false;
            tbCategoria.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCategoria.GridColor = Color.FromArgb(255, 255, 255);
            tbCategoria.Location = new Point(0, 128);
            tbCategoria.Margin = new Padding(3, 2, 3, 2);
            tbCategoria.MultiSelect = false;
            tbCategoria.Name = "tbCategoria";
            tbCategoria.ReadOnly = true;
            tbCategoria.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 196, 37);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 201, 57);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tbCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tbCategoria.RowHeadersWidth = 51;
            tbCategoria.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbCategoria.Size = new Size(999, 379);
            tbCategoria.StandardTab = true;
            tbCategoria.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Yellow;
            tbCategoria.TabIndex = 2;
            tbCategoria.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            tbCategoria.CellContentClick += cellContentClick;
            tbCategoria.CellPainting += cellPainting;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Descipcion
            // 
            Descipcion.HeaderText = "Descripcion";
            Descipcion.MinimumWidth = 6;
            Descipcion.Name = "Descipcion";
            Descipcion.ReadOnly = true;
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
            panel1.Size = new Size(999, 128);
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
            btnRegistrar.Text = "Añadir nueva categoria";
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
            lblTitulo.Size = new Size(999, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Categorias de productos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CategoriasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 507);
            Controls.Add(tbCategoria);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoriasView";
            Text = "CategoriasView";
            ((System.ComponentModel.ISupportInitialize)tbCategoria).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView tbCategoria;
        private Panel panel1;
        private ReaLTaiizor.Controls.RoyalButton btnRegistrar;
        private Label lblTitulo;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descipcion;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Borrar;
    }
}