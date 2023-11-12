using Hotel.Controllers;
using Hotel.Models;
using Hotel.Views.Habitaciones.Categorias;
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
    public partial class ProductoViewRegister : Form
    {
        HotelContext context;
        ProductoController controller;
        Producto producto;
        public ProductoViewRegister(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            context = new HotelContext();
            controller = new ProductoController(context);
            validarCategoriaExiste();
        }
        private void validarCategoriaExiste()
        {
            var existeCategoria = new CategoriaProductoController(context).GetAllObject();
            if (existeCategoria.Count != 0)
            {
                validarProducto();
                this.ShowDialog();
            }
            else
            {
                if (MessageBox.Show(@"Para poder registrar un producto es necesario que exista al menos una categoria,Desea registrar una categoria de producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    CategoriasViewRegister form = new CategoriasViewRegister(null);
                    form.ShowDialog();
                    mostrarCategorias();
                }
                else
                {
                    this.Close();
                }
                
            }
        }
        private void mostrarCategorias()
        {
            context = new HotelContext();
            cbxCategorias.DataSource = new CategoriaProductoController(context).GetAllObject();
            cbxCategorias.DisplayMember = "Descripcion";
        }
        private void validarProducto()
        {
            if (producto != null)
            {
                lblTitulo.Text = "Actualizar producto";
                txtNombre.Text = producto.Descripcion;
                txtPrecio.Text = producto.Precio.ToString();
            }
            mostrarCategorias();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validarCampos()
        {
            if (txtNombre.Text != "" && txtPrecio.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {
                    var cat = cbxCategorias.SelectedItem as CategoriaProducto;
                    if (producto != null)
                    {
                        Producto p = new Producto
                        {
                            ProductoId = producto.ProductoId,
                            Descripcion = txtNombre.Text,
                            Precio = Convert.ToDecimal(txtPrecio.Text),
                            CategoriaProductoId = cat.CategoriaProductoId
                        };
                        controller.UpdateObject(p);
                        MessageBox.Show("Los datos del usuario han sido actualizados correctamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Producto p = new Producto
                        {
                            Descripcion = txtNombre.Text,
                            Precio = Convert.ToDecimal(txtPrecio.Text),
                            CategoriaProductoId = cat.CategoriaProductoId
                        };
                        controller.AddObject(p);
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
