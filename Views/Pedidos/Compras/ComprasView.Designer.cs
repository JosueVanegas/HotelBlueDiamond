namespace Hotel.Views.Pedidos.Compras
{
    partial class ComprasView
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
            label4 = new Label();
            label3 = new Label();
            tbDetalles = new ReaLTaiizor.Controls.PoisonDataGridView();
            ID = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Agregar = new DataGridViewButtonColumn();
            Quitar = new DataGridViewButtonColumn();
            Borrar = new DataGridViewButtonColumn();
            label1 = new Label();
            panelCarousel = new FlowLayoutPanel();
            btnGuardar = new ReaLTaiizor.Controls.MaterialButton();
            txtTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbDetalles).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(973, 32);
            label4.TabIndex = 67;
            label4.Text = "Información de la compra";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(0, 196);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(973, 39);
            label3.TabIndex = 66;
            label3.Text = "Detalles de compra";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbDetalles
            // 
            tbDetalles.AllowUserToAddRows = false;
            tbDetalles.AllowUserToDeleteRows = false;
            tbDetalles.AllowUserToResizeColumns = false;
            tbDetalles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 204, 137);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            tbDetalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tbDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbDetalles.BackgroundColor = Color.FromArgb(255, 255, 255);
            tbDetalles.BorderStyle = BorderStyle.None;
            tbDetalles.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbDetalles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tbDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tbDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbDetalles.Columns.AddRange(new DataGridViewColumn[] { ID, Producto, Estado, Precio, Cantidad, Subtotal, Agregar, Quitar, Borrar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tbDetalles.DefaultCellStyle = dataGridViewCellStyle3;
            tbDetalles.Dock = DockStyle.Bottom;
            tbDetalles.EnableHeadersVisualStyles = false;
            tbDetalles.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDetalles.GridColor = Color.FromArgb(255, 255, 255);
            tbDetalles.Location = new Point(0, 235);
            tbDetalles.Margin = new Padding(3, 2, 3, 2);
            tbDetalles.MultiSelect = false;
            tbDetalles.Name = "tbDetalles";
            tbDetalles.ReadOnly = true;
            tbDetalles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tbDetalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tbDetalles.RowHeadersWidth = 51;
            tbDetalles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbDetalles.Size = new Size(973, 127);
            tbDetalles.StandardTab = true;
            tbDetalles.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            tbDetalles.TabIndex = 65;
            tbDetalles.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            tbDetalles.CellContentClick += cellContentClick;
            tbDetalles.CellPainting += cellPainting;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Descripción";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Categoria";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio unitario";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // Agregar
            // 
            Agregar.HeaderText = "Agregar";
            Agregar.MinimumWidth = 6;
            Agregar.Name = "Agregar";
            Agregar.ReadOnly = true;
            // 
            // Quitar
            // 
            Quitar.HeaderText = "Quitar";
            Quitar.Name = "Quitar";
            Quitar.ReadOnly = true;
            // 
            // Borrar
            // 
            Borrar.HeaderText = "Borrar";
            Borrar.MinimumWidth = 6;
            Borrar.Name = "Borrar";
            Borrar.ReadOnly = true;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(0, 362);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(973, 39);
            label1.TabIndex = 64;
            label1.Text = "Lista de productos existentes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCarousel
            // 
            panelCarousel.AutoScroll = true;
            panelCarousel.BackColor = Color.Beige;
            panelCarousel.Dock = DockStyle.Bottom;
            panelCarousel.Location = new Point(0, 401);
            panelCarousel.Margin = new Padding(0);
            panelCarousel.Name = "panelCarousel";
            panelCarousel.Size = new Size(973, 183);
            panelCarousel.TabIndex = 63;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSize = false;
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.BackColor = Color.Black;
            btnGuardar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnGuardar.Location = new Point(335, 88);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(311, 48);
            btnGuardar.TabIndex = 69;
            btnGuardar.Text = "Finalizar compra";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTotal
            // 
            txtTotal.AnimateReadOnly = false;
            txtTotal.AutoCompleteMode = AutoCompleteMode.None;
            txtTotal.AutoCompleteSource = AutoCompleteSource.None;
            txtTotal.BackgroundImageLayout = ImageLayout.None;
            txtTotal.CharacterCasing = CharacterCasing.Normal;
            txtTotal.Depth = 0;
            txtTotal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTotal.HideSelection = true;
            txtTotal.Hint = "Total en compra:";
            txtTotal.LeadingIcon = null;
            txtTotal.Location = new Point(335, 34);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.MaxLength = 32767;
            txtTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTotal.Name = "txtTotal";
            txtTotal.PasswordChar = '\0';
            txtTotal.PrefixSuffixText = null;
            txtTotal.ReadOnly = true;
            txtTotal.RightToLeft = RightToLeft.No;
            txtTotal.SelectedText = "";
            txtTotal.SelectionLength = 0;
            txtTotal.SelectionStart = 0;
            txtTotal.ShortcutsEnabled = true;
            txtTotal.Size = new Size(311, 48);
            txtTotal.TabIndex = 68;
            txtTotal.TabStop = false;
            txtTotal.TextAlign = HorizontalAlignment.Left;
            txtTotal.TrailingIcon = null;
            txtTotal.UseAccent = false;
            txtTotal.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(335, 138);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(311, 48);
            label2.TabIndex = 70;
            label2.Text = "*El usuario actual quedará registrado como la persona que realizo la compra.*\r\n\r\n";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ComprasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 584);
            Controls.Add(label2);
            Controls.Add(btnGuardar);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbDetalles);
            Controls.Add(label1);
            Controls.Add(panelCarousel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ComprasView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComprasView";
            ((System.ComponentModel.ISupportInitialize)tbDetalles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Label label3;
        private ReaLTaiizor.Controls.PoisonDataGridView tbDetalles;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewButtonColumn Agregar;
        private DataGridViewButtonColumn Quitar;
        private DataGridViewButtonColumn Borrar;
        private Label label1;
        private FlowLayoutPanel panelCarousel;
        private ReaLTaiizor.Controls.MaterialButton btnGuardar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTotal;
        private Label label2;
    }
}