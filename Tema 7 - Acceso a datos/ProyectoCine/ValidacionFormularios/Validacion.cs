using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProyectoCine.ValidacionFormularios
{
    public class Validacion
    {
        public bool HayError { get; set; }
        public string MensajeError { get; set; }

        public Validacion(bool HayError = false, string MensajeError = "") 
        { 
            this.HayError = HayError;
            this.MensajeError = MensajeError;
        }
    }
}
