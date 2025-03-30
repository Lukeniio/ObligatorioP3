using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Comentario
    {
        public string Texto { get; set; } 
        public DateTime Fecha{ get; set; } 
        public Usuario Autor{ get; set; } 

        public Comentario(string texto, Usuario usuario)
        {
            Texto = texto;
            Autor = usuario;
            Fecha = DateTime.Now;
        }
    }
}
