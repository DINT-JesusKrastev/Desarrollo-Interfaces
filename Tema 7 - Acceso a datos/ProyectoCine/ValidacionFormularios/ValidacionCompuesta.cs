using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.ValidacionFormularios
{
    public class ValidacionCompuesta
    {
        private List<Validacion> validaciones;
        public bool HayError
        {
            get { return validaciones.Any(validacion => validacion.HayError); }
        }
        public string MensajeError
        {
            get { return validaciones.FirstOrDefault(validacion => validacion.HayError)?.MensajeError ?? ""; }
        }

        public ValidacionCompuesta()
        {
            this.validaciones = new List<Validacion>();
        }

        public ValidacionCompuesta Add(Validacion validacion)
        {
            this.validaciones.Add(validacion);

            return this;
        }
    }
}
