using LogicaNegocio.ExcepcionesEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObjects
{
    public record Password
    {
        public string Valor { get; init; }

        public Password(string valor)
        {
            Valor = valor;
            Validar();
        }
        private void Validar()
        {
            if (string.IsNullOrEmpty(Valor))
            {
                throw new UsuarioException("La contraseña es obligatoria");
            }
        }
    }
}
