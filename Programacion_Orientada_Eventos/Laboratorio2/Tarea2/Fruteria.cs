using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_Orientada_Eventos.Laboratorio2.Tarea2
{
    public partial class Fruteria : Form
    {
        private List<Fruta> frutas;
        private List<Cliente> clientes;
        private List<Venta> ventas;

        public Fruteria()
        {
            InitializeComponent();
            frutas = new List<Fruta>();
            clientes = new List<Cliente>();
            ventas = new List<Venta>();
        }
        private void Fruteria_Load(object sender, EventArgs e) 
        {
            frutas.Add(new Fruta { Nombre = "Naranja", Precio = 1.5m, CantidadDisponible = 50 });
            frutas.Add(new Fruta { Nombre = "Banana", Precio = 0.5m, CantidadDisponible = 10 });

            clientes.Add(new Cliente { Nombre = "Cliente 1", TotalCompras = 7});
            clientes.Add(new Cliente { Nombre = "Cliente 2", TotalCompras = 4 });

            foreach (Fruta fruta in frutas)
            {
                listBoxFrutas.Items.Add(fruta);
            }
        }
       
        private void listBoxFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFrutas.SelectedIndex >= 0)
            {
                {
                    Fruta frutaSeleccionada = frutas[listBoxFrutas.SelectedIndex];
                    labelPrecio.Text = $"Precio: {frutaSeleccionada.Precio:C}";
                    labelCantidadDisponible.Text = $"Cantidad disponible: {frutaSeleccionada.CantidadDisponible}";
                }
            }
        }
        
        private void buttonNuevaVenta_Click(object sender, EventArgs e)
        {
            if (listBoxFrutas.SelectedIndex >= 0 && comboBoxClientes.SelectedIndex >= 0)
            {
                Fruta frutaSeleccionada = frutas[listBoxFrutas.SelectedIndex];
                Cliente clienteSeleccionado = clientes[comboBoxClientes.SelectedIndex];

                int cantidadVenta = (int)numericUpDownCantidad.Value;

                if (frutaSeleccionada.CantidadDisponible >= cantidadVenta)
                {
                    decimal precioTotal = frutaSeleccionada.Precio * cantidadVenta;
                    frutaSeleccionada.CantidadDisponible -= cantidadVenta;
                    clienteSeleccionado.TotalCompras += 1;

                    ventas.Add(new Venta
                    {
                        Fruta = frutaSeleccionada,
                        PrecioVenta = frutaSeleccionada.Precio,
                        Cantidad = cantidadVenta,
                        Cliente = clienteSeleccionado,
                        
                    });

                    MessageBox.Show($"Venta realizada:\n" +
                        $"Fruta: {frutaSeleccionada.Nombre}\n" +
                        $"Cliente: {clienteSeleccionado.Nombre}\n" +
                        $"Cantidad: {cantidadVenta}\n" +
                        $"Total: {precioTotal:C}");

                }
                else
                {
                    MessageBox.Show("No hay suficiente cantidad disponible.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fruta y un cliente.");
            }
        }

     
    }
}
