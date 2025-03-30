using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocio.ValueObjects;
namespace LogicaNegocio.EntidadesNegocio
{
    public class Agencia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DireccionPostal DireccionPostal { get; set; }
        public string Ubicacion { get; set; }
        public Agencia(int id, string nombre, DireccionPostal direccionPostal, string ubicacion)
        {
            Id = id;
            Nombre = nombre;
            DireccionPostal = direccionPostal;
            Ubicacion = ubicacion;
        }
    }
}
