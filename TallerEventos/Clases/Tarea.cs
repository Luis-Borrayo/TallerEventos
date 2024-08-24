using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEventos.Clases
{
    internal class Tarea
    {
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public readonly DateTime FechaCreacion;

        public Tarea(string Nombre, string Estado)
        {
            this.Nombre = Nombre;
            this.Estado = Estado;
            this.FechaCreacion = DateTime.Now;

        }
    }
}
