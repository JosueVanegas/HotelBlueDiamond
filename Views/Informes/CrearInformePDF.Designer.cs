namespace Hotel.Views.Informes
{
    partial class CrearInformePDF
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
            btnSalir = new ReaLTaiizor.Controls.MaterialButton();
            btnGenerar = new ReaLTaiizor.Controls.MaterialButton();
            lblTipoReporte = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            fechaFinal = new ReaLTaiizor.Controls.PoisonDateTime();
            fechaInicio = new ReaLTaiizor.Controls.PoisonDateTime();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnGenerar);
            panel1.Controls.Add(lblTipoReporte);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(fechaFinal);
            panel1.Controls.Add(fechaInicio);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 306);
            panel1.TabIndex = 0;
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
            btnSalir.Location = new Point(239, 236);
            btnSalir.Margin = new Padding(4, 6, 4, 6);
            btnSalir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalir.Name = "btnSalir";
            btnSalir.NoAccentTextColor = Color.Empty;
            btnSalir.Size = new Size(201, 46);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnSalir.UseAccentColor = true;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.AutoSize = false;
            btnGenerar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGenerar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGenerar.Depth = 0;
            btnGenerar.HighEmphasis = true;
            btnGenerar.Icon = null;
            btnGenerar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnGenerar.Location = new Point(18, 236);
            btnGenerar.Margin = new Padding(4, 6, 4, 6);
            btnGenerar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnGenerar.Name = "btnGenerar";
            btnGenerar.NoAccentTextColor = Color.Empty;
            btnGenerar.Size = new Size(201, 46);
            btnGenerar.TabIndex = 6;
            btnGenerar.Text = "Generar reporte";
            btnGenerar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGenerar.UseAccentColor = false;
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.Dock = DockStyle.Top;
            lblTipoReporte.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoReporte.ForeColor = Color.Gray;
            lblTipoReporte.Location = new Point(0, 44);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(462, 44);
            lblTipoReporte.TabIndex = 5;
            lblTipoReporte.Text = "x";
            lblTipoReporte.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(462, 44);
            label3.TabIndex = 4;
            label3.Text = "Creador de reportes";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(18, 156);
            label2.Name = "label2";
            label2.Size = new Size(422, 33);
            label2.TabIndex = 3;
            label2.Text = "Hasta:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(18, 88);
            label1.Name = "label1";
            label1.Size = new Size(422, 33);
            label1.TabIndex = 2;
            label1.Text = "Desde:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fechaFinal
            // 
            fechaFinal.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fechaFinal.Cursor = Cursors.Hand;
            fechaFinal.Location = new Point(18, 192);
            fechaFinal.MinimumSize = new Size(0, 29);
            fechaFinal.Name = "fechaFinal";
            fechaFinal.Size = new Size(422, 29);
            fechaFinal.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            fechaFinal.TabIndex = 1;
            // 
            // fechaInicio
            // 
            fechaInicio.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fechaInicio.Cursor = Cursors.Hand;
            fechaInicio.Location = new Point(18, 124);
            fechaInicio.MinimumSize = new Size(0, 29);
            fechaInicio.Name = "fechaInicio";
            fechaInicio.Size = new Size(422, 29);
            fechaInicio.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            fechaInicio.TabIndex = 0;
            fechaInicio.ValueChanged += fechaInicio_ValueChanged;
            // 
            // CrearInformePDF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 51, 102);
            ClientSize = new Size(486, 330);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CrearInformePDF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearInformePDF";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.PoisonDateTime fechaInicio;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonDateTime fechaFinal;
        private ReaLTaiizor.Controls.MaterialButton btnSalir;
        private ReaLTaiizor.Controls.MaterialButton btnGenerar;
        private Label lblTipoReporte;
        private Label label3;
        private Label label2;
    }
}