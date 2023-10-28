namespace Hotel_Dorado_DesktopApp.Views.GestionView
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
            panelCarrusel = new FlowLayoutPanel();
            panel1 = new Panel();
            txtCapacidad = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPrecioPH = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtExtras = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDetalles = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPiso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCategoria = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEstado = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNumero = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtReservar = new ReaLTaiizor.Controls.MaterialButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelCarrusel
            // 
            panelCarrusel.AutoScroll = true;
            panelCarrusel.BackColor = SystemColors.Control;
            panelCarrusel.Dock = DockStyle.Fill;
            panelCarrusel.Location = new Point(0, 225);
            panelCarrusel.Name = "panelCarrusel";
            panelCarrusel.Size = new Size(1143, 445);
            panelCarrusel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtReservar);
            panel1.Controls.Add(txtCapacidad);
            panel1.Controls.Add(txtPrecioPH);
            panel1.Controls.Add(txtExtras);
            panel1.Controls.Add(txtDetalles);
            panel1.Controls.Add(txtPiso);
            panel1.Controls.Add(txtCategoria);
            panel1.Controls.Add(txtEstado);
            panel1.Controls.Add(txtNumero);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 225);
            panel1.TabIndex = 2;
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
            txtCapacidad.Location = new Point(330, 146);
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
            txtCapacidad.Size = new Size(312, 48);
            txtCapacidad.TabIndex = 7;
            txtCapacidad.TabStop = false;
            txtCapacidad.TextAlign = HorizontalAlignment.Left;
            txtCapacidad.TrailingIcon = null;
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
            txtPrecioPH.Hint = "Precio por hora:";
            txtPrecioPH.LeadingIcon = null;
            txtPrecioPH.Location = new Point(330, 38);
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
            txtPrecioPH.Size = new Size(312, 48);
            txtPrecioPH.TabIndex = 6;
            txtPrecioPH.TabStop = false;
            txtPrecioPH.TextAlign = HorizontalAlignment.Left;
            txtPrecioPH.TrailingIcon = null;
            txtPrecioPH.UseSystemPasswordChar = false;
            // 
            // txtExtras
            // 
            txtExtras.AnimateReadOnly = false;
            txtExtras.AutoCompleteMode = AutoCompleteMode.None;
            txtExtras.AutoCompleteSource = AutoCompleteSource.None;
            txtExtras.BackgroundImageLayout = ImageLayout.None;
            txtExtras.CharacterCasing = CharacterCasing.Normal;
            txtExtras.Depth = 0;
            txtExtras.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtExtras.HideSelection = true;
            txtExtras.Hint = "Incluye:";
            txtExtras.LeadingIcon = null;
            txtExtras.Location = new Point(648, 92);
            txtExtras.MaxLength = 32767;
            txtExtras.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtExtras.Name = "txtExtras";
            txtExtras.PasswordChar = '\0';
            txtExtras.PrefixSuffixText = null;
            txtExtras.ReadOnly = true;
            txtExtras.RightToLeft = RightToLeft.No;
            txtExtras.SelectedText = "";
            txtExtras.SelectionLength = 0;
            txtExtras.SelectionStart = 0;
            txtExtras.ShortcutsEnabled = true;
            txtExtras.Size = new Size(312, 48);
            txtExtras.TabIndex = 5;
            txtExtras.TabStop = false;
            txtExtras.TextAlign = HorizontalAlignment.Left;
            txtExtras.TrailingIcon = null;
            txtExtras.UseSystemPasswordChar = false;
            // 
            // txtDetalles
            // 
            txtDetalles.AnimateReadOnly = false;
            txtDetalles.AutoCompleteMode = AutoCompleteMode.None;
            txtDetalles.AutoCompleteSource = AutoCompleteSource.None;
            txtDetalles.BackgroundImageLayout = ImageLayout.None;
            txtDetalles.CharacterCasing = CharacterCasing.Normal;
            txtDetalles.Depth = 0;
            txtDetalles.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDetalles.HideSelection = true;
            txtDetalles.Hint = "Detalles:";
            txtDetalles.LeadingIcon = null;
            txtDetalles.Location = new Point(648, 38);
            txtDetalles.MaxLength = 32767;
            txtDetalles.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDetalles.Name = "txtDetalles";
            txtDetalles.PasswordChar = '\0';
            txtDetalles.PrefixSuffixText = null;
            txtDetalles.ReadOnly = true;
            txtDetalles.RightToLeft = RightToLeft.No;
            txtDetalles.SelectedText = "";
            txtDetalles.SelectionLength = 0;
            txtDetalles.SelectionStart = 0;
            txtDetalles.ShortcutsEnabled = true;
            txtDetalles.Size = new Size(312, 48);
            txtDetalles.TabIndex = 4;
            txtDetalles.TabStop = false;
            txtDetalles.TextAlign = HorizontalAlignment.Left;
            txtDetalles.TrailingIcon = null;
            txtDetalles.UseSystemPasswordChar = false;
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
            txtPiso.Location = new Point(330, 92);
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
            txtPiso.Size = new Size(312, 48);
            txtPiso.TabIndex = 3;
            txtPiso.TabStop = false;
            txtPiso.TextAlign = HorizontalAlignment.Left;
            txtPiso.TrailingIcon = null;
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
            txtCategoria.Location = new Point(12, 146);
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
            txtCategoria.Size = new Size(312, 48);
            txtCategoria.TabIndex = 2;
            txtCategoria.TabStop = false;
            txtCategoria.TextAlign = HorizontalAlignment.Left;
            txtCategoria.TrailingIcon = null;
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
            txtEstado.Location = new Point(12, 92);
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
            txtEstado.Size = new Size(312, 48);
            txtEstado.TabIndex = 1;
            txtEstado.TabStop = false;
            txtEstado.TextAlign = HorizontalAlignment.Left;
            txtEstado.TrailingIcon = null;
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
            txtNumero.Location = new Point(12, 38);
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
            txtNumero.TabIndex = 0;
            txtNumero.TabStop = false;
            txtNumero.TextAlign = HorizontalAlignment.Left;
            txtNumero.TrailingIcon = null;
            txtNumero.UseSystemPasswordChar = false;
            // 
            // txtReservar
            // 
            txtReservar.AutoSize = false;
            txtReservar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtReservar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            txtReservar.Depth = 0;
            txtReservar.HighEmphasis = true;
            txtReservar.Icon = null;
            txtReservar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            txtReservar.Location = new Point(649, 149);
            txtReservar.Margin = new Padding(4, 6, 4, 6);
            txtReservar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtReservar.Name = "txtReservar";
            txtReservar.NoAccentTextColor = Color.Empty;
            txtReservar.Size = new Size(311, 45);
            txtReservar.TabIndex = 8;
            txtReservar.Text = "Realizar reserva";
            txtReservar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            txtReservar.UseAccentColor = false;
            txtReservar.UseVisualStyleBackColor = true;
            txtReservar.Click += txtReservar_Click;
            // 
            // ReceptionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 670);
            Controls.Add(panelCarrusel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReceptionView";
            Text = "ReceptionView";
            TransparencyKey = Color.Transparent;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelCarrusel;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtExtras;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDetalles;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPiso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCategoria;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEstado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNumero;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrecioPH;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCapacidad;
        private ReaLTaiizor.Controls.MaterialButton txtReservar;
    }
}