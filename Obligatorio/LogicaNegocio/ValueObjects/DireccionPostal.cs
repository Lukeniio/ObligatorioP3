using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocio.ExcepcionesEntidades;
namespace LogicaNegocio.ValueObjects
{
    public record DireccionPostal
    {
        public string Valor { get; init; }

        public DireccionPostal(string valor)
        {
            Valor = valor;
            Validar();
        }
        private void Validar()
        {
            if (string.IsNullOrEmpty(Valor))
            {
                throw new DireccionPostalException("La direccion postal es obligatoria");
            }
        }
    }
}
