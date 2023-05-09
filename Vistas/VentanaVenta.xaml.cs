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

namespace TareaEV3.Vistas
{
    /// <summary>
    /// Lógica de interacción para VentanaVenta.xaml
    /// </summary>
    public partial class VentanaVenta : Window
    {
        private Concesionario concesionario;

        public VentanaVenta()
        {
            InitializeComponent();
        }

        public VentanaVenta(Concesionario concesionario)
        {
            this.concesionario = concesionario;
        }
    }
}
