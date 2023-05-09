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
    /// <summary>
    /// Lógica de interacción para NuevoCoche.xaml
    /// </summary>
    public partial class NuevoCoche : Window
    {
        private Concesionario concesionario;
        private Coche nuevo;

        public NuevoCoche(Concesionario concesionario)
        {
            InitializeComponent();
            nuevo = new Coche();
            DataContext = nuevo;
            this.concesionario = concesionario;
        }

        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {
            concesionario.AnadirCoche(nuevo);
            MessageBox.Show("Coche guardado correctamente.");
            Close();
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
