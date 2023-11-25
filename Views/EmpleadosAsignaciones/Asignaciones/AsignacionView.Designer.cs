namespace Hotel.Views.EmpleadosAsignaciones.Asignaciones
{
    partial class AsignacionView
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
            panelEncabezado = new Panel();
            label1 = new Label();
            panelEncabezado.SuspendLayout();
            SuspendLayout();
            // 
            // panelCarrusel
            // 
            panelCarrusel.Dock = DockStyle.Fill;
            panelCarrusel.Location = new Point(0, 121);
            panelCarrusel.Name = "panelCarrusel";
            panelCarrusel.Size = new Size(1072, 521);
            panelCarrusel.TabIndex = 0;
            // 
            // panelEncabezado
            // 
            panelEncabezado.Controls.Add(label1);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(1072, 121);
            panelEncabezado.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1072, 80);
            label1.TabIndex = 6;
            label1.Text = "Asignaciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AsignacionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1072, 642);
            Controls.Add(panelCarrusel);
            Controls.Add(panelEncabezado);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AsignacionView";
            Text = "AsignacionView";
            panelEncabezado.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelCarrusel;
        private Panel panelEncabezado;
        private Label label1;
    }
}