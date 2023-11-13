namespace Hotel.Views.GestionView
{
    partial class ReceptionView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionView));
            panel1 = new Panel();
            txtCancelar = new ReaLTaiizor.Controls.MaterialButton();
            dtSalida = new ReaLTaiizor.Controls.PoisonDateTime();
            txtCantidad = new NumericUpDown();
            label6 = new Label();
            dtpEntrada = new Label();
            txtAdelanto = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label5 = new Label();
            label4 = new Label();
            btnNuevoCliente = new ReaLTaiizor.Controls.MaterialButton();
            cbxCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblDetalles = new Label();
            txtExtras = new ReaLTaiizor.Controls.RichTextBoxEdit();
            txtDetalles = new ReaLTaiizor.Controls.RichTextBoxEdit();
            btnReservar = new ReaLTaiizor.Controls.MaterialButton();
            txtCapacidad = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPrecioPH = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPiso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCategoria = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEstado = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNumero = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(txtCancelar);
            panel1.Controls.Add(dtSalida);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtpEntrada);
            panel1.Controls.Add(txtAdelanto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnNuevoCliente);
            panel1.Controls.Add(cbxCliente);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblDetalles);
            panel1.Controls.Add(txtExtras);
            panel1.Controls.Add(txtDetalles);
            panel1.Controls.Add(btnReservar);
            panel1.Controls.Add(txtCapacidad);
            panel1.Controls.Add(txtPrecioPH);
            panel1.Controls.Add(txtPiso);
            panel1.Controls.Add(txtCategoria);
            panel1.Controls.Add(txtEstado);
            panel1.Controls.Add(txtNumero);
            panel1.Location = new Point(12, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 496);
            panel1.TabIndex = 2;
            // 
            // txtCancelar
            // 
            txtCancelar.AutoSize = false;
            txtCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            txtCancelar.Depth = 0;
            txtCancelar.HighEmphasis = true;
            txtCancelar.Icon = null;
            txtCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            txtCancelar.Location = new Point(571, 431);
            txtCancelar.Margin = new Padding(4);
            txtCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtCancelar.Name = "txtCancelar";
            txtCancelar.NoAccentTextColor = Color.Empty;
            txtCancelar.Size = new Size(272, 50);
            txtCancelar.TabIndex = 32;
            txtCancelar.Text = "Cancelar";
            txtCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            txtCancelar.UseAccentColor = true;
            txtCancelar.UseVisualStyleBackColor = true;
            txtCancelar.Click += txtCancelar_Click;
            // 
            // dtSalida
            // 
            dtSalida.Location = new Point(422, 126);
            dtSalida.MinDate = new DateTime(2023, 10, 31, 0, 0, 0, 0);
            dtSalida.MinimumSize = new Size(0, 29);
            dtSalida.Name = "dtSalida";
            dtSalida.Size = new Size(418, 29);
            dtSalida.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Yellow;
            dtSalida.TabIndex = 30;
            dtSalida.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            dtSalida.Value = new DateTime(2023, 10, 31, 18, 15, 46, 0);
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.Beige;
            txtCantidad.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.Location = new Point(297, 166);
            txtCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(61, 43);
            txtCantidad.TabIndex = 31;
            txtCantidad.TextAlign = HorizontalAlignment.Center;
            txtCantidad.UpDownAlign = LeftRightAlignment.Left;
            txtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(7, 162);
            label6.Name = "label6";
            label6.Size = new Size(278, 48);
            label6.TabIndex = 29;
            label6.Text = "Cantidad de huespedes:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpEntrada
            // 
            dtpEntrada.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEntrada.ForeColor = Color.DimGray;
            dtpEntrada.Location = new Point(173, 126);
            dtpEntrada.Name = "dtpEntrada";
            dtpEntrada.Size = new Size(80, 28);
            dtpEntrada.TabIndex = 25;
            dtpEntrada.Text = "Hoy";
            dtpEntrada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAdelanto
            // 
            txtAdelanto.AnimateReadOnly = false;
            txtAdelanto.AutoCompleteMode = AutoCompleteMode.None;
            txtAdelanto.AutoCompleteSource = AutoCompleteSource.None;
            txtAdelanto.BackgroundImageLayout = ImageLayout.None;
            txtAdelanto.CharacterCasing = CharacterCasing.Normal;
            txtAdelanto.Depth = 0;
            txtAdelanto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAdelanto.HideSelection = true;
            txtAdelanto.Hint = "Adelanto:";
            txtAdelanto.LeadingIcon = null;
            txtAdelanto.Location = new Point(364, 162);
            txtAdelanto.Margin = new Padding(3, 2, 3, 2);
            txtAdelanto.MaxLength = 32767;
            txtAdelanto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAdelanto.Name = "txtAdelanto";
            txtAdelanto.PasswordChar = '\0';
            txtAdelanto.PrefixSuffixText = null;
            txtAdelanto.ReadOnly = false;
            txtAdelanto.RightToLeft = RightToLeft.No;
            txtAdelanto.SelectedText = "";
            txtAdelanto.SelectionLength = 0;
            txtAdelanto.SelectionStart = 0;
            txtAdelanto.ShortcutsEnabled = true;
            txtAdelanto.Size = new Size(180, 48);
            txtAdelanto.TabIndex = 21;
            txtAdelanto.TabStop = false;
            txtAdelanto.Text = "0.00";
            txtAdelanto.TextAlign = HorizontalAlignment.Left;
            txtAdelanto.TrailingIcon = null;
            txtAdelanto.UseAccent = false;
            txtAdelanto.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(259, 126);
            label5.Name = "label5";
            label5.Size = new Size(157, 28);
            label5.TabIndex = 20;
            label5.Text = "Fecha de salida:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(11, 126);
            label4.Name = "label4";
            label4.Size = new Size(157, 28);
            label4.TabIndex = 19;
            label4.Text = "Fecha de entrada:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.AutoSize = false;
            btnNuevoCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNuevoCliente.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnNuevoCliente.Depth = 0;
            btnNuevoCliente.HighEmphasis = true;
            btnNuevoCliente.Icon = null;
            btnNuevoCliente.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNuevoCliente.Location = new Point(665, 66);
            btnNuevoCliente.Margin = new Padding(4);
            btnNuevoCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.NoAccentTextColor = Color.Empty;
            btnNuevoCliente.Size = new Size(175, 49);
            btnNuevoCliente.TabIndex = 16;
            btnNuevoCliente.Text = "Nuevo cliente";
            btnNuevoCliente.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNuevoCliente.UseAccentColor = false;
            btnNuevoCliente.UseVisualStyleBackColor = true;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // cbxCliente
            // 
            cbxCliente.AutoResize = false;
            cbxCliente.BackColor = Color.FromArgb(255, 255, 255);
            cbxCliente.Depth = 0;
            cbxCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cbxCliente.DropDownHeight = 174;
            cbxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCliente.DropDownWidth = 121;
            cbxCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Hint = "Seleccione un cliente";
            cbxCliente.IntegralHeight = false;
            cbxCliente.ItemHeight = 43;
            cbxCliente.Location = new Point(10, 66);
            cbxCliente.Margin = new Padding(3, 2, 3, 2);
            cbxCliente.MaxDropDownItems = 4;
            cbxCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(648, 49);
            cbxCliente.StartIndex = 0;
            cbxCliente.TabIndex = 15;
            cbxCliente.UseAccent = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(11, 9);
            label3.Name = "label3";
            label3.Size = new Size(829, 53);
            label3.TabIndex = 14;
            label3.Text = "Información de la reservación";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(12, 212);
            label2.Name = "label2";
            label2.Size = new Size(828, 32);
            label2.TabIndex = 13;
            label2.Text = "Información de la habitación";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(289, 346);
            label1.Name = "label1";
            label1.Size = new Size(269, 21);
            label1.TabIndex = 12;
            label1.Text = "la Habitación incluye:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDetalles
            // 
            lblDetalles.ForeColor = Color.DimGray;
            lblDetalles.Location = new Point(16, 348);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(269, 19);
            lblDetalles.TabIndex = 11;
            lblDetalles.Text = "Detalles de la habitación:";
            lblDetalles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtExtras
            // 
            txtExtras.AutoWordSelection = false;
            txtExtras.BackColor = Color.White;
            txtExtras.BaseColor = Color.Transparent;
            txtExtras.BorderColor = Color.FromArgb(180, 180, 180);
            txtExtras.EdgeColor = Color.White;
            txtExtras.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtExtras.ForeColor = Color.DimGray;
            txtExtras.Location = new Point(291, 373);
            txtExtras.Margin = new Padding(3, 2, 3, 2);
            txtExtras.Name = "txtExtras";
            txtExtras.ReadOnly = true;
            txtExtras.Size = new Size(273, 108);
            txtExtras.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtExtras.TabIndex = 10;
            txtExtras.TextBackColor = Color.White;
            txtExtras.TextBorderStyle = BorderStyle.None;
            txtExtras.TextFont = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtExtras.WordWrap = true;
            // 
            // txtDetalles
            // 
            txtDetalles.AutoWordSelection = false;
            txtDetalles.BackColor = Color.White;
            txtDetalles.BaseColor = Color.Transparent;
            txtDetalles.BorderColor = Color.FromArgb(180, 180, 180);
            txtDetalles.EdgeColor = Color.White;
            txtDetalles.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetalles.ForeColor = Color.DimGray;
            txtDetalles.Location = new Point(12, 373);
            txtDetalles.Margin = new Padding(3, 2, 3, 2);
            txtDetalles.Name = "txtDetalles";
            txtDetalles.ReadOnly = true;
            txtDetalles.Size = new Size(273, 108);
            txtDetalles.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtDetalles.TabIndex = 9;
            txtDetalles.TextBackColor = Color.White;
            txtDetalles.TextBorderStyle = BorderStyle.None;
            txtDetalles.TextFont = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetalles.WordWrap = true;
            // 
            // btnReservar
            // 
            btnReservar.AutoSize = false;
            btnReservar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReservar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnReservar.Depth = 0;
            btnReservar.HighEmphasis = true;
            btnReservar.Icon = null;
            btnReservar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnReservar.Location = new Point(571, 373);
            btnReservar.Margin = new Padding(4);
            btnReservar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnReservar.Name = "btnReservar";
            btnReservar.NoAccentTextColor = Color.Empty;
            btnReservar.Size = new Size(272, 50);
            btnReservar.TabIndex = 8;
            btnReservar.Text = "Realizar reserva";
            btnReservar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReservar.UseAccentColor = false;
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnReservar_Click;
            // 
            // txtCapacidad
            // 
            txtCapacidad.AnimateReadOnly = false;
            txtCapacidad.AutoCompleteMode = AutoCompleteMode.None;
            txtCapacidad.AutoCompleteSource = AutoCompleteSource.None;
            txtCapacidad.BackgroundImageLayout = ImageLayout.None;
            txtCapacidad.CharacterCasing = CharacterCasing.Normal;
            txtCapacidad.Depth = 0;
            txtCapacidad.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCapacidad.HideSelection = true;
            txtCapacidad.Hint = "Capacidad de huespedes:";
            txtCapacidad.LeadingIcon = null;
            txtCapacidad.Location = new Point(568, 298);
            txtCapacidad.Margin = new Padding(3, 2, 3, 2);
            txtCapacidad.MaxLength = 32767;
            txtCapacidad.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.PasswordChar = '\0';
            txtCapacidad.PrefixSuffixText = null;
            txtCapacidad.ReadOnly = true;
            txtCapacidad.RightToLeft = RightToLeft.No;
            txtCapacidad.SelectedText = "";
            txtCapacidad.SelectionLength = 0;
            txtCapacidad.SelectionStart = 0;
            txtCapacidad.ShortcutsEnabled = true;
            txtCapacidad.Size = new Size(273, 48);
            txtCapacidad.TabIndex = 7;
            txtCapacidad.TabStop = false;
            txtCapacidad.TextAlign = HorizontalAlignment.Left;
            txtCapacidad.TrailingIcon = null;
            txtCapacidad.UseAccent = false;
            txtCapacidad.UseSystemPasswordChar = false;
            // 
            // txtPrecioPH
            // 
            txtPrecioPH.AnimateReadOnly = false;
            txtPrecioPH.AutoCompleteMode = AutoCompleteMode.None;
            txtPrecioPH.AutoCompleteSource = AutoCompleteSource.None;
            txtPrecioPH.BackgroundImageLayout = ImageLayout.None;
            txtPrecioPH.CharacterCasing = CharacterCasing.Normal;
            txtPrecioPH.Depth = 0;
            txtPrecioPH.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecioPH.HideSelection = true;
            txtPrecioPH.Hint = "Precio por noche:";
            txtPrecioPH.LeadingIcon = null;
            txtPrecioPH.Location = new Point(289, 298);
            txtPrecioPH.Margin = new Padding(3, 2, 3, 2);
            txtPrecioPH.MaxLength = 32767;
            txtPrecioPH.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrecioPH.Name = "txtPrecioPH";
            txtPrecioPH.PasswordChar = '\0';
            txtPrecioPH.PrefixSuffixText = null;
            txtPrecioPH.ReadOnly = false;
            txtPrecioPH.RightToLeft = RightToLeft.No;
            txtPrecioPH.SelectedText = "";
            txtPrecioPH.SelectionLength = 0;
            txtPrecioPH.SelectionStart = 0;
            txtPrecioPH.ShortcutsEnabled = true;
            txtPrecioPH.Size = new Size(273, 48);
            txtPrecioPH.TabIndex = 6;
            txtPrecioPH.TabStop = false;
            txtPrecioPH.TextAlign = HorizontalAlignment.Left;
            txtPrecioPH.TrailingIcon = null;
            txtPrecioPH.UseAccent = false;
            txtPrecioPH.UseSystemPasswordChar = false;
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
            txtPiso.Location = new Point(567, 246);
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
            txtPiso.Size = new Size(273, 48);
            txtPiso.TabIndex = 3;
            txtPiso.TabStop = false;
            txtPiso.TextAlign = HorizontalAlignment.Left;
            txtPiso.TrailingIcon = null;
            txtPiso.UseAccent = false;
            txtPiso.UseSystemPasswordChar = false;
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
            txtCategoria.Location = new Point(289, 246);
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
            txtCategoria.Size = new Size(273, 48);
            txtCategoria.TabIndex = 2;
            txtCategoria.TabStop = false;
            txtCategoria.TextAlign = HorizontalAlignment.Left;
            txtCategoria.TrailingIcon = null;
            txtCategoria.UseAccent = false;
            txtCategoria.UseSystemPasswordChar = false;
            // 
            // txtEstado
            // 
            txtEstado.AnimateReadOnly = false;
            txtEstado.AutoCompleteMode = AutoCompleteMode.None;
            txtEstado.AutoCompleteSource = AutoCompleteSource.None;
            txtEstado.BackgroundImageLayout = ImageLayout.None;
            txtEstado.CharacterCasing = CharacterCasing.Normal;
            txtEstado.Depth = 0;
            txtEstado.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEstado.HideSelection = true;
            txtEstado.Hint = "Estado:";
            txtEstado.LeadingIcon = null;
            txtEstado.Location = new Point(10, 298);
            txtEstado.Margin = new Padding(3, 2, 3, 2);
            txtEstado.MaxLength = 32767;
            txtEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEstado.Name = "txtEstado";
            txtEstado.PasswordChar = '\0';
            txtEstado.PrefixSuffixText = null;
            txtEstado.ReadOnly = true;
            txtEstado.RightToLeft = RightToLeft.No;
            txtEstado.SelectedText = "";
            txtEstado.SelectionLength = 0;
            txtEstado.SelectionStart = 0;
            txtEstado.ShortcutsEnabled = true;
            txtEstado.Size = new Size(273, 48);
            txtEstado.TabIndex = 1;
            txtEstado.TabStop = false;
            txtEstado.TextAlign = HorizontalAlignment.Left;
            txtEstado.TrailingIcon = null;
            txtEstado.UseAccent = false;
            txtEstado.UseSystemPasswordChar = false;
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
            txtNumero.Location = new Point(10, 246);
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
            txtNumero.Size = new Size(273, 48);
            txtNumero.TabIndex = 0;
            txtNumero.TabStop = false;
            txtNumero.TextAlign = HorizontalAlignment.Left;
            txtNumero.TrailingIcon = null;
            txtNumero.UseAccent = false;
            txtNumero.UseSystemPasswordChar = false;
            // 
            // ReceptionView
            // 
            AccessibleRole = AccessibleRole.Window;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 51, 102);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(889, 518);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReceptionView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservar habitación";
            TransparencyKey = Color.Transparent;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPiso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCategoria;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEstado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNumero;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrecioPH;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCapacidad;
        private ReaLTaiizor.Controls.MaterialButton btnReservar;
        private Label label1;
        private Label lblDetalles;
        private ReaLTaiizor.Controls.RichTextBoxEdit txtExtras;
        private ReaLTaiizor.Controls.RichTextBoxEdit txtDetalles;
        private Label label3;
        private Label label2;
        private ReaLTaiizor.Controls.MaterialButton btnNuevoCliente;
        private ReaLTaiizor.Controls.MaterialComboBox cbxCliente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAdelanto;
        private Label label5;
        private Label label4;
        private Label dtpEntrada;
        private Label label6;
        private ReaLTaiizor.Controls.PoisonDateTime dtSalida;
        private NumericUpDown txtCantidad;
        private ReaLTaiizor.Controls.MaterialButton txtCancelar;
    }
}