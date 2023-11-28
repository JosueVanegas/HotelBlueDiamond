using Hotel.Models;
using Microcharts;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Views.Informes
{
    public partial class CrearInformePDF : Form
    {
        HotelContext context;
        int tipoInforme;
        public CrearInformePDF(int tipoInforme)
        {
            InitializeComponent();
            this.context = new HotelContext();
            this.tipoInforme = tipoInforme;
            fechaInicio.MaxDate = DateTime.Now;
        }
        private void cambiarEncabezado()
        {
            switch (tipoInforme)
            {
                case 1:
                    lblTipoReporte.Text = "Reporte de inventario";
                    break;
                case 2:
                    lblTipoReporte.Text = "Reporte de reservaciones";
                    break;
                case 3:
                    lblTipoReporte.Text = "Reporte de nomina";
                    break;
                default:
                    break;
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }
        private void fechaInicio_ValueChanged(object sender, EventArgs e)
        {
            fechaFinal.MaxDate = DateTime.Now;
        }
        private void seleccionarInforme()
        {
            switch (tipoInforme)
            {
                case 1:
                    informeInventario();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }
        private void informeInventario()
        {
            var doc = Document.Create(container =>
            {
                const string colorFondoInventario = "#439EBE";
                const string transparentBlue = "#439EBE ";
                var context = new HotelContext();
                var listaProductos = context.Productos.Include(c => c.CategoriaProducto).ToList();
                var listaMasVendidos = context.DetallePedidos.Include(d => d.Producto).Take(10).ToList();
                container.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.Margin(10);
                    page.DefaultTextStyle(TextStyle.Default.FontSize(16));
                    page.PageColor(Colors.White);
                    page.Background().AlignTop().ExtendHorizontal().Height(110).Background(colorFondoInventario);
                    page.Foreground().AlignBottom().ExtendHorizontal().Height(50).Background(transparentBlue);

                    page.Header().Column(c =>
                    {
                        c.Item().Row(row =>
                        {
                            row.ConstantItem(40).Border(0).Background(Colors.Transparent).Height(100).Column(col =>
                            {

                            });
                            row.RelativeItem().Border(0).Background(Colors.Transparent).Height(100).Column(col =>
                            {
                                col.Item().AlignCenter().Text("Blue Diamond").FontSize(30).Bold();
                                col.Item().AlignCenter().Text("Teléfono: +505 8349-2395").FontSize(9);
                                col.Item().AlignCenter().Text("Correo electronico: BlueDiamond@gmail.com").FontSize(9);
                                col.Item().AlignCenter().Text("Direccion: Managua,managua costado sur de metrocentro").FontSize(9);
                            });
                            row.ConstantItem(40).Border(0).Background(Colors.Transparent).Height(100);
                        });
                    });

                    page.Content().Column(c =>
                    {
                        c.Item().PaddingVertical(25).Column(column =>
                        {
                            column.Item().AlignCenter().Text("Reporte de inventario").FontSize(25);
                            column.Item().AlignCenter().Text(txt =>
                            {
                                txt.Span("Fecha de elaboración del informe: ").FontSize(15);
                                txt.Span(DateTime.Now.ToString()).FontSize(15);

                            });
                            column.Spacing(30);

                            column.Item().LineHorizontal(0.5f);


                            /*
                             * var entries = new List<ChartEntry>();
                          CultureInfo cultureInfo = new CultureInfo("es-ES");
                          foreach (var i in listaMasVendidos)
                          {
                              entries.Add(new ChartEntry((float)i.Cantidad)
                              {
                                  Label = i.Producto.Descripcion,
                                  ValueLabel = i.Cantidad.ToString(),
                                  Color = SKColor.Parse("#87CEEB")
                              });
                          }
                          column.Item().Column(column =>
                          {
                              var titleStyle = TextStyle
                                .Default
                               .FontSize(15)
                               .SemiBold()
                                 .FontColor(Colors.Blue.Medium);
                              column
                                  .Item()
                                  .PaddingBottom(1)
                                  .Text("Grafica de los 10 productos y sus cantidades más vendidos hasta la fecha")
                               .Style(titleStyle);

                              column
                            .Item()
                         .Border(1)
                         .ExtendHorizontal()
                         .Height(200)
                            .Canvas((canvas, size) =>
                            {
                                var chart = new BarChart
                                {
                                    Entries = entries,

                                    LabelOrientation = Microcharts.Orientation.Horizontal,
                                    ValueLabelOrientation = Microcharts.Orientation.Horizontal,

                                    IsAnimated = false,
                                };

                                chart.DrawContent(canvas, (int)size.Width, (int)size.Height);
                            });
                          });

                          column.Spacing(10);
                             */


                            column.Item().AlignCenter().Text("Inventario actual").FontSize(15);


                            column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                            {
                                tab.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(3);
                                });

                                tab.Header(het =>
                                {
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Producto").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Categoria").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Precio unitario").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Stock").FontSize(10);

                                });
                                decimal valorInventario = 0;
                                foreach (var i in listaProductos)
                                {
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Descripcion).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.CategoriaProducto.Descripcion).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Precio).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Stock).FontSize(11);
                                    valorInventario += Convert.ToDecimal(i.Precio * i.Stock);

                                }
                                column.Item().Row(row =>
                                {
                                    row.RelativeItem().Column(col =>
                                    {
                                        col.Item().AlignRight().Text(txt =>
                                        {
                                            txt.Span("      Valor del inventario actual: " + valorInventario + " C$").FontSize(15);
                                        });
                                    });
                                });
                            });

                        });
                    });
                });
            });
            QuestPDF.Settings.License = LicenseType.Community;
            var filePath = "informeInventario.pdf";
            doc.GeneratePdf(filePath);
            Process.Start("explorer.exe", filePath);
        }

       
    }
}
