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
            panel3 = new Panel();
            hopePictureBox3 = new ReaLTaiizor.Controls.HopePictureBox();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            hopePictureBox2 = new ReaLTaiizor.Controls.HopePictureBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            lblCantidadHabitaciones = new Label();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            label6 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            parrotGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 550);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1148, 155);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(hopePictureBox3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(767, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(378, 149);
            panel3.TabIndex = 2;
            // 
            // hopePictureBox3
            // 
            hopePictureBox3.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox3.Dock = DockStyle.Fill;
            hopePictureBox3.Image = (Image)resources.GetObject("hopePictureBox3.Image");
            hopePictureBox3.Location = new Point(314, 78);
            hopePictureBox3.Name = "hopePictureBox3";
            hopePictureBox3.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox3.Size = new Size(64, 71);
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
            label4.Size = new Size(314, 71);
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
            label5.Size = new Size(378, 78);
            label5.TabIndex = 3;
            label5.Text = "habitaciones ocupadas";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(hopePictureBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(385, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 149);
            panel2.TabIndex = 1;
            // 
            // hopePictureBox2
            // 
            hopePictureBox2.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox2.Dock = DockStyle.Fill;
            hopePictureBox2.Image = (Image)resources.GetObject("hopePictureBox2.Image");
            hopePictureBox2.Location = new Point(310, 78);
            hopePictureBox2.Name = "hopePictureBox2";
            hopePictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox2.Size = new Size(66, 71);
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
            label2.Size = new Size(310, 71);
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
            label3.Size = new Size(376, 78);
            label3.TabIndex = 3;
            label3.Text = "Habitaciones disponibles";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(hopePictureBox1);
            panel1.Controls.Add(lblCantidadHabitaciones);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 149);
            panel1.TabIndex = 0;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.White;
            hopePictureBox1.Dock = DockStyle.Fill;
            hopePictureBox1.Image = (Image)resources.GetObject("hopePictureBox1.Image");
            hopePictureBox1.Location = new Point(305, 78);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(71, 71);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 2;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lblCantidadHabitaciones
            // 
            lblCantidadHabitaciones.BackColor = Color.White;
            lblCantidadHabitaciones.Dock = DockStyle.Left;
            lblCantidadHabitaciones.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadHabitaciones.Location = new Point(0, 78);
            lblCantidadHabitaciones.Name = "lblCantidadHabitaciones";
            lblCantidadHabitaciones.Size = new Size(305, 71);
            lblCantidadHabitaciones.TabIndex = 1;
            lblCantidadHabitaciones.Text = "null";
            lblCantidadHabitaciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(376, 78);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de habitaciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // parrotGradientPanel1
            // 
            
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(label6);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.Black;
            parrotGradientPanel1.Size = new Size(1148, 550);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 6;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.Gold;
            parrotGradientPanel1.TopRight = Color.Yellow;
            parrotGradientPanel1.BottomLeft = Color.Gold;
            parrotGradientPanel1.BottomRight = Color.Beige;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 100F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(793, 484);
            label6.TabIndex = 0;
            label6.Text = "Hotel \r\nDorado";
            // 
            // DashBoardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 705);
            Controls.Add(parrotGradientPanel1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashBoardView";
            Text = "DashBoardView";
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hopePictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hopePictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            parrotGradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label lblCantidadHabitaciones;
        private Label label1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox3;
        private Label label4;
        private Label label5;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox2;
        private Label label2;
        private Label label3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private Label label6;
    }
}