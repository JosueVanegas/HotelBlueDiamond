namespace Hotel_Dorado_DesktopApp.Views.GestionView.Recepcion
{
    partial class ReservaViewResume
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
            btnReservar = new ReaLTaiizor.Controls.RoyalButton();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panelContenedor = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnReservar
            // 
            btnReservar.BackColor = Color.FromArgb(243, 243, 243);
            btnReservar.BorderColor = Color.FromArgb(180, 180, 180);
            btnReservar.BorderThickness = 3;
            btnReservar.DrawBorder = true;
            btnReservar.ForeColor = Color.FromArgb(31, 31, 31);
            btnReservar.HotTrackColor = Color.FromArgb(221, 221, 221);
            btnReservar.Image = null;
            btnReservar.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            btnReservar.Location = new Point(12, 75);
            btnReservar.Name = "btnReservar";
            btnReservar.PressedColor = Color.FromArgb(51, 102, 255);
            btnReservar.PressedForeColor = Color.White;
            btnReservar.Size = new Size(265, 60);
            btnReservar.TabIndex = 1;
            btnReservar.Text = "Nueva reservación";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1128, 72);
            label1.TabIndex = 0;
            label1.Text = "Reservación";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnReservar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 206);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 142);
            label2.Name = "label2";
            label2.Size = new Size(1128, 64);
            label2.TabIndex = 2;
            label2.Text = "Habitaciónes";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ControlDark;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 206);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1128, 482);
            panelContenedor.TabIndex = 2;
            // 
            // ReservaViewResume
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 688);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReservaViewResume";
            Text = "ReservaViewResume";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.RoyalButton btnReservar;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private FlowLayoutPanel panelContenedor;
    }
}