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
using TareaEV3.Negocio;

namespace TareaEV3.Vistas
{
    /// <summary>
    /// Lógica de interacción para Clientes.xaml
    /// </summary>
    public partial class Clientes : Window
    {
        private List<DTO.Cliente> _clientes;
        public Clientes(Concesionario concesionario)
        {
            InitializeComponent();
            this._clientes = concesionario.Clientes;
            dataGridClientes.DataContext = _clientes;
        }

    }
}
