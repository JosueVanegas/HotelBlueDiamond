﻿namespace Hotel.Views.Habitaciones
{
    partial class CategoriasHabitacionView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            panel1 = new Panel();
            tbCategorias = new ReaLTaiizor.Controls.PoisonDataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Borrar = new DataGridViewButtonColumn();
            btnAgregar = new ReaLTaiizor.Controls.MaterialButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1055, 50);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Categorias de habitaciones";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.Size = new Size(1055, 119);
            panel1.TabIndex = 5;
            // 
            // tbCategorias
            // 
            tbCategorias.AllowUserToAddRows = false;
            tbCategorias.AllowUserToDeleteRows = false;
            tbCategorias.AllowUserToResizeColumns = false;
            tbCategorias.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 204, 137);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            tbCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tbCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbCategorias.BackgroundColor = Color.FromArgb(255, 255, 255);
            tbCategorias.BorderStyle = BorderStyle.None;
            tbCategorias.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tbCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tbCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbCategorias.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Cantidad, Editar, Borrar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tbCategorias.DefaultCellStyle = dataGridViewCellStyle3;
            tbCategorias.Dock = DockStyle.Fill;
            tbCategorias.EnableHeadersVisualStyles = false;
            tbCategorias.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCategorias.GridColor = Color.FromArgb(255, 255, 255);
            tbCategorias.Location = new Point(0, 119);
            tbCategorias.Margin = new Padding(3, 2, 3, 2);
            tbCategorias.MultiSelect = false;
            tbCategorias.Name = "tbCategorias";
            tbCategorias.ReadOnly = true;
            tbCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 170, 173);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 201, 206);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tbCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tbCategorias.RowHeadersWidth = 51;
            tbCategorias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbCategorias.Size = new Size(1055, 417);
            tbCategorias.StandardTab = true;
            tbCategorias.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            tbCategorias.TabIndex = 4;
            tbCategorias.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            tbCategorias.CellContentClick += cellContentClick;
            tbCategorias.CellPainting += cellPainting;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad de huéspedes permitida";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
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
            btnAgregar.Location = new Point(4, 64);
            btnAgregar.Margin = new Padding(4, 6, 4, 6);
            btnAgregar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAgregar.Name = "btnAgregar";
            btnAgregar.NoAccentTextColor = Color.Empty;
            btnAgregar.Size = new Size(372, 49);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Crear nueva categoria";
            btnAgregar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregar.UseAccentColor = false;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnRegistrar_Click;
            // 
            // CategoriasHabitacionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 536);
            Controls.Add(tbCategorias);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CategoriasHabitacionView";
            Text = "CategoriasHabitacionView";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private ReaLTaiizor.Controls.PoisonDataGridView tbCategorias;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Borrar;
        private ReaLTaiizor.Controls.MaterialButton btnAgregar;
    }
}