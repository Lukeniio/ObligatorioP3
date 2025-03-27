using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Urgente : Envio
    {

        public string DireccionPostal { get; set; }
        public bool EntregaEficiente { get; set; }

        public Urgente(int id,
                       string numTracking,
                       Usuario empleado,
                       Usuario cliente,
                       double pesoPaquete,
                       Estado estado,
                       string dirPostal) : 
                       base(id,
                            numTracking,
                            empleado,
                            cliente,
                            pesoPaquete,
                            estado)
        {
            DireccionPostal = dirPostal;
        }

    }
}
