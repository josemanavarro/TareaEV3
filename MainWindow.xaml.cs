using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TareaEV3.Negocio;
using TareaEV3.Vistas;

namespace TareaEV3
{
    public partial class MainWindow : Window
    {
        private Concesionario concesionario;
        public MainWindow()
        {
            InitializeComponent();
            concesionario = new Concesionario();
        }

        private void NuevoCliente_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para abrir el formulario de nuevo cliente
            NuevoCliente ventanaNuevoCliente = new NuevoCliente(concesionario);
            ventanaNuevoCliente.Owner = this;
            ventanaNuevoCliente.ShowDialog();
        }

        private void NuevoCoche_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para abrir el formulario de nuevo coche
            NuevoCoche ventanaNuevoCoche = new NuevoCoche(concesionario);
            ventanaNuevoCoche.Owner = this;
            ventanaNuevoCoche.ShowDialog();
        }

        private void NuevaVenta_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para abrir el formulario de nueva venta
            VentanaVenta ventanaVenta = new VentanaVenta(concesionario);
            ventanaVenta.Owner = this;
            ventanaVenta.ShowDialog();
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AcercaDe_Click(object sender, RoutedEventArgs e) 
        { 
            // Lógica para abrir la ventana de Acerca de
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.Owner = this;
            acercaDe.ShowDialog();
        }
    private void ListarCochesEnStock_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para abrir la ventana de CochesEnVenta
            CochesEnVenta ventanaCochesEnVenta = new CochesEnVenta(concesionario);
            ventanaCochesEnVenta.Owner = this;
            ventanaCochesEnVenta.ShowDialog();
        }
        private void ListarCochesVendidos_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para abrir la ventana de Acerca de
            CochesVendidos ventanaCochesVendidos = new CochesVendidos(concesionario);
            ventanaCochesVendidos.Owner = this;
            ventanaCochesVendidos.ShowDialog();
        }
        private void ListarClientes_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para abrir la ventana de Acerca de
            Clientes ventanaClientes = new Clientes(concesionario);
            ventanaClientes.Owner = this;
            ventanaClientes.ShowDialog();
        }
    }
}
