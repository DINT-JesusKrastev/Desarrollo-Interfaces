using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public string Nacionalidad { get; set; }

        public Persona(string Nombre, int Edad, string Nacionalidad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Nacionalidad = Nacionalidad;
        }
    }
}
