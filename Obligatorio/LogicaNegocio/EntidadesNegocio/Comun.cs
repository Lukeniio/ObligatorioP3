using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Comun : Envio
    {
        public Agencia Agencia { get; set; }
        public Comun(string numTracking, Usuario empleado, Usuario cliente, double pesoPaquete, Estado estado, Agencia agencia) : base(numTracking, empleado, cliente, pesoPaquete, estado)
        {
            Agencia = agencia;
        }
    }
}
