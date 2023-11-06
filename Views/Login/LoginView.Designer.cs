namespace Hotel_Dorado_DesktopApp.Views.Login
{
    partial class LoginView
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
            txtUsuario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtClave = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label1 = new Label();
            ckbVerClave = new ReaLTaiizor.Controls.MaterialCheckBox();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            panel1 = new Panel();
            label2 = new Label();
            lostSeparator1 = new ReaLTaiizor.Controls.LostSeparator();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            btnIngresar = new ReaLTaiizor.Controls.MaterialButton();
            parrotGradientPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            txtUsuario.Location = new Point(24, 87);
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
            txtUsuario.Size = new Size(250, 48);
            txtUsuario.TabIndex = 0;
            txtUsuario.TabStop = false;
            txtUsuario.TextAlign = HorizontalAlignment.Left;
            txtUsuario.TrailingIcon = null;
            txtUsuario.UseSystemPasswordChar = false;
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
            txtClave.Hint = "Contraseña:";
            txtClave.LeadingIcon = null;
            txtClave.Location = new Point(24, 141);
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
            txtClave.Size = new Size(250, 48);
            txtClave.TabIndex = 1;
            txtClave.TabStop = false;
            txtClave.TextAlign = HorizontalAlignment.Left;
            txtClave.TrailingIcon = null;
            txtClave.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(250, 64);
            label1.TabIndex = 2;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ckbVerClave
            // 
            ckbVerClave.Depth = 0;
            ckbVerClave.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ckbVerClave.Location = new Point(24, 192);
            ckbVerClave.Margin = new Padding(0);
            ckbVerClave.MouseLocation = new Point(-1, -1);
            ckbVerClave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ckbVerClave.Name = "ckbVerClave";
            ckbVerClave.ReadOnly = false;
            ckbVerClave.Ripple = true;
            ckbVerClave.Size = new Size(250, 38);
            ckbVerClave.TabIndex = 3;
            ckbVerClave.Text = "mostrar contraseña";
            ckbVerClave.UseAccentColor = false;
            ckbVerClave.UseVisualStyleBackColor = true;
            ckbVerClave.CheckedChanged += ckbVerClave_CheckedChanged;
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.Beige;
            parrotGradientPanel1.BottomRight = Color.Yellow;
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(panel1);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(785, 421);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 4;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.Yellow;
            parrotGradientPanel1.TopRight = Color.Beige;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lostSeparator1);
            panel1.Controls.Add(materialButton1);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(txtClave);
            panel1.Controls.Add(ckbVerClave);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(42, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(687, 351);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(377, 20);
            label2.Name = "label2";
            label2.Size = new Size(294, 309);
            label2.TabIndex = 7;
            label2.Text = "Hotel \r\nDorado";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lostSeparator1
            // 
            lostSeparator1.BackColor = Color.Beige;
            lostSeparator1.ForeColor = Color.FromArgb(63, 63, 70);
            lostSeparator1.Horizontal = false;
            lostSeparator1.Location = new Point(314, 20);
            lostSeparator1.Name = "lostSeparator1";
            lostSeparator1.Size = new Size(23, 309);
            lostSeparator1.TabIndex = 6;
            lostSeparator1.Text = "lostSeparator1";
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(24, 285);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(250, 37);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "Salir";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = true;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.AutoSize = false;
            btnIngresar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIngresar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnIngresar.Depth = 0;
            btnIngresar.HighEmphasis = true;
            btnIngresar.Icon = null;
            btnIngresar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnIngresar.Location = new Point(24, 236);
            btnIngresar.Margin = new Padding(4, 6, 4, 6);
            btnIngresar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnIngresar.Name = "btnIngresar";
            btnIngresar.NoAccentTextColor = Color.Empty;
            btnIngresar.Size = new Size(250, 37);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnIngresar.UseAccentColor = false;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 421);
            Controls.Add(parrotGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginView";
            parrotGradientPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtUsuario;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtClave;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialCheckBox ckbVerClave;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialButton btnIngresar;
        private Label label2;
        private ReaLTaiizor.Controls.LostSeparator lostSeparator1;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
    }
}