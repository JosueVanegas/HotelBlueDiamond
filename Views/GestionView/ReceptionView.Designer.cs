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
            panelCarrusel = new Panel();
            SuspendLayout();
            // 
            // panelCarrusel
            // 
            panelCarrusel.AutoScroll = true;
            panelCarrusel.BackColor = SystemColors.AppWorkspace;
            panelCarrusel.Location = new Point(107, 146);
            panelCarrusel.Name = "panelCarrusel";
            panelCarrusel.Size = new Size(894, 379);
            panelCarrusel.TabIndex = 0;
            // 
            // ReceptionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 670);
            Controls.Add(panelCarrusel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReceptionView";
            Text = "ReceptionView";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCarrusel;
    }
}