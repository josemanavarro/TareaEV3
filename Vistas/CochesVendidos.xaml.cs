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
    /// Lógica de interacción para CochesVendidos.xaml
    /// </summary>
    public partial class CochesVendidos : Window
    {
        List<Coche> coches;
        public CochesVendidos(Concesionario concesionario)
        {
            InitializeComponent();
            coches = concesionario.CochesEnVenta;
            DataContext = new CochesViewModel(coches);
        }
    }
}
