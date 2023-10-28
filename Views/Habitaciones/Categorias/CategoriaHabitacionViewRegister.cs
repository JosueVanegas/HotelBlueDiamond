using Hotel_Dorado_DesktopApp.Controllers;
using Hotel_Dorado_DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Dorado_DesktopApp.Views.Habitaciones.Categorias
{
    public partial class CategoriaHabitacionViewRegister : Form
    {
        HotelDoradoContext context;
        CategoriaHabitacionesController controller;
        CategoriaHabitacion categoria;
        public CategoriaHabitacionViewRegister(CategoriaHabitacion categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            context = new HotelDoradoContext();
            controller = new CategoriaHabitacionesController(context);
            validarObjeto();
        }
        private void validarObjeto()
        {
            if (this.categoria != null)
            {
                txtId.Text = categoria.CategoriaHabitacionId.ToString();
                txtDescripcion.Text = categoria.Descripcion.ToString();
                txtCapacidad.Text = categoria.Capacidad.ToString();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "" && txtCapacidad.Text != "")
            {
                try
                {
                    if (categoria == null)
                    { 
                        CategoriaHabitacion categoriaHabitacion = new CategoriaHabitacion
                        {

                            Descripcion = txtDescripcion.Text,
                            Capacidad = Convert.ToInt32(txtCapacidad.Text)
                        };
                        controller.AddObject(categoriaHabitacion);
                        MessageBox.Show("Se ha registrado la nueva categoria correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    }
                    else
                    {
                        CategoriaHabitacion categoriaHabitacion = new CategoriaHabitacion
                        {
                            CategoriaHabitacionId = categoria.CategoriaHabitacionId,
                            Descripcion = txtDescripcion.Text,
                            Capacidad = Convert.ToInt32(txtCapacidad.Text)
                        };
                        controller.UpdateObject(categoriaHabitacion);
                        MessageBox.Show("Datos de la categoria actualizados correctamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos antes de guardar cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
