using LogicaNegocio.ExcepcionesEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObjects
{
    public class Ubicacion
    {
        public string Latitud { get; init; }
        public string Longitud { get; init; }

        public Ubicacion(string latitud, string longitud)
        {
            Latitud = latitud;
            Longitud = longitud;
            Validar();
        }
        private void Validar()
        {
            if (string.IsNullOrEmpty(Latitud))
            {
                throw new UsuarioException("La latitud es obligatoria");
            }
            if (string.IsNullOrEmpty(Longitud))
            {
                throw new UsuarioException("La longitud es obligatoria");
            }
        }
    }
}
