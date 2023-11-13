using Hotel.Controllers;
using Hotel.Models;
using Hotel.Views.Habitaciones.Categorias;
using Hotel.Views.Pedidos.Proveedores;
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
            validarDatosNecesarios();
        }
        private async void validarDatosNecesarios()
        {
            bool existeCategoria = false, existeProveedor = false;
            using (var cont = new HotelContext())
            {
                var catg = await new CategoriaProductoController(cont).GetAllObject();
                var prov = await new ProveedorController(cont).GetAllObjectAsync();

                if (catg.Count != 0)
                    existeCategoria = true;
                if (prov.Count != 0)
                    existeProveedor = true;
                if (existeProveedor && existeCategoria)
                {
                    validarProducto();
                    this.ShowDialog();
                }
                if (existeCategoria == false)
                {
                    if (MessageBox.Show(@"Para poder registrar un producto es necesario que exista al menos una categoria, ¿Desea registrar una categoria de producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        CategoriasViewRegister form = new CategoriasViewRegister(null);
                        form.ShowDialog();
                    }
                }
                if (existeProveedor == false)
                {
                    if (MessageBox.Show(@"Para poder registrar un producto es necesario que exista al menos un proveedor, ¿Desea registrar un proveedor?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        ProveedorViewRegister form = new ProveedorViewRegister(null);
                        form.ShowDialog();
                    }
                }
                this.Close();
            }
        }
        private async void mostrarCategorias()
        {
            using (var cont = new HotelContext())
            {
                cbxCategorias.DataSource = await new CategoriaProductoController(cont).GetAllObject();
                cbxCategorias.DisplayMember = "Descripcion";
            }
        }
        private async void mostrarProveedor()
        {
            using (var cont = new HotelContext())
            {
                cbxProveedores.DataSource = await new ProveedorController(cont).GetAllObjectAsync();
                cbxProveedores.DisplayMember = "NombreEmpresa";
            }
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
            mostrarProveedor();
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
                    var prov = cbxProveedores.SelectedItem as Proveedor;
                    if (producto != null)
                    {
                        Producto p = new Producto
                        {
                            ProductoId = producto.ProductoId,
                            Descripcion = txtNombre.Text,
                            Precio = Convert.ToDecimal(txtPrecio.Text),
                            CategoriaProductoId = cat.CategoriaProductoId,
                            ProveedorId = prov.ProveedorId,
                            Stock = 0
                            
                        };
                        controller.UpdateObject(p);
                        MessageBox.Show("Los datos del producto han sido actualizados correctamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Producto p = new Producto
                        {
                            Descripcion = txtNombre.Text,
                            Precio = Convert.ToDecimal(txtPrecio.Text),
                            CategoriaProductoId = cat.CategoriaProductoId,
                            ProveedorId = prov.ProveedorId,
                            Stock = 0
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
