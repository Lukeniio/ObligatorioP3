using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ExcepcionesEntidades
{
    public class DireccionPostalException:Exception
    {
        public DireccionPostalException() { }

        public DireccionPostalException(string message) : base(message) { }

        public DireccionPostalException(string message, Exception innerException) : base(message, innerException) { }
    }
}

