using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaEV3.DTO;

namespace TareaEV3.Negocio
{
    public class Concesionario
    {
        private List<DTO.Coche> _cochesEnVenta;
        private List<DTO.Coche> _cochesVendidos;
        private List<DTO.Cliente> _clientes;

        public Concesionario()
        {
            _cochesEnVenta = new List<DTO.Coche>();
            _cochesVendidos = new List<DTO.Coche>();
            _clientes = new List<DTO.Cliente>();
        }

        public List<DTO.Coche> CochesEnVenta => _cochesEnVenta;
        public List<DTO.Coche> CochesVendidos => _cochesVendidos;
        public List<DTO.Cliente> Clientes => _clientes;

        public void AnadirCoche(DTO.Coche coche)
        {
            _cochesEnVenta.Add(coche);
        }

        public void EditarCoche(DTO.Coche coche)
        {
            var indice = _cochesEnVenta.FindIndex(c => c.Matricula == coche.Matricula);
            if (indice != -1)
            {
                _cochesEnVenta[indice] = coche;
            }
        }

        public void BorrarCoche(DTO.Coche coche)
        {
            _cochesEnVenta.RemoveAll(c => c.Matricula == coche.Matricula);
        }

        public List<string> ListarMatriculasEnVenta()
        {
            return _cochesEnVenta.Select(c => c.Matricula).ToList();
        }

        public decimal CalcularCosteStock()
        {
            return _cochesEnVenta.Sum(c => c.Precio);
        }

        public void VenderCoche(DTO.Coche coche, DTO.Cliente cliente)
        {
            _cochesVendidos.Add(coche);
            _cochesEnVenta.Remove(coche);

            var clienteExistente = _clientes.FirstOrDefault(c => c.DNI == cliente.DNI);
            if (clienteExistente != null)
            {
                clienteExistente.MatriculasCompradas.Add(coche.Matricula);
            }
            else
            {
                cliente.MatriculasCompradas = new List<string> { coche.Matricula };
                _clientes.Add(cliente);
            }
        }

        public void AnadirCliente(Cliente nuevoCliente)
        {
            _clientes.Add(nuevoCliente);
        }
    }
}
