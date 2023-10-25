namespace Hotel_Dorado_DesktopApp.Views.HomeView
{
    partial class DashBoardView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardView));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblCantidadHabitaciones = new Label();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            hopePictureBox2 = new ReaLTaiizor.Controls.HopePictureBox();
            label2 = new Label();
            label3 = new Label();
            hopePictureBox3 = new ReaLTaiizor.Controls.HopePictureBox();
            label4 = new Label();
            label5 = new Label();
            hopePictureBox4 = new ReaLTaiizor.Controls.HopePictureBox();
            label6 = new Label();
            label7 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox4).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel4, 3, 0);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 388);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(987, 205);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(228, 110, 22);
            panel4.Controls.Add(hopePictureBox4);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(741, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(243, 199);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(249, 163, 89);
            panel3.Controls.Add(hopePictureBox3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(495, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 199);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(228, 110, 22);
            panel2.Controls.Add(hopePictureBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(249, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 199);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 163, 89);
            panel1.Controls.Add(hopePictureBox1);
            panel1.Controls.Add(lblCantidadHabitaciones);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 199);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(987, 388);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 78);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de habitaciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCantidadHabitaciones
            // 
            lblCantidadHabitaciones.Dock = DockStyle.Left;
            lblCantidadHabitaciones.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadHabitaciones.Location = new Point(0, 78);
            lblCantidadHabitaciones.Name = "lblCantidadHabitaciones";
            lblCantidadHabitaciones.Size = new Size(167, 121);
            lblCantidadHabitaciones.TabIndex = 1;
            lblCantidadHabitaciones.Text = "0";
            lblCantidadHabitaciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Dock = DockStyle.Fill;
            hopePictureBox1.Image = (Image)resources.GetObject("hopePictureBox1.Image");
            hopePictureBox1.Location = new Point(167, 78);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(73, 121);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 2;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // hopePictureBox2
            // 
            hopePictureBox2.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox2.Dock = DockStyle.Fill;
            hopePictureBox2.Image = (Image)resources.GetObject("hopePictureBox2.Image");
            hopePictureBox2.Location = new Point(166, 78);
            hopePictureBox2.Name = "hopePictureBox2";
            hopePictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox2.Size = new Size(74, 121);
            hopePictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox2.TabIndex = 5;
            hopePictureBox2.TabStop = false;
            hopePictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 78);
            label2.Name = "label2";
            label2.Size = new Size(166, 121);
            label2.TabIndex = 4;
            label2.Text = "0";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(240, 78);
            label3.TabIndex = 3;
            label3.Text = "Habitaciones disponibles";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hopePictureBox3
            // 
            hopePictureBox3.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox3.Dock = DockStyle.Fill;
            hopePictureBox3.Image = (Image)resources.GetObject("hopePictureBox3.Image");
            hopePictureBox3.Location = new Point(166, 78);
            hopePictureBox3.Name = "hopePictureBox3";
            hopePictureBox3.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox3.Size = new Size(74, 121);
            hopePictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox3.TabIndex = 5;
            hopePictureBox3.TabStop = false;
            hopePictureBox3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 78);
            label4.Name = "label4";
            label4.Size = new Size(166, 121);
            label4.TabIndex = 4;
            label4.Text = "0";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(240, 78);
            label5.TabIndex = 3;
            label5.Text = "habitaciones ocupadas";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hopePictureBox4
            // 
            hopePictureBox4.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox4.Dock = DockStyle.Fill;
            hopePictureBox4.Image = (Image)resources.GetObject("hopePictureBox4.Image");
            hopePictureBox4.Location = new Point(169, 78);
            hopePictureBox4.Name = "hopePictureBox4";
            hopePictureBox4.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox4.Size = new Size(74, 121);
            hopePictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox4.TabIndex = 5;
            hopePictureBox4.TabStop = false;
            hopePictureBox4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 78);
            label6.Name = "label6";
            label6.Size = new Size(169, 121);
            label6.TabIndex = 4;
            label6.Text = "0";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(243, 78);
            label7.TabIndex = 3;
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashBoardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 595);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashBoardView";
            Text = "DashBoardView";
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblCantidadHabitaciones;
        private Label label1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox4;
        private Label label6;
        private Label label7;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox3;
        private Label label4;
        private Label label5;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox2;
        private Label label2;
        private Label label3;
    }
}