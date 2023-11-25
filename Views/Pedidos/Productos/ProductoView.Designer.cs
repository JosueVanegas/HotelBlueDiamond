namespace Hotel.Views.Pedidos.Productos
{
    partial class ProductoView
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tbProductos = new ReaLTaiizor.Controls.PoisonDataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descipcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Borrar = new DataGridViewButtonColumn();
            panel1 = new Panel();
            lblTitulo = new Label();
            btnAgregar = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)tbProductos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbProductos
            // 
            tbProductos.AllowUserToAddRows = false;
            tbProductos.AllowUserToDeleteRows = false;
            tbProductos.AllowUserToResizeColumns = false;
            tbProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(244, 204, 137);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            tbProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            tbProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbProductos.BackgroundColor = Color.FromArgb(255, 255, 255);
            tbProductos.BorderStyle = BorderStyle.None;
            tbProductos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            tbProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            tbProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Descipcion, Precio, Column1, Categoria, Column2, Editar, Borrar });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            tbProductos.DefaultCellStyle = dataGridViewCellStyle11;
            tbProductos.Dock = DockStyle.Fill;
            tbProductos.EnableHeadersVisualStyles = false;
            tbProductos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbProductos.GridColor = Color.FromArgb(255, 255, 255);
            tbProductos.Location = new Point(0, 128);
            tbProductos.Margin = new Padding(3, 2, 3, 2);
            tbProductos.MultiSelect = false;
            tbProductos.Name = "tbProductos";
            tbProductos.ReadOnly = true;
            tbProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            tbProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            tbProductos.RowHeadersWidth = 51;
            tbProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbProductos.Size = new Size(800, 322);
            tbProductos.StandardTab = true;
            tbProductos.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            tbProductos.TabIndex = 4;
            tbProductos.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            tbProductos.CellContentClick += cellContentClick;
            tbProductos.CellPainting += cellPainting;
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
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Stock";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Proveedor";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
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
            panel1.Size = new Size(800, 128);
            panel1.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(800, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Productos";
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
            btnAgregar.Text = "Registrar nuevo producto";
            btnAgregar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregar.UseAccentColor = false;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnRegistrar_Click;
            // 
            // ProductoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbProductos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductoView";
            Text = "ProductoView";
            ((System.ComponentModel.ISupportInitialize)tbProductos).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView tbProductos;
        private Panel panel1;
        private Label lblTitulo;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descipcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Borrar;
        private ReaLTaiizor.Controls.MaterialButton btnAgregar;
    }
}