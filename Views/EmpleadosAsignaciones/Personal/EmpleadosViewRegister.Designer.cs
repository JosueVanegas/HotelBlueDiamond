﻿namespace Hotel.Views.EmpleadosAsignaciones.Personal
{
    partial class EmpleadosViewRegister
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
            label1 = new Label();
            dtNacimiento = new ReaLTaiizor.Controls.PoisonDateTime();
            cbxCargo = new ReaLTaiizor.Controls.MaterialComboBox();
            lblTitulo = new Label();
            txtCedula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnGuardar = new ReaLTaiizor.Controls.MaterialButton();
            txtCorreo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTelefono = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtApellido = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtNacimiento);
            panel1.Controls.Add(cbxCargo);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(txtCedula);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Location = new Point(12, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 418);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(15, 254);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 9;
            label1.Text = "Fecha de nacimiento:";
            // 
            // dtNacimiento
            // 
            dtNacimiento.Location = new Point(15, 277);
            dtNacimiento.MinimumSize = new Size(0, 29);
            dtNacimiento.Name = "dtNacimiento";
            dtNacimiento.Size = new Size(544, 29);
            dtNacimiento.TabIndex = 8;
            // 
            // cbxCargo
            // 
            cbxCargo.AutoResize = false;
            cbxCargo.BackColor = Color.FromArgb(255, 255, 255);
            cbxCargo.Depth = 0;
            cbxCargo.DrawMode = DrawMode.OwnerDrawVariable;
            cbxCargo.DropDownHeight = 174;
            cbxCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCargo.DropDownWidth = 121;
            cbxCargo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxCargo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxCargo.FormattingEnabled = true;
            cbxCargo.Hint = "Cargo";
            cbxCargo.IntegralHeight = false;
            cbxCargo.ItemHeight = 43;
            cbxCargo.Location = new Point(301, 92);
            cbxCargo.MaxDropDownItems = 4;
            cbxCargo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxCargo.Name = "cbxCargo";
            cbxCargo.Size = new Size(258, 49);
            cbxCargo.StartIndex = 0;
            cbxCargo.TabIndex = 7;
            cbxCargo.UseAccent = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(15, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(544, 74);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Registrar Empleado";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
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
            txtCedula.Location = new Point(15, 94);
            txtCedula.Margin = new Padding(3, 2, 3, 2);
            txtCedula.MaxLength = 32767;
            txtCedula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCedula.Name = "txtCedula";
            txtCedula.PasswordChar = '\0';
            txtCedula.PrefixSuffixText = null;
            txtCedula.ReadOnly = false;
            txtCedula.RightToLeft = RightToLeft.No;
            txtCedula.SelectedText = "";
            txtCedula.SelectionLength = 0;
            txtCedula.SelectionStart = 0;
            txtCedula.ShortcutsEnabled = true;
            txtCedula.Size = new Size(258, 48);
            txtCedula.TabIndex = 6;
            txtCedula.TabStop = false;
            txtCedula.TextAlign = HorizontalAlignment.Left;
            txtCedula.TrailingIcon = null;
            txtCedula.UseAccent = false;
            txtCedula.UseSystemPasswordChar = false;
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
            btnCancelar.Location = new Point(185, 356);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(207, 38);
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
            btnGuardar.Location = new Point(185, 313);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(207, 38);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.AnimateReadOnly = false;
            txtCorreo.AutoCompleteMode = AutoCompleteMode.None;
            txtCorreo.AutoCompleteSource = AutoCompleteSource.None;
            txtCorreo.BackgroundImageLayout = ImageLayout.None;
            txtCorreo.CharacterCasing = CharacterCasing.Normal;
            txtCorreo.Depth = 0;
            txtCorreo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCorreo.HideSelection = true;
            txtCorreo.Hint = "Correo electrónico";
            txtCorreo.LeadingIcon = null;
            txtCorreo.Location = new Point(15, 198);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.MaxLength = 32767;
            txtCorreo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PasswordChar = '\0';
            txtCorreo.PrefixSuffixText = null;
            txtCorreo.ReadOnly = false;
            txtCorreo.RightToLeft = RightToLeft.No;
            txtCorreo.SelectedText = "";
            txtCorreo.SelectionLength = 0;
            txtCorreo.SelectionStart = 0;
            txtCorreo.ShortcutsEnabled = true;
            txtCorreo.Size = new Size(258, 48);
            txtCorreo.TabIndex = 3;
            txtCorreo.TabStop = false;
            txtCorreo.TextAlign = HorizontalAlignment.Left;
            txtCorreo.TrailingIcon = null;
            txtCorreo.UseAccent = false;
            txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.AutoCompleteMode = AutoCompleteMode.None;
            txtTelefono.AutoCompleteSource = AutoCompleteSource.None;
            txtTelefono.BackgroundImageLayout = ImageLayout.None;
            txtTelefono.CharacterCasing = CharacterCasing.Normal;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefono.HideSelection = true;
            txtTelefono.Hint = "Telefono";
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(301, 198);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.MaxLength = 32767;
            txtTelefono.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PasswordChar = '\0';
            txtTelefono.PrefixSuffixText = null;
            txtTelefono.ReadOnly = false;
            txtTelefono.RightToLeft = RightToLeft.No;
            txtTelefono.SelectedText = "";
            txtTelefono.SelectionLength = 0;
            txtTelefono.SelectionStart = 0;
            txtTelefono.ShortcutsEnabled = true;
            txtTelefono.Size = new Size(258, 48);
            txtTelefono.TabIndex = 2;
            txtTelefono.TabStop = false;
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            txtTelefono.TrailingIcon = null;
            txtTelefono.UseAccent = false;
            txtTelefono.UseSystemPasswordChar = false;
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
            txtApellido.Location = new Point(301, 146);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.MaxLength = 32767;
            txtApellido.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtApellido.Name = "txtApellido";
            txtApellido.PasswordChar = '\0';
            txtApellido.PrefixSuffixText = null;
            txtApellido.ReadOnly = false;
            txtApellido.RightToLeft = RightToLeft.No;
            txtApellido.SelectedText = "";
            txtApellido.SelectionLength = 0;
            txtApellido.SelectionStart = 0;
            txtApellido.ShortcutsEnabled = true;
            txtApellido.Size = new Size(258, 48);
            txtApellido.TabIndex = 1;
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
            txtNombre.Location = new Point(15, 146);
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
            txtNombre.Size = new Size(258, 48);
            txtNombre.TabIndex = 0;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.TrailingIcon = null;
            txtNombre.UseAccent = false;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // EmpleadosViewRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 443);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmpleadosViewRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmpleadosViewRegister";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCedula;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnGuardar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCorreo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTelefono;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtApellido;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombre;
        private ReaLTaiizor.Controls.MaterialComboBox cbxCargo;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonDateTime dtNacimiento;
    }
}