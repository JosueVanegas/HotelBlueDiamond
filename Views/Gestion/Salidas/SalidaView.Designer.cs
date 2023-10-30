namespace Hotel_Dorado_DesktopApp.Views.GestionView
{
    partial class SalidaView
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
            panelHabitaciones = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panelHabitaciones
            // 
            panelHabitaciones.Location = new Point(35, 204);
            panelHabitaciones.Name = "panelHabitaciones";
            panelHabitaciones.Size = new Size(930, 397);
            panelHabitaciones.TabIndex = 0;
            // 
            // SalidaView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 633);
            Controls.Add(panelHabitaciones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalidaView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalidaViewcs";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelHabitaciones;
    }
}