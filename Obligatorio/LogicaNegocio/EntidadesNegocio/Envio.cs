using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public abstract class Envio
    {
        public int Id { get; set; }
        public string NumTracking { get; set; }
        public Usuario Empleado { get; set; }
        public Usuario Cliente { get; set; }
        public double PesoPaquete { get; set; }
        public Estado Estado { get; set; }
        public List<Comentario> Comentarios { get; set; }

        public Envio(string numTracking, Usuario empleado, Usuario cliente, double pesoPaquete, Estado estado)
        {
            NumTracking = numTracking;
            Empleado = empleado;
            Cliente = cliente;
            PesoPaquete = pesoPaquete;
            Estado = estado;
        }
    }
}
