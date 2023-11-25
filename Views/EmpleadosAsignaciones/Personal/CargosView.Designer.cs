namespace Hotel.Views.EmpleadosAsignaciones.Personal
{
    partial class CargosView
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblTitulo = new Label();
            tbCargos = new ReaLTaiizor.Controls.PoisonDataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Borrar = new DataGridViewButtonColumn();
            btnAgregar = new ReaLTaiizor.Controls.MaterialButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbCargos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 128);
            panel1.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(848, 57);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cargos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbCargos
            // 
            tbCargos.AllowUserToAddRows = false;
            tbCargos.AllowUserToDeleteRows = false;
            tbCargos.AllowUserToResizeColumns = false;
            tbCargos.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(244, 204, 137);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            tbCargos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            tbCargos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbCargos.BackgroundColor = Color.FromArgb(255, 255, 255);
            tbCargos.BorderStyle = BorderStyle.None;
            tbCargos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbCargos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            tbCargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            tbCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbCargos.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion, Salario, Editar, Borrar });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            tbCargos.DefaultCellStyle = dataGridViewCellStyle7;
            tbCargos.Dock = DockStyle.Fill;
            tbCargos.EnableHeadersVisualStyles = false;
            tbCargos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCargos.GridColor = Color.FromArgb(255, 255, 255);
            tbCargos.Location = new Point(0, 128);
            tbCargos.Margin = new Padding(3, 2, 3, 2);
            tbCargos.MultiSelect = false;
            tbCargos.Name = "tbCargos";
            tbCargos.ReadOnly = true;
            tbCargos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            tbCargos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            tbCargos.RowHeadersWidth = 51;
            tbCargos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbCargos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbCargos.Size = new Size(848, 356);
            tbCargos.StandardTab = true;
            tbCargos.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            tbCargos.TabIndex = 2;
            tbCargos.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            tbCargos.CellContentClick += cellContentClick;
            tbCargos.CellPainting += cellPainting;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Salario
            // 
            Salario.HeaderText = "Salario base";
            Salario.MinimumWidth = 6;
            Salario.Name = "Salario";
            Salario.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            // 
            // Borrar
            // 
            Borrar.HeaderText = "Borrar";
            Borrar.MinimumWidth = 6;
            Borrar.Name = "Borrar";
            Borrar.ReadOnly = true;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = false;
            btnAgregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregar.Depth = 0;
            btnAgregar.HighEmphasis = true;
            btnAgregar.Icon = null;
            btnAgregar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAgregar.Location = new Point(4, 73);
            btnAgregar.Margin = new Padding(4, 6, 4, 6);
            btnAgregar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAgregar.Name = "btnAgregar";
            btnAgregar.NoAccentTextColor = Color.Empty;
            btnAgregar.Size = new Size(372, 49);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Registrar nuevo cargo";
            btnAgregar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregar.UseAccentColor = false;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnRegistrar_Click;
            // 
            // CargosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 484);
            Controls.Add(tbCargos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CargosView";
            Text = "CargosView";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbCargos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private ReaLTaiizor.Controls.PoisonDataGridView tbCargos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Salario;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Borrar;
        private ReaLTaiizor.Controls.MaterialButton btnAgregar;
    }
}