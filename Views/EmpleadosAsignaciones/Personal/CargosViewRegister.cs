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

namespace Hotel.Views.EmpleadosAsignaciones.Personal
{
    public partial class CargosViewRegister : Form
    {
        HotelContext context;
        Cargo cargo;
        public CargosViewRegister(Cargo cargo)
        {
            InitializeComponent();
            this.cargo = cargo;
            context = new HotelContext();
            validarObjeto();
        }
        private void validarObjeto()
        {
            if (cargo != null)
            {
                lblTitulo.Text = "Actualizar cargo";
                txtDescripcion.Text = cargo.Descripcion;
                txtSalario.Text = cargo.SalarioBasePh.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcion.Text != "" && txtSalario.Text != "")
                {
                    var controller = new CargosController(context);
                    if(cargo != null)
                    {
                        var c = new Cargo
                        {
                            CargoId = cargo.CargoId,
                            Descripcion = txtDescripcion.Text,
                            SalarioBasePh = Convert.ToDecimal(txtSalario.Text)
                        };
                        controller.UpdateObject(c);
                        MessageBox.Show("Cargo actualizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var c = new Cargo
                        {
                            Descripcion = txtDescripcion.Text,
                            SalarioBasePh = Convert.ToDecimal(txtSalario.Text)
                        };
                        controller.AddObject(c);
                        MessageBox.Show("Nuevo cargo registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
