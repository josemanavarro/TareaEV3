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
    /// Lógica de interacción para CochesEnVenta.xaml
    /// </summary>
    public partial class CochesEnVenta : Window
    {
        List<Coche> coches;
        public CochesEnVenta(Concesionario concesionario)
        {
            InitializeComponent();
            coches = concesionario.CochesEnVenta;
            DataContext = new CochesViewModel(coches);
        }
    }
    public class CochesViewModel
    {
        public List<Coche> Coches { get; set; }

        public CochesViewModel(List<Coche> coches)
        {
            Coches = coches;
        }
    }
}
