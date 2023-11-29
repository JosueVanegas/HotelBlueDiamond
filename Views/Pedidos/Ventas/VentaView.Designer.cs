namespace Hotel.Views.Pedidos.Ventas
{
    partial class VentaView
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
            panelCarousel = new FlowLayoutPanel();
            label1 = new Label();
            panelHabitaciones = new FlowLayoutPanel();
            label2 = new Label();
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
            label3 = new Label();
            txtNumero = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCategoria = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPiso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label4 = new Label();
            txtCedula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtApellido = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnGuardar = new ReaLTaiizor.Controls.MaterialButton();
            ckbCancelado = new ReaLTaiizor.Controls.MaterialCheckBox();
            txtTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)tbDetalles).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelCarousel
            // 
            panelCarousel.AutoScroll = true;
            panelCarousel.BackColor = Color.Beige;
            panelCarousel.Dock = DockStyle.Bottom;
            panelCarousel.Location = new Point(0, 648);
            panelCarousel.Margin = new Padding(0);
            panelCarousel.Name = "panelCarousel";
            panelCarousel.Size = new Size(1029, 167);
            panelCarousel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(0, 609);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(1029, 39);
            label1.TabIndex = 1;
            label1.Text = "Lista de productos existentes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHabitaciones
            // 
            panelHabitaciones.AutoScroll = true;
            panelHabitaciones.BackColor = Color.Beige;
            panelHabitaciones.Dock = DockStyle.Bottom;
            panelHabitaciones.Location = new Point(0, 459);
            panelHabitaciones.Margin = new Padding(0);
            panelHabitaciones.Name = "panelHabitaciones";
            panelHabitaciones.Size = new Size(1029, 150);
            panelHabitaciones.TabIndex = 2;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(0, 420);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(1029, 39);
            label2.TabIndex = 3;
            label2.Text = "Lista de habitaciónes ocupadas";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            tbDetalles.Location = new Point(0, 290);
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
            tbDetalles.Size = new Size(1029, 130);
            tbDetalles.StandardTab = true;
            tbDetalles.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            tbDetalles.TabIndex = 57;
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
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(0, 250);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(1029, 40);
            label3.TabIndex = 58;
            label3.Text = "Detalles del pedido";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNumero
            // 
            txtNumero.AnimateReadOnly = false;
            txtNumero.AutoCompleteMode = AutoCompleteMode.None;
            txtNumero.AutoCompleteSource = AutoCompleteSource.None;
            txtNumero.BackgroundImageLayout = ImageLayout.None;
            txtNumero.CharacterCasing = CharacterCasing.Normal;
            txtNumero.Depth = 0;
            txtNumero.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNumero.HideSelection = true;
            txtNumero.Hint = "Numero de habitación:";
            txtNumero.LeadingIcon = null;
            txtNumero.Location = new Point(14, 18);
            txtNumero.Margin = new Padding(3, 2, 3, 2);
            txtNumero.MaxLength = 32767;
            txtNumero.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNumero.Name = "txtNumero";
            txtNumero.PasswordChar = '\0';
            txtNumero.PrefixSuffixText = null;
            txtNumero.ReadOnly = true;
            txtNumero.RightToLeft = RightToLeft.No;
            txtNumero.SelectedText = "";
            txtNumero.SelectionLength = 0;
            txtNumero.SelectionStart = 0;
            txtNumero.ShortcutsEnabled = true;
            txtNumero.Size = new Size(312, 48);
            txtNumero.TabIndex = 59;
            txtNumero.TabStop = false;
            txtNumero.TextAlign = HorizontalAlignment.Left;
            txtNumero.TrailingIcon = null;
            txtNumero.UseAccent = false;
            txtNumero.UseSystemPasswordChar = false;
            // 
            // txtCategoria
            // 
            txtCategoria.AnimateReadOnly = false;
            txtCategoria.AutoCompleteMode = AutoCompleteMode.None;
            txtCategoria.AutoCompleteSource = AutoCompleteSource.None;
            txtCategoria.BackgroundImageLayout = ImageLayout.None;
            txtCategoria.CharacterCasing = CharacterCasing.Normal;
            txtCategoria.Depth = 0;
            txtCategoria.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCategoria.HideSelection = true;
            txtCategoria.Hint = "Categoria:";
            txtCategoria.LeadingIcon = null;
            txtCategoria.Location = new Point(332, 18);
            txtCategoria.Margin = new Padding(3, 2, 3, 2);
            txtCategoria.MaxLength = 32767;
            txtCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.PasswordChar = '\0';
            txtCategoria.PrefixSuffixText = null;
            txtCategoria.ReadOnly = true;
            txtCategoria.RightToLeft = RightToLeft.No;
            txtCategoria.SelectedText = "";
            txtCategoria.SelectionLength = 0;
            txtCategoria.SelectionStart = 0;
            txtCategoria.ShortcutsEnabled = true;
            txtCategoria.Size = new Size(325, 48);
            txtCategoria.TabIndex = 60;
            txtCategoria.TabStop = false;
            txtCategoria.TextAlign = HorizontalAlignment.Left;
            txtCategoria.TrailingIcon = null;
            txtCategoria.UseAccent = false;
            txtCategoria.UseSystemPasswordChar = false;
            // 
            // txtPiso
            // 
            txtPiso.AnimateReadOnly = false;
            txtPiso.AutoCompleteMode = AutoCompleteMode.None;
            txtPiso.AutoCompleteSource = AutoCompleteSource.None;
            txtPiso.BackgroundImageLayout = ImageLayout.None;
            txtPiso.CharacterCasing = CharacterCasing.Normal;
            txtPiso.Depth = 0;
            txtPiso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPiso.HideSelection = true;
            txtPiso.Hint = "Piso:";
            txtPiso.LeadingIcon = null;
            txtPiso.Location = new Point(663, 18);
            txtPiso.Margin = new Padding(3, 2, 3, 2);
            txtPiso.MaxLength = 32767;
            txtPiso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPiso.Name = "txtPiso";
            txtPiso.PasswordChar = '\0';
            txtPiso.PrefixSuffixText = null;
            txtPiso.ReadOnly = true;
            txtPiso.RightToLeft = RightToLeft.No;
            txtPiso.SelectedText = "";
            txtPiso.SelectionLength = 0;
            txtPiso.SelectionStart = 0;
            txtPiso.ShortcutsEnabled = true;
            txtPiso.Size = new Size(325, 48);
            txtPiso.TabIndex = 61;
            txtPiso.TabStop = false;
            txtPiso.TextAlign = HorizontalAlignment.Left;
            txtPiso.TrailingIcon = null;
            txtPiso.UseAccent = false;
            txtPiso.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(1029, 32);
            label4.TabIndex = 62;
            label4.Text = "Información de la habitación";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCedula
            // 
            txtCedula.AnimateReadOnly = false;
            txtCedula.AutoCompleteMode = AutoCompleteMode.None;
            txtCedula.AutoCompleteSource = AutoCompleteSource.None;
            txtCedula.BackgroundImageLayout = ImageLayout.None;
            txtCedula.CharacterCasing = CharacterCasing.Normal;
            txtCedula.Depth = 0;
            txtCedula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCedula.HideSelection = true;
            txtCedula.Hint = "Cedula";
            txtCedula.LeadingIcon = null;
            txtCedula.Location = new Point(14, 70);
            txtCedula.Margin = new Padding(3, 2, 3, 2);
            txtCedula.MaxLength = 32767;
            txtCedula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCedula.Name = "txtCedula";
            txtCedula.PasswordChar = '\0';
            txtCedula.PrefixSuffixText = null;
            txtCedula.ReadOnly = true;
            txtCedula.RightToLeft = RightToLeft.No;
            txtCedula.SelectedText = "";
            txtCedula.SelectionLength = 0;
            txtCedula.SelectionStart = 0;
            txtCedula.ShortcutsEnabled = true;
            txtCedula.Size = new Size(312, 48);
            txtCedula.TabIndex = 65;
            txtCedula.TabStop = false;
            txtCedula.TextAlign = HorizontalAlignment.Left;
            txtCedula.TrailingIcon = null;
            txtCedula.UseAccent = false;
            txtCedula.UseSystemPasswordChar = false;
            // 
            // txtApellido
            // 
            txtApellido.AnimateReadOnly = false;
            txtApellido.AutoCompleteMode = AutoCompleteMode.None;
            txtApellido.AutoCompleteSource = AutoCompleteSource.None;
            txtApellido.BackgroundImageLayout = ImageLayout.None;
            txtApellido.CharacterCasing = CharacterCasing.Normal;
            txtApellido.Depth = 0;
            txtApellido.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtApellido.HideSelection = true;
            txtApellido.Hint = "Apellidos";
            txtApellido.LeadingIcon = null;
            txtApellido.Location = new Point(663, 70);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.MaxLength = 32767;
            txtApellido.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtApellido.Name = "txtApellido";
            txtApellido.PasswordChar = '\0';
            txtApellido.PrefixSuffixText = null;
            txtApellido.ReadOnly = true;
            txtApellido.RightToLeft = RightToLeft.No;
            txtApellido.SelectedText = "";
            txtApellido.SelectionLength = 0;
            txtApellido.SelectionStart = 0;
            txtApellido.ShortcutsEnabled = true;
            txtApellido.Size = new Size(325, 48);
            txtApellido.TabIndex = 64;
            txtApellido.TabStop = false;
            txtApellido.TextAlign = HorizontalAlignment.Left;
            txtApellido.TrailingIcon = null;
            txtApellido.UseAccent = false;
            txtApellido.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.AutoCompleteMode = AutoCompleteMode.None;
            txtNombre.AutoCompleteSource = AutoCompleteSource.None;
            txtNombre.BackgroundImageLayout = ImageLayout.None;
            txtNombre.CharacterCasing = CharacterCasing.Normal;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.HideSelection = true;
            txtNombre.Hint = "Nombres";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(332, 70);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.MaxLength = 32767;
            txtNombre.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.PrefixSuffixText = null;
            txtNombre.ReadOnly = true;
            txtNombre.RightToLeft = RightToLeft.No;
            txtNombre.SelectedText = "";
            txtNombre.SelectionLength = 0;
            txtNombre.SelectionStart = 0;
            txtNombre.ShortcutsEnabled = true;
            txtNombre.Size = new Size(325, 48);
            txtNombre.TabIndex = 63;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.TrailingIcon = null;
            txtNombre.UseAccent = false;
            txtNombre.UseSystemPasswordChar = false;
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
            btnGuardar.Location = new Point(14, 122);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(311, 48);
            btnGuardar.TabIndex = 66;
            btnGuardar.Text = "Realizar venta";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // ckbCancelado
            // 
            ckbCancelado.Depth = 0;
            ckbCancelado.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ckbCancelado.Location = new Point(663, 122);
            ckbCancelado.Margin = new Padding(0);
            ckbCancelado.MouseLocation = new Point(-1, -1);
            ckbCancelado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ckbCancelado.Name = "ckbCancelado";
            ckbCancelado.ReadOnly = false;
            ckbCancelado.Ripple = true;
            ckbCancelado.Size = new Size(325, 37);
            ckbCancelado.TabIndex = 67;
            ckbCancelado.Text = "¿el pedido ha sido cancelado?";
            ckbCancelado.TextAlign = ContentAlignment.MiddleCenter;
            ckbCancelado.UseAccentColor = false;
            ckbCancelado.UseVisualStyleBackColor = true;
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
            txtTotal.Hint = "Total a pagar";
            txtTotal.LeadingIcon = null;
            txtTotal.Location = new Point(332, 122);
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
            txtTotal.Size = new Size(325, 48);
            txtTotal.TabIndex = 68;
            txtTotal.TabStop = false;
            txtTotal.TextAlign = HorizontalAlignment.Left;
            txtTotal.TrailingIcon = null;
            txtTotal.UseAccent = false;
            txtTotal.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCategoria);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(txtPiso);
            panel1.Controls.Add(ckbCancelado);
            panel1.Controls.Add(txtNumero);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtCedula);
            panel1.Controls.Add(txtApellido);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 203);
            panel1.TabIndex = 69;
            // 
            // VentaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1029, 815);
            Controls.Add(label3);
            Controls.Add(tbDetalles);
            Controls.Add(label2);
            Controls.Add(panelHabitaciones);
            Controls.Add(label1);
            Controls.Add(panelCarousel);
            Controls.Add(panel1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentaView";
            Text = "VentaView";
            ((System.ComponentModel.ISupportInitialize)tbDetalles).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelCarousel;
        private Label label1;
        private FlowLayoutPanel panelHabitaciones;
        private Label label2;
        private ReaLTaiizor.Controls.PoisonDataGridView tbDetalles;
        private Label label3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNumero;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCategoria;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPiso;
        private Label label4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCedula;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtApellido;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombre;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewButtonColumn Agregar;
        private DataGridViewButtonColumn Quitar;
        private DataGridViewButtonColumn Borrar;
        private ReaLTaiizor.Controls.MaterialButton btnGuardar;
        private ReaLTaiizor.Controls.MaterialCheckBox ckbCancelado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTotal;
        private Panel panel1;
    }
}