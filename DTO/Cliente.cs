using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TareaEV3.DTO
{
    public class Cliente : INotifyPropertyChanged
    {
        private string _dni;
        private string _nombre;
        private string _apellidos;
        private string _correo;
        private string _telefono;
        private List<string> _matriculasCompradas;

        public string DNI
        {
            get => _dni;
            set
            {
                _dni = value;
                OnPropertyChanged(nameof(DNI));
            }
        }

        public string Nombre
        {
            get => _nombre;
            set
            {
                _nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }

        public string Apellidos
        {
            get => _apellidos;
            set
            {
                _apellidos = value;
                OnPropertyChanged(nameof(Apellidos));
            }
        }

        public string Correo
        {
            get => _correo;
            set
            {
                _correo = value;
                OnPropertyChanged(nameof(Correo));
            }
        }

        public string Telefono
        {
            get => _telefono;
            set
            {
                _telefono = value;
                OnPropertyChanged(nameof(Telefono));
            }
        }

        public List<string> MatriculasCompradas
        {
            get => _matriculasCompradas;
            set
            {
                _matriculasCompradas = value;
                OnPropertyChanged(nameof(MatriculasCompradas));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Cliente()
        {
            Nombre = "Nombre";
            Apellidos = "Apellidos";
            DNI = "DNI";
            Telefono = "Teléfono";
            MatriculasCompradas = new List<string>();
        }

        public Cliente(string nombre, string apellidos, string dni, string telefono)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            DNI = dni;
            Telefono = telefono;
            MatriculasCompradas = new List<string>();
        }
    }
}
