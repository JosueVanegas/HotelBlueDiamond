using Hotel_Dorado_DesktopApp.Controllers;
using Hotel_Dorado_DesktopApp.Models;
using Hotel_Dorado_DesktopApp.Views.Habitaciones.Categorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Dorado_DesktopApp.Views.Habitaciones.Habitaciones
{
    public partial class HabitacionesViewRegister : Form
    {
        HotelDoradoContext context;
        HabitacionesController controller;
        Habitacion habitacion;
        public HabitacionesViewRegister(Habitacion habitacion)
        {
            InitializeComponent();
            context = new HotelDoradoContext();
            controller = new HabitacionesController(context);
            this.habitacion = habitacion;
            validarHabitacion();
            cargarComboBox();
        }
        private void validarHabitacion()
        {
            if(this.habitacion != null)
            {
                txtId.Text = habitacion.HabitacionId.ToString();
                txtDetalles.Text = habitacion.Detalles.ToString();
                txtNumero.Text = habitacion.Codigo.ToString();
                txtTarifa.Text = habitacion.PrecioPh.ToString();
                txtExtras.Text = habitacion.Extras.ToString();
            }
        }
        private void cargarComboBox()
        {
            if (mostrarCategorias() == true)
            {
                mostrarEstados();
                this.ShowDialog();
            }
            else
            {
                if (MessageBox.Show(@"Para poder registrar una habitación es necesario que exista al menos una categoria,Desea registrar una categoria de habitación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    CategoriaHabitacionViewRegister form = new CategoriaHabitacionViewRegister(null);
                    form.ShowDialog();
                }
                this.Dispose();
            }
        }
        private void mostrarEstados()
        {
            cbxPiso.DataSource = controller.GetPisoHabitacions();
            cbxPiso.DisplayMember = "Descripcion";

        }
        private bool mostrarCategorias()
        {
            cbxCategorias.DataSource = controller.GetCategoriaHabitacions();
            cbxCategorias.DisplayMember = "Descripcion";
            if (cbxCategorias.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool validarCampos()
        {
            if (txtDetalles.Text != "" && txtExtras.Text != "" && txtNumero.Text != "" && txtTarifa.Text != "")
                return true;
            else
                return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                try
                {
                    if (habitacion == null)
                    {
                        var piso = (Piso)cbxPiso.SelectedItem;
                        var categoria = (CategoriaHabitacion)cbxCategorias.SelectedItem;
                        Habitacion h = new Habitacion
                        {
                            Detalles = txtDetalles.Text,
                            Extras = txtExtras.Text,
                            EstadoId = 1,
                            PrecioPh = Convert.ToDecimal(txtTarifa.Text),
                            Codigo = txtNumero.Text,
                            PisoId = piso.PisoId,
                            CategoriaHabitacionId = categoria.CategoriaHabitacionId
                        };
                        controller.AddObject(h);
                        MessageBox.Show("Nueva habitación registrada correctamente","Registro exitoso",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos solicitados para poder registrar la habitación","Validación",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
