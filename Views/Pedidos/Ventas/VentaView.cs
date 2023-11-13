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

namespace Hotel.Views.Pedidos.Ventas
{
    public partial class VentaView : Form
    {
        CompraController controller;
        public VentaView()
        {
            InitializeComponent();
            showPurchase();
        }
        private void showPurchase()
        {
            
        }
        private async void carouselHub()
        {
            using(var context = new HotelContext())
            {
                controller = new CompraController(context);
                var list = await controller.GetAllObject();
                foreach(var item in list)
                {
                    var panel = new Panel
                    {
                        Height = 100,
                        Width = 120,
                        BackColor = Color.White,

                    };
                    var HNumber = new Label
                    {
                        Text = ""
                    };
                    panel.Controls.Add(HNumber);
                }
            }
        }

    }
}
