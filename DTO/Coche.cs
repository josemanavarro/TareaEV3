using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TareaEV3.DTO
{

    public class Coche : INotifyPropertyChanged
    {
        private string _matricula;
        public string Matricula
        {
            get => _matricula;
            set
            {
                _matricula = value;
                OnPropertyChanged(nameof(Matricula));
            }
        }

        private string _marca;
        public string Marca
        {
            get => _marca;
            set
            {
                _marca = value;
                OnPropertyChanged(nameof(Marca));
            }
        }

        private string _modelo;
        public string Modelo
        {
            get => _modelo;
            set
            {
                _modelo = value;
                OnPropertyChanged(nameof(Modelo));
            }
        }

        private int _cilindrada;
        public int Cilindrada
        {
            get => _cilindrada;
            set
            {
                _cilindrada = value;
                OnPropertyChanged(nameof(Cilindrada));
            }
        }

        private int _potencia;
        public int Potencia
        {
            get => _potencia;
            set
            {
                _potencia = value;
                OnPropertyChanged(nameof(Potencia));
            }
        }

        private int _kilometros;
        public int Kilometros
        {
            get => _kilometros;
            set
            {
                _kilometros = value;
                OnPropertyChanged(nameof(Kilometros));
            }
        }

        private decimal _precio;
        public decimal Precio
        {
            get => _precio;
            set
            {
                _precio = value;
                OnPropertyChanged(nameof(Precio));
            }
        }

        private DateTime _fechaFabricacion;
        public DateTime FechaFabricacion
        {
            get => _fechaFabricacion;
            set
            {
                _fechaFabricacion = value;
                OnPropertyChanged(nameof(FechaFabricacion));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Coche(
            string matricula,
            string marca,
            string modelo,
            int cilindrada,
            int potencia,
            int kilometros,
            decimal precio,
            DateTime fechaFabricacion)
        {
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
            Potencia = potencia;
            Kilometros = kilometros;
            Precio = precio;
            FechaFabricacion = fechaFabricacion;
        }
        public Coche()
        {
            Matricula = "";
            Marca = "";
            Modelo = "";
            Cilindrada = 0;
            Potencia = 0;
            Kilometros = 0;
            Precio = 0;
            FechaFabricacion = DateTime.Now;
        }
    }
}
