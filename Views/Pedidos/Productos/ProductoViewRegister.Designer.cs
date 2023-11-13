namespace Hotel.Views.Pedidos.Productos
{
    partial class ProductoViewRegister
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
            panel1 = new Panel();
            cbxCategorias = new ReaLTaiizor.Controls.MaterialComboBox();
            lblTitulo = new Label();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnGuardar = new ReaLTaiizor.Controls.MaterialButton();
            txtPrecio = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxProveedores = new ReaLTaiizor.Controls.MaterialComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(cbxProveedores);
            panel1.Controls.Add(cbxCategorias);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtNombre);
            panel1.Location = new Point(12, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 444);
            panel1.TabIndex = 4;
            // 
            // cbxCategorias
            // 
            cbxCategorias.AutoResize = false;
            cbxCategorias.BackColor = Color.FromArgb(255, 255, 255);
            cbxCategorias.Depth = 0;
            cbxCategorias.DrawMode = DrawMode.OwnerDrawVariable;
            cbxCategorias.DropDownHeight = 174;
            cbxCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategorias.DropDownWidth = 121;
            cbxCategorias.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxCategorias.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxCategorias.FormattingEnabled = true;
            cbxCategorias.Hint = "Seleccione la categoria del producto";
            cbxCategorias.IntegralHeight = false;
            cbxCategorias.ItemHeight = 43;
            cbxCategorias.Location = new Point(15, 199);
            cbxCategorias.MaxDropDownItems = 4;
            cbxCategorias.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxCategorias.Name = "cbxCategorias";
            cbxCategorias.Size = new Size(436, 49);
            cbxCategorias.StartIndex = 0;
            cbxCategorias.TabIndex = 6;
            cbxCategorias.UseAccent = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(15, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(436, 74);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Registrar producto";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = false;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.BackColor = Color.Black;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(151, 401);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(173, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
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
            btnGuardar.Location = new Point(151, 359);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(173, 34);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.AnimateReadOnly = false;
            txtPrecio.AutoCompleteMode = AutoCompleteMode.None;
            txtPrecio.AutoCompleteSource = AutoCompleteSource.None;
            txtPrecio.BackgroundImageLayout = ImageLayout.None;
            txtPrecio.CharacterCasing = CharacterCasing.Normal;
            txtPrecio.Depth = 0;
            txtPrecio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecio.HideSelection = true;
            txtPrecio.Hint = "Precio";
            txtPrecio.LeadingIcon = null;
            txtPrecio.Location = new Point(15, 146);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.MaxLength = 32767;
            txtPrecio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PasswordChar = '\0';
            txtPrecio.PrefixSuffixText = null;
            txtPrecio.ReadOnly = false;
            txtPrecio.RightToLeft = RightToLeft.No;
            txtPrecio.SelectedText = "";
            txtPrecio.SelectionLength = 0;
            txtPrecio.SelectionStart = 0;
            txtPrecio.ShortcutsEnabled = true;
            txtPrecio.Size = new Size(436, 48);
            txtPrecio.TabIndex = 1;
            txtPrecio.TabStop = false;
            txtPrecio.TextAlign = HorizontalAlignment.Left;
            txtPrecio.TrailingIcon = null;
            txtPrecio.UseAccent = false;
            txtPrecio.UseSystemPasswordChar = false;
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
            txtNombre.Hint = "Nombre del producto";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(15, 94);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.MaxLength = 32767;
            txtNombre.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.PrefixSuffixText = null;
            txtNombre.ReadOnly = false;
            txtNombre.RightToLeft = RightToLeft.No;
            txtNombre.SelectedText = "";
            txtNombre.SelectionLength = 0;
            txtNombre.SelectionStart = 0;
            txtNombre.ShortcutsEnabled = true;
            txtNombre.Size = new Size(436, 48);
            txtNombre.TabIndex = 0;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.TrailingIcon = null;
            txtNombre.UseAccent = false;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // cbxProveedores
            // 
            cbxProveedores.AutoResize = false;
            cbxProveedores.BackColor = Color.FromArgb(255, 255, 255);
            cbxProveedores.Depth = 0;
            cbxProveedores.DrawMode = DrawMode.OwnerDrawVariable;
            cbxProveedores.DropDownHeight = 174;
            cbxProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProveedores.DropDownWidth = 121;
            cbxProveedores.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxProveedores.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxProveedores.FormattingEnabled = true;
            cbxProveedores.Hint = "Seleccione el proveedor";
            cbxProveedores.IntegralHeight = false;
            cbxProveedores.ItemHeight = 43;
            cbxProveedores.Location = new Point(15, 254);
            cbxProveedores.MaxDropDownItems = 4;
            cbxProveedores.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxProveedores.Name = "cbxProveedores";
            cbxProveedores.Size = new Size(436, 49);
            cbxProveedores.StartIndex = 0;
            cbxProveedores.TabIndex = 7;
            cbxProveedores.UseAccent = false;
            // 
            // ProductoViewRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 466);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductoViewRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductoViewRegister";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnGuardar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrecio;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombre;
        private ReaLTaiizor.Controls.MaterialComboBox cbxCategorias;
        private ReaLTaiizor.Controls.MaterialComboBox cbxProveedores;
    }
}