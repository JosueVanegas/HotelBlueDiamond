using Hotel.Controllers;
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
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Views.Informes
{
    public partial class CrearInformePDF : Form
    {
        HotelContext context;
        GraficasController controller;
        int tipoInforme;
        public CrearInformePDF(int tipoInforme)
        {
            InitializeComponent();
            this.context = new HotelContext();
            this.context = new HotelContext();
            this.controller = new GraficasController(context);
            this.tipoInforme = tipoInforme;
            fechaInicio.MaxDate = DateTime.Now;
            cambiarEncabezado();
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
            if (fechaInicio != null && fechaFinal != null)
            {
                seleccionarInforme();
            }
        }
        private void fechaInicio_ValueChanged(object sender, EventArgs e)
        {
            fechaFinal.MaxDate = DateTime.Now;
        }
        private void seleccionarInforme()
        {
            switch (tipoInforme)
            {
                case 2:
                    informeReservacion();
                    break;
                case 3:
                    informeNomina();
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }
        private void informeNomina()
        {
            var doc = QuestPDF.Fluent.Document.Create(container =>
            {
                const string colorFondoInventario = "#439EBE";
                const string transparentBlue = "#439EBE ";
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
                            column.Item().AlignCenter().Text("Reporte de nomina").FontSize(25);
                            column.Item().AlignCenter().Text(txt =>
                            {
                                txt.Span("Desde: " + fechaInicio.Value.ToString() + " Hasta: " + fechaFinal.Value.ToString()).FontSize(15);
                                txt.Span(DateTime.Now.ToString()).FontSize(15);

                            });
                            column.Spacing(30);

                            column.Item().LineHorizontal(0.5f);
                            column.Item().AlignCenter().Text("Nomina").FontSize(15);


                            column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                            {
                                tab.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(4);
                                });

                                tab.Header(het =>
                                {
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cedula").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Nombre completo").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cargo").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Salario fijo").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("comiciones").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("salario devengado").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("INSS").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("IR").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total deducciones").FontSize(10);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Salario neto").FontSize(10);
                                });

                                var lista = controller.DataNomina();
                                decimal totalNomina = 0, totalINSS = 0,totalIR = 0;                             
                                foreach (var i in lista)
                                {
                                    decimal totalComicion = controller.bonificacion(fechaInicio.Value, fechaFinal.Value, i.EmpleadoId);
                                    decimal salarioDevengado = totalComicion + Convert.ToDecimal(i.Cargo.SalarioBasePh);
                                    var ir = controller.calcularIR(salarioDevengado);
                                    var inss = salarioDevengado * Convert.ToDecimal(0.07);
                                    var totalDeducciones = ir + inss;
                                    var salarioNeto = salarioDevengado - totalDeducciones;
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Cedula).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Nombre + " " + i.Apellido).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Cargo.Descripcion).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Cargo.SalarioBasePh).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(totalComicion.ToString("0.00")).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(salarioDevengado.ToString("0.00")).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(inss.ToString("0.00")).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(ir.ToString("0.00")).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(totalDeducciones.ToString("0.00")).FontSize(11);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(salarioNeto.ToString("0.00")).FontSize(11);
                                    totalNomina += salarioNeto;
                                    totalINSS += inss;
                                    totalIR += ir;
                                }
                                column.Item().Row(row =>
                                {
                                    row.RelativeItem().Column(col =>
                                    {
                                        col.Item().AlignRight().Text(txt =>
                                        {
                                            txt.Span("  Nomina total a pagar: " + totalNomina.ToString("0.00") + " C$").FontSize(15);
                                            txt.Span("      Total INNS: " + totalINSS.ToString("0.00") + " C$").FontSize(15);
                                            txt.Span("      Total IR " + totalIR.ToString("0.00") + " C$").FontSize(15);
                                        });
                                    });
                                });
                            });

                        });
                        
                    }           );
                    page.Footer().Column(c =>
                    {
                        c.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Pagina  ").FontSize(10);
                            txt.CurrentPageNumber().FontSize(10);
                            txt.Span("  de  ").FontSize(10);
                            txt.TotalPages().FontSize(10);
                        });      
                    });
                });
                
            });
            QuestPDF.Settings.License = LicenseType.Community;
            var filePath = "informeNomina.pdf";
            doc.GeneratePdf(filePath);
            Process.Start("explorer.exe", filePath);
        }
        private void informeReservacion()
        {
            var doc = QuestPDF.Fluent.Document.Create(container =>
            {
                const string colorFondoInventario = "#439EBE";
                const string transparentBlue = "#439EBE ";
                var lista = controller.DatosReserva(fechaInicio.Value, fechaFinal.Value);
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
                            column.Item().AlignCenter().Text("Reporte de reservaciones realizadas").FontSize(25);
                            column.Item().AlignCenter().Text(txt =>
                            {
                                txt.Span("Desde: " + fechaInicio.Value.ToString() + " Hasta: " + fechaFinal.Value.ToString()).FontSize(15);

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


                            column.Item().AlignCenter().Text("Reservaciones del periodo seleccionado").FontSize(15);


                            column.Item().Background(Colors.Grey.Lighten3).Table(tab =>
                            {
                                tab.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(4);
                                    columns.RelativeColumn(4);
                                });

                                tab.Header(het =>
                                {
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("#Habitación").FontSize(7);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cliente").FontSize(7);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Empleado").FontSize(7);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Precio noche").FontSize(7);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Cantidad horas").FontSize(7);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Subtotal habitación").FontSize(7);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total servicio").FontSize(7);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total daños").FontSize(7);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Adelanto").FontSize(7);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Total pagado").FontSize(7);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha entrada").FontSize(7);
                                    het.Cell().Border(1).Background(transparentBlue).Padding(1).Text("Fecha salida").FontSize(7);
                                });
                                decimal totalGanacia = 0;
                                foreach (var i in lista)
                                {
                                    var totalServicio = controller.DetallePedido(i.ReservaId);
                                    var horasReservadas = i.HorasReservadas == 0 ? 1 : i.HorasReservadas;
                                    var subTotalHabitacion = i.Habitacion.PrecioPh * horasReservadas;
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Habitacion.Codigo).FontSize(7);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Cliente.Cedula).FontSize(5);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Empleado.Cedula).FontSize(5);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Habitacion.PrecioPh).FontSize(7);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(horasReservadas).FontSize(7);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(subTotalHabitacion).FontSize(7);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(totalServicio).FontSize(7);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.TotalDaños).FontSize(7);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Adelanto).FontSize(7);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.Total).FontSize(7);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.FechaEntrada).FontSize(7);
                                    tab.Cell().BorderHorizontal(0.5f).AlignCenter().Text(i.FechaSalida).FontSize(7);
                                }
                                column.Item().Row(row =>
                                {
                                    row.RelativeItem().Column(col =>
                                    {
                                        col.Item().AlignRight().Text(txt =>
                                        {
                                            txt.Span("      Total ganado en reservaciones: " + totalGanacia + " C$").FontSize(15);
                                        });
                                    });
                                });
                            });

                        });
                    });
                    page.Footer().Column(c =>
                    {
                        c.Item().AlignCenter().Text(txt =>
                        {
                            txt.Span("Pagina  ").FontSize(10);
                            txt.CurrentPageNumber().FontSize(10);
                            txt.Span("  de  ").FontSize(10);
                            txt.TotalPages().FontSize(10);
                        });
                    });
                });
            });
            QuestPDF.Settings.License = LicenseType.Community;
            var filePath = "informeReservas.pdf";
            doc.GeneratePdf(filePath);
            Process.Start("explorer.exe", filePath);
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
