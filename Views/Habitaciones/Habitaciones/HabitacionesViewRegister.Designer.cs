﻿namespace Hotel_Dorado_DesktopApp.Views.Habitaciones.Habitaciones
{
    partial class HabitacionesViewRegister
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
            txtExtras = new ReaLTaiizor.Controls.MaterialRichTextBox();
            txtDetalles = new ReaLTaiizor.Controls.MaterialRichTextBox();
            cbxCategorias = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxPiso = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new TextBox();
            lblTitulo = new Label();
            txtNumero = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnGuardar = new ReaLTaiizor.Controls.MaterialButton();
            txtTarifa = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtExtras);
            panel1.Controls.Add(txtDetalles);
            panel1.Controls.Add(cbxCategorias);
            panel1.Controls.Add(cbxPiso);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(txtNumero);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtTarifa);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 658);
            panel1.TabIndex = 4;
            // 
            // txtExtras
            // 
            txtExtras.BackColor = Color.FromArgb(255, 255, 255);
            txtExtras.BorderStyle = BorderStyle.FixedSingle;
            txtExtras.Depth = 0;
            txtExtras.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtExtras.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtExtras.Hint = "";
            txtExtras.Location = new Point(17, 428);
            txtExtras.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtExtras.Name = "txtExtras";
            txtExtras.Size = new Size(404, 105);
            txtExtras.TabIndex = 11;
            txtExtras.Text = "";
            // 
            // txtDetalles
            // 
            txtDetalles.BackColor = Color.FromArgb(255, 255, 255);
            txtDetalles.BorderStyle = BorderStyle.FixedSingle;
            txtDetalles.Depth = 0;
            txtDetalles.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDetalles.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtDetalles.Hint = "";
            txtDetalles.Location = new Point(17, 197);
            txtDetalles.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txtDetalles.Name = "txtDetalles";
            txtDetalles.Size = new Size(404, 95);
            txtDetalles.TabIndex = 10;
            txtDetalles.Text = "";
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
            cbxCategorias.Hint = "Seleccione la categoria de la habitación";
            cbxCategorias.IntegralHeight = false;
            cbxCategorias.ItemHeight = 43;
            cbxCategorias.Location = new Point(17, 353);
            cbxCategorias.MaxDropDownItems = 4;
            cbxCategorias.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxCategorias.Name = "cbxCategorias";
            cbxCategorias.Size = new Size(404, 49);
            cbxCategorias.StartIndex = 0;
            cbxCategorias.TabIndex = 9;
            // 
            // cbxPiso
            // 
            cbxPiso.AutoResize = false;
            cbxPiso.BackColor = Color.FromArgb(255, 255, 255);
            cbxPiso.Depth = 0;
            cbxPiso.DrawMode = DrawMode.OwnerDrawVariable;
            cbxPiso.DropDownHeight = 174;
            cbxPiso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPiso.DropDownWidth = 121;
            cbxPiso.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxPiso.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxPiso.FormattingEnabled = true;
            cbxPiso.Hint = "Seleccione el piso en el que se encuentra";
            cbxPiso.IntegralHeight = false;
            cbxPiso.ItemHeight = 43;
            cbxPiso.Location = new Point(17, 298);
            cbxPiso.MaxDropDownItems = 4;
            cbxPiso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxPiso.Name = "cbxPiso";
            cbxPiso.Size = new Size(404, 49);
            cbxPiso.StartIndex = 0;
            cbxPiso.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Location = new Point(17, 539);
            txtId.Name = "txtId";
            txtId.Size = new Size(49, 27);
            txtId.TabIndex = 7;
            txtId.Text = "0";
            txtId.Visible = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(17, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(399, 98);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Registrar habitación";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
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
            txtNumero.Hint = "Numero de la habitación";
            txtNumero.LeadingIcon = null;
            txtNumero.Location = new Point(17, 111);
            txtNumero.MaxLength = 32767;
            txtNumero.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNumero.Name = "txtNumero";
            txtNumero.PasswordChar = '\0';
            txtNumero.PrefixSuffixText = null;
            txtNumero.ReadOnly = false;
            txtNumero.RightToLeft = RightToLeft.No;
            txtNumero.SelectedText = "";
            txtNumero.SelectionLength = 0;
            txtNumero.SelectionStart = 0;
            txtNumero.ShortcutsEnabled = true;
            txtNumero.Size = new Size(246, 48);
            txtNumero.TabIndex = 6;
            txtNumero.TabStop = false;
            txtNumero.TextAlign = HorizontalAlignment.Left;
            txtNumero.TrailingIcon = null;
            txtNumero.UseSystemPasswordChar = false;
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
            btnCancelar.Location = new Point(126, 599);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(198, 45);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = true;
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
            btnGuardar.Location = new Point(126, 542);
            btnGuardar.Margin = new Padding(4, 6, 4, 6);
            btnGuardar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(198, 45);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTarifa
            // 
            txtTarifa.AnimateReadOnly = false;
            txtTarifa.AutoCompleteMode = AutoCompleteMode.None;
            txtTarifa.AutoCompleteSource = AutoCompleteSource.None;
            txtTarifa.BackgroundImageLayout = ImageLayout.None;
            txtTarifa.CharacterCasing = CharacterCasing.Normal;
            txtTarifa.Depth = 0;
            txtTarifa.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTarifa.HideSelection = true;
            txtTarifa.Hint = "Tarifa por hora";
            txtTarifa.LeadingIcon = null;
            txtTarifa.Location = new Point(270, 111);
            txtTarifa.MaxLength = 32767;
            txtTarifa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTarifa.Name = "txtTarifa";
            txtTarifa.PasswordChar = '\0';
            txtTarifa.PrefixSuffixText = null;
            txtTarifa.ReadOnly = false;
            txtTarifa.RightToLeft = RightToLeft.No;
            txtTarifa.SelectedText = "";
            txtTarifa.SelectionLength = 0;
            txtTarifa.SelectionStart = 0;
            txtTarifa.ShortcutsEnabled = true;
            txtTarifa.Size = new Size(146, 48);
            txtTarifa.TabIndex = 3;
            txtTarifa.TabStop = false;
            txtTarifa.TextAlign = HorizontalAlignment.Left;
            txtTarifa.TrailingIcon = null;
            txtTarifa.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(17, 405);
            label1.Name = "label1";
            label1.Size = new Size(399, 20);
            label1.TabIndex = 12;
            label1.Text = "Extras que posee la habitación(ejemplo: TV + NETFLIX ,etc)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(17, 174);
            label2.Name = "label2";
            label2.Size = new Size(246, 20);
            label2.TabIndex = 13;
            label2.Text = "Escriba los detalles de la habitación";
            // 
            // HabitacionesViewRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 682);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HabitacionesViewRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HabitacionesViewRegister";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtId;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNumero;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnGuardar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTarifa;
        private ReaLTaiizor.Controls.MaterialComboBox cbxPiso;
        private ReaLTaiizor.Controls.MaterialComboBox cbxCategorias;
        private ReaLTaiizor.Controls.MaterialRichTextBox txtDetalles;
        private ReaLTaiizor.Controls.MaterialRichTextBox txtExtras;
        private Label label2;
        private Label label1;
    }
}