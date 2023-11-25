namespace Hotel.Views.EmpleadosAsignaciones.Asignaciones
{
    partial class AsignacionViewRegister
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
            cbxAsignaciones = new ReaLTaiizor.Controls.MaterialComboBox();
            txtBonificación = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dtpSalida = new Label();
            btnSalir = new ReaLTaiizor.Controls.MaterialButton();
            btnAgregar = new ReaLTaiizor.Controls.MaterialButton();
            label6 = new Label();
            txtDetallesAsignacion = new ReaLTaiizor.Controls.RichTextBoxEdit();
            label3 = new Label();
            dtpEntrada = new Label();
            label5 = new Label();
            label4 = new Label();
            cbxEmpleado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtPiso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCategoria = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNumero = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label2 = new Label();
            label1 = new Label();
            txtNombreEmpleado = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(txtNombreEmpleado);
            panel1.Controls.Add(cbxAsignaciones);
            panel1.Controls.Add(txtBonificación);
            panel1.Controls.Add(dtpSalida);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtDetallesAsignacion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpEntrada);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbxEmpleado);
            panel1.Controls.Add(txtPiso);
            panel1.Controls.Add(txtCategoria);
            panel1.Controls.Add(txtNumero);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 605);
            panel1.TabIndex = 0;
            // 
            // cbxAsignaciones
            // 
            cbxAsignaciones.AutoResize = false;
            cbxAsignaciones.BackColor = Color.FromArgb(255, 255, 255);
            cbxAsignaciones.Depth = 0;
            cbxAsignaciones.DrawMode = DrawMode.OwnerDrawVariable;
            cbxAsignaciones.DropDownHeight = 174;
            cbxAsignaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAsignaciones.DropDownWidth = 121;
            cbxAsignaciones.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxAsignaciones.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxAsignaciones.FormattingEnabled = true;
            cbxAsignaciones.Hint = "Seleccione el tipo de asignación";
            cbxAsignaciones.IntegralHeight = false;
            cbxAsignaciones.ItemHeight = 43;
            cbxAsignaciones.Location = new Point(467, 193);
            cbxAsignaciones.Margin = new Padding(3, 2, 3, 2);
            cbxAsignaciones.MaxDropDownItems = 4;
            cbxAsignaciones.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxAsignaciones.Name = "cbxAsignaciones";
            cbxAsignaciones.Size = new Size(284, 49);
            cbxAsignaciones.StartIndex = 0;
            cbxAsignaciones.TabIndex = 37;
            cbxAsignaciones.UseAccent = false;
            // 
            // txtBonificación
            // 
            txtBonificación.AnimateReadOnly = false;
            txtBonificación.AutoCompleteMode = AutoCompleteMode.None;
            txtBonificación.AutoCompleteSource = AutoCompleteSource.None;
            txtBonificación.BackgroundImageLayout = ImageLayout.None;
            txtBonificación.CharacterCasing = CharacterCasing.Normal;
            txtBonificación.Depth = 0;
            txtBonificación.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBonificación.HideSelection = true;
            txtBonificación.Hint = "Bonificación a proporcionar ($)";
            txtBonificación.LeadingIcon = null;
            txtBonificación.Location = new Point(526, 432);
            txtBonificación.Margin = new Padding(3, 2, 3, 2);
            txtBonificación.MaxLength = 32767;
            txtBonificación.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBonificación.Name = "txtBonificación";
            txtBonificación.PasswordChar = '\0';
            txtBonificación.PrefixSuffixText = null;
            txtBonificación.ReadOnly = false;
            txtBonificación.RightToLeft = RightToLeft.No;
            txtBonificación.SelectedText = "";
            txtBonificación.SelectionLength = 0;
            txtBonificación.SelectionStart = 0;
            txtBonificación.ShortcutsEnabled = true;
            txtBonificación.Size = new Size(225, 48);
            txtBonificación.TabIndex = 36;
            txtBonificación.TabStop = false;
            txtBonificación.Text = "0";
            txtBonificación.TextAlign = HorizontalAlignment.Left;
            txtBonificación.TrailingIcon = null;
            txtBonificación.UseAccent = false;
            txtBonificación.UseSystemPasswordChar = false;
            txtBonificación.KeyPress += ValidarDecimal_KeyPress;
            // 
            // dtpSalida
            // 
            dtpSalida.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpSalida.ForeColor = Color.DimGray;
            dtpSalida.Location = new Point(170, 364);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(215, 28);
            dtpSalida.TabIndex = 35;
            dtpSalida.Text = "Indefinidad por el momento";
            dtpSalida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSalir
            // 
            btnSalir.AutoSize = false;
            btnSalir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalir.Depth = 0;
            btnSalir.HighEmphasis = true;
            btnSalir.Icon = null;
            btnSalir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalir.Location = new Point(526, 488);
            btnSalir.Margin = new Padding(4, 6, 4, 6);
            btnSalir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalir.Name = "btnSalir";
            btnSalir.NoAccentTextColor = Color.Empty;
            btnSalir.Size = new Size(225, 49);
            btnSalir.TabIndex = 34;
            btnSalir.Text = "Salir";
            btnSalir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnSalir.UseAccentColor = true;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
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
            btnAgregar.Location = new Point(526, 549);
            btnAgregar.Margin = new Padding(4, 6, 4, 6);
            btnAgregar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAgregar.Name = "btnAgregar";
            btnAgregar.NoAccentTextColor = Color.Empty;
            btnAgregar.Size = new Size(225, 49);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Guardar";
            btnAgregar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregar.UseAccentColor = false;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label6
            // 
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(8, 405);
            label6.Name = "label6";
            label6.Size = new Size(511, 25);
            label6.TabIndex = 32;
            label6.Text = "Detalle la descripción de la tarea asignada:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDetallesAsignacion
            // 
            txtDetallesAsignacion.AutoWordSelection = false;
            txtDetallesAsignacion.BackColor = Color.White;
            txtDetallesAsignacion.BaseColor = Color.Transparent;
            txtDetallesAsignacion.BorderColor = Color.FromArgb(180, 180, 180);
            txtDetallesAsignacion.EdgeColor = Color.White;
            txtDetallesAsignacion.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetallesAsignacion.ForeColor = Color.DimGray;
            txtDetallesAsignacion.Location = new Point(8, 432);
            txtDetallesAsignacion.Margin = new Padding(3, 2, 3, 2);
            txtDetallesAsignacion.Name = "txtDetallesAsignacion";
            txtDetallesAsignacion.ReadOnly = false;
            txtDetallesAsignacion.Size = new Size(511, 166);
            txtDetallesAsignacion.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            txtDetallesAsignacion.TabIndex = 31;
            txtDetallesAsignacion.TextBackColor = Color.White;
            txtDetallesAsignacion.TextBorderStyle = BorderStyle.None;
            txtDetallesAsignacion.TextFont = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetallesAsignacion.WordWrap = true;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 151);
            label3.Name = "label3";
            label3.Size = new Size(762, 30);
            label3.TabIndex = 30;
            label3.Text = "Detalles del empleado";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpEntrada
            // 
            dtpEntrada.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEntrada.ForeColor = Color.DimGray;
            dtpEntrada.Location = new Point(171, 336);
            dtpEntrada.Name = "dtpEntrada";
            dtpEntrada.Size = new Size(212, 28);
            dtpEntrada.TabIndex = 29;
            dtpEntrada.Text = "Hoy";
            dtpEntrada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(8, 364);
            label5.Name = "label5";
            label5.Size = new Size(156, 28);
            label5.TabIndex = 28;
            label5.Text = "Fecha de finalización:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(8, 336);
            label4.Name = "label4";
            label4.Size = new Size(157, 28);
            label4.TabIndex = 27;
            label4.Text = "Fecha de asignación";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbxEmpleado
            // 
            cbxEmpleado.AutoResize = false;
            cbxEmpleado.BackColor = Color.FromArgb(255, 255, 255);
            cbxEmpleado.Depth = 0;
            cbxEmpleado.DrawMode = DrawMode.OwnerDrawVariable;
            cbxEmpleado.DropDownHeight = 174;
            cbxEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEmpleado.DropDownWidth = 121;
            cbxEmpleado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxEmpleado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxEmpleado.FormattingEnabled = true;
            cbxEmpleado.Hint = "Seleccione un empleado";
            cbxEmpleado.IntegralHeight = false;
            cbxEmpleado.ItemHeight = 43;
            cbxEmpleado.Location = new Point(3, 193);
            cbxEmpleado.Margin = new Padding(3, 2, 3, 2);
            cbxEmpleado.MaxDropDownItems = 4;
            cbxEmpleado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxEmpleado.Name = "cbxEmpleado";
            cbxEmpleado.Size = new Size(458, 49);
            cbxEmpleado.StartIndex = 0;
            cbxEmpleado.TabIndex = 26;
            cbxEmpleado.UseAccent = false;
            cbxEmpleado.SelectedIndexChanged += cbxEmpleado_SelectedIndexChanged;
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
            txtPiso.Location = new Point(504, 101);
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
            txtPiso.Size = new Size(247, 48);
            txtPiso.TabIndex = 12;
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
            txtCategoria.Location = new Point(225, 101);
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
            txtCategoria.TabIndex = 11;
            txtCategoria.TabStop = false;
            txtCategoria.TextAlign = HorizontalAlignment.Left;
            txtCategoria.TrailingIcon = null;
            txtCategoria.UseAccent = false;
            txtCategoria.UseSystemPasswordChar = false;
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
            txtNumero.Location = new Point(3, 101);
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
            txtNumero.Size = new Size(216, 48);
            txtNumero.TabIndex = 10;
            txtNumero.TabStop = false;
            txtNumero.TextAlign = HorizontalAlignment.Left;
            txtNumero.TrailingIcon = null;
            txtNumero.UseAccent = false;
            txtNumero.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 69);
            label2.Name = "label2";
            label2.Size = new Size(768, 30);
            label2.TabIndex = 9;
            label2.Text = "Detalles de la habitación";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(768, 69);
            label1.TabIndex = 7;
            label1.Text = "Registrar nueva asignación";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.AnimateReadOnly = false;
            txtNombreEmpleado.AutoCompleteMode = AutoCompleteMode.None;
            txtNombreEmpleado.AutoCompleteSource = AutoCompleteSource.None;
            txtNombreEmpleado.BackgroundImageLayout = ImageLayout.None;
            txtNombreEmpleado.CharacterCasing = CharacterCasing.Normal;
            txtNombreEmpleado.Depth = 0;
            txtNombreEmpleado.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreEmpleado.HideSelection = true;
            txtNombreEmpleado.Hint = "Nombre del empleado:";
            txtNombreEmpleado.LeadingIcon = null;
            txtNombreEmpleado.Location = new Point(3, 246);
            txtNombreEmpleado.Margin = new Padding(3, 2, 3, 2);
            txtNombreEmpleado.MaxLength = 32767;
            txtNombreEmpleado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.PasswordChar = '\0';
            txtNombreEmpleado.PrefixSuffixText = null;
            txtNombreEmpleado.ReadOnly = true;
            txtNombreEmpleado.RightToLeft = RightToLeft.No;
            txtNombreEmpleado.SelectedText = "";
            txtNombreEmpleado.SelectionLength = 0;
            txtNombreEmpleado.SelectionStart = 0;
            txtNombreEmpleado.ShortcutsEnabled = true;
            txtNombreEmpleado.Size = new Size(273, 48);
            txtNombreEmpleado.TabIndex = 38;
            txtNombreEmpleado.TabStop = false;
            txtNombreEmpleado.TextAlign = HorizontalAlignment.Left;
            txtNombreEmpleado.TrailingIcon = null;
            txtNombreEmpleado.UseAccent = false;
            txtNombreEmpleado.UseSystemPasswordChar = false;
            // 
            // AsignacionViewRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(792, 629);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AsignacionViewRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AsignacionViewRegistercs";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPiso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCategoria;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNumero;
        private Label label3;
        private Label dtpEntrada;
        private Label label5;
        private Label label4;
        private ReaLTaiizor.Controls.MaterialComboBox cbxEmpleado;
        private Label label6;
        private ReaLTaiizor.Controls.RichTextBoxEdit txtDetallesAsignacion;
        private ReaLTaiizor.Controls.MaterialButton btnSalir;
        private ReaLTaiizor.Controls.MaterialButton btnAgregar;
        private Label dtpSalida;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBonificación;
        private ReaLTaiizor.Controls.MaterialComboBox cbxAsignaciones;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombreEmpleado;
    }
}