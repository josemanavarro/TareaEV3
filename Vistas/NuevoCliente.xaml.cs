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
using System.Windows.Shapes;
using TareaEV3.DTO;
using TareaEV3.Negocio;

namespace TareaEV3.Vistas
{
    public partial class NuevoCliente : Window
    {
        private Cliente nuevoCliente;
        private Concesionario concesionario;

        public NuevoCliente(Concesionario concesionario)
        {
            InitializeComponent();
            this.concesionario = concesionario;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            nuevoCliente = new Cliente(tbNombre.Text, tbApellidos.Text, tbDNI.Text, tbTelefono.Text)
            {
                Correo = tbCorreo.Text
            };

            concesionario.AnadirCliente(nuevoCliente);

            MessageBox.Show("Cliente guardado correctamente.");

            Close();
        }
    }
}





