namespace Hotel.Views.Usuarios
{
    partial class UsuariosViewRegister
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
            cbxEmpleados = new ReaLTaiizor.Controls.MaterialComboBox();
            panel1 = new Panel();
            ckbVerClave = new ReaLTaiizor.Controls.MaterialCheckBox();
            txtConfirmarClave = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbxRoles = new ReaLTaiizor.Controls.MaterialComboBox();
            lblTitulo = new Label();
            txtUsuario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnGuardar = new ReaLTaiizor.Controls.MaterialButton();
            txtClave = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtApellido = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNombre = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbxEmpleados
            // 
            cbxEmpleados.AutoResize = false;
            cbxEmpleados.BackColor = Color.FromArgb(255, 255, 255);
            cbxEmpleados.Depth = 0;
            cbxEmpleados.DrawMode = DrawMode.OwnerDrawVariable;
            cbxEmpleados.DropDownHeight = 174;
            cbxEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEmpleados.DropDownWidth = 121;
            cbxEmpleados.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxEmpleados.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxEmpleados.FormattingEnabled = true;
            cbxEmpleados.Hint = "Asigne un empleado a este usuario:";
            cbxEmpleados.IntegralHeight = false;
            cbxEmpleados.ItemHeight = 43;
            cbxEmpleados.Location = new Point(15, 294);
            cbxEmpleados.MaxDropDownItems = 4;
            cbxEmpleados.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxEmpleados.Name = "cbxEmpleados";
            cbxEmpleados.Size = new Size(436, 49);
            cbxEmpleados.StartIndex = 0;
            cbxEmpleados.TabIndex = 0;
            cbxEmpleados.UseAccent = false;
            cbxEmpleados.SelectedIndexChanged += cbxEmpleados_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(ckbVerClave);
            panel1.Controls.Add(txtConfirmarClave);
            panel1.Controls.Add(cbxRoles);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(cbxEmpleados);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtClave);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Location = new Point(12, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 590);
            panel1.TabIndex = 4;
            // 
            // ckbVerClave
            // 
            ckbVerClave.Depth = 0;
            ckbVerClave.Location = new Point(15, 248);
            ckbVerClave.Margin = new Padding(0);
            ckbVerClave.MouseLocation = new Point(-1, -1);
            ckbVerClave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ckbVerClave.Name = "ckbVerClave";
            ckbVerClave.ReadOnly = false;
            ckbVerClave.Ripple = true;
            ckbVerClave.Size = new Size(436, 43);
            ckbVerClave.TabIndex = 9;
            ckbVerClave.Text = "mostrar contraseña";
            ckbVerClave.UseAccentColor = false;
            ckbVerClave.UseVisualStyleBackColor = true;
            ckbVerClave.CheckedChanged += ckbVerClave_CheckedChanged;
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.AnimateReadOnly = false;
            txtConfirmarClave.AutoCompleteMode = AutoCompleteMode.None;
            txtConfirmarClave.AutoCompleteSource = AutoCompleteSource.None;
            txtConfirmarClave.BackgroundImageLayout = ImageLayout.None;
            txtConfirmarClave.CharacterCasing = CharacterCasing.Normal;
            txtConfirmarClave.Depth = 0;
            txtConfirmarClave.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtConfirmarClave.HideSelection = true;
            txtConfirmarClave.Hint = "Ingrese la contraseña nuevamente:";
            txtConfirmarClave.LeadingIcon = null;
            txtConfirmarClave.Location = new Point(15, 198);
            txtConfirmarClave.Margin = new Padding(3, 2, 3, 2);
            txtConfirmarClave.MaxLength = 32767;
            txtConfirmarClave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.PasswordChar = '*';
            txtConfirmarClave.PrefixSuffixText = null;
            txtConfirmarClave.ReadOnly = false;
            txtConfirmarClave.RightToLeft = RightToLeft.No;
            txtConfirmarClave.SelectedText = "";
            txtConfirmarClave.SelectionLength = 0;
            txtConfirmarClave.SelectionStart = 0;
            txtConfirmarClave.ShortcutsEnabled = true;
            txtConfirmarClave.Size = new Size(436, 48);
            txtConfirmarClave.TabIndex = 8;
            txtConfirmarClave.TabStop = false;
            txtConfirmarClave.TextAlign = HorizontalAlignment.Left;
            txtConfirmarClave.TrailingIcon = null;
            txtConfirmarClave.UseAccent = false;
            txtConfirmarClave.UseSystemPasswordChar = false;
            // 
            // cbxRoles
            // 
            cbxRoles.AutoResize = false;
            cbxRoles.BackColor = Color.FromArgb(255, 255, 255);
            cbxRoles.Depth = 0;
            cbxRoles.DrawMode = DrawMode.OwnerDrawVariable;
            cbxRoles.DropDownHeight = 174;
            cbxRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRoles.DropDownWidth = 121;
            cbxRoles.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxRoles.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxRoles.FormattingEnabled = true;
            cbxRoles.Hint = "Asigne un rol de acceso:";
            cbxRoles.IntegralHeight = false;
            cbxRoles.ItemHeight = 43;
            cbxRoles.Location = new Point(15, 409);
            cbxRoles.MaxDropDownItems = 4;
            cbxRoles.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxRoles.Name = "cbxRoles";
            cbxRoles.Size = new Size(436, 49);
            cbxRoles.StartIndex = 0;
            cbxRoles.TabIndex = 7;
            cbxRoles.UseAccent = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(15, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(436, 74);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Registrar usuario";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.AutoCompleteMode = AutoCompleteMode.None;
            txtUsuario.AutoCompleteSource = AutoCompleteSource.None;
            txtUsuario.BackgroundImageLayout = ImageLayout.None;
            txtUsuario.CharacterCasing = CharacterCasing.Normal;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsuario.HideSelection = true;
            txtUsuario.Hint = "Nombre de usuario:";
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(15, 94);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.MaxLength = 32767;
            txtUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '\0';
            txtUsuario.PrefixSuffixText = null;
            txtUsuario.ReadOnly = false;
            txtUsuario.RightToLeft = RightToLeft.No;
            txtUsuario.SelectedText = "";
            txtUsuario.SelectionLength = 0;
            txtUsuario.SelectionStart = 0;
            txtUsuario.ShortcutsEnabled = true;
            txtUsuario.Size = new Size(436, 48);
            txtUsuario.TabIndex = 6;
            txtUsuario.TabStop = false;
            txtUsuario.TextAlign = HorizontalAlignment.Left;
            txtUsuario.TrailingIcon = null;
            txtUsuario.UseAccent = false;
            txtUsuario.UseSystemPasswordChar = false;
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
            btnCancelar.Location = new Point(15, 509);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(436, 34);
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
            btnGuardar.Location = new Point(15, 465);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(436, 34);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtClave
            // 
            txtClave.AnimateReadOnly = false;
            txtClave.AutoCompleteMode = AutoCompleteMode.None;
            txtClave.AutoCompleteSource = AutoCompleteSource.None;
            txtClave.BackgroundImageLayout = ImageLayout.None;
            txtClave.CharacterCasing = CharacterCasing.Normal;
            txtClave.Depth = 0;
            txtClave.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtClave.HideSelection = true;
            txtClave.Hint = "Ingrese la contraseña:";
            txtClave.LeadingIcon = null;
            txtClave.Location = new Point(15, 146);
            txtClave.Margin = new Padding(3, 2, 3, 2);
            txtClave.MaxLength = 32767;
            txtClave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PrefixSuffixText = null;
            txtClave.ReadOnly = false;
            txtClave.RightToLeft = RightToLeft.No;
            txtClave.SelectedText = "";
            txtClave.SelectionLength = 0;
            txtClave.SelectionStart = 0;
            txtClave.ShortcutsEnabled = true;
            txtClave.Size = new Size(436, 48);
            txtClave.TabIndex = 3;
            txtClave.TabStop = false;
            txtClave.TextAlign = HorizontalAlignment.Left;
            txtClave.TrailingIcon = null;
            txtClave.UseAccent = false;
            txtClave.UseSystemPasswordChar = false;
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
            txtApellido.Location = new Point(236, 348);
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
            txtApellido.Size = new Size(215, 48);
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
            txtNombre.Location = new Point(15, 348);
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
            txtNombre.Size = new Size(215, 48);
            txtNombre.TabIndex = 0;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.TrailingIcon = null;
            txtNombre.UseAccent = false;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // UsuariosViewRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 612);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UsuariosViewRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsuariosViewRegister";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cbxEmpleados;
        private Panel panel1;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUsuario;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnGuardar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtClave;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtApellido;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNombre;
        private ReaLTaiizor.Controls.MaterialComboBox cbxRoles;
        private ReaLTaiizor.Controls.MaterialCheckBox ckbVerClave;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtConfirmarClave;
    }
}