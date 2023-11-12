using Hotel.Controllers;
using Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Views.Pedidos.Productos
{
    public partial class CategoriasViewRegister : Form
    {
        HotelContext context;
        CategoriaProductoController controller;
        CategoriaProducto categoria;
        public CategoriasViewRegister(CategoriaProducto categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            context = new HotelContext();
            controller = new CategoriaProductoController(context);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "")
                {
                    if (categoria != null)
                    {
                        CategoriaProducto c = new CategoriaProducto
                        {
                            CategoriaProductoId = categoria.CategoriaProductoId,
                            Descripcion = txtNombre.Text,
                        };
                        controller.UpdateObject(c);
                        MessageBox.Show("Los datos de la categoria han sido actualizados correctamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CategoriaProducto c = new CategoriaProducto
                        {
                            Descripcion = txtNombre.Text,
                        };
                        controller.AddObject(c);
                        MessageBox.Show("Nuevo producto registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("LLene todos los campos para realizar esta acción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
