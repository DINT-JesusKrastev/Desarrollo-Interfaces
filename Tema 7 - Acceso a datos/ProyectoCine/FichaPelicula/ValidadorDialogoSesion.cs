using ProyectoCine.ValidacionFormularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.FichaPelicula
{
    public class ValidadorDialogoSesion
    {
        private ValidacionCompuesta validacionCompuesta;

        public ValidadorDialogoSesion()
        {
            this.validacionCompuesta = new ValidacionCompuesta();
        }

        public ValidacionCompuesta valida(string idPelicula, string idSala, string hora)
        {
            validacionCompuesta
                .Add(new Validacion(!Validador.ValidarTextoNoVacio(idPelicula), "La película no debe estar vacía"))
                .Add(new Validacion(!Validador.ValidarTextoNoVacio(idSala), "La sala no puede estar vacía"))
                .Add(new Validacion(!Validador.ValidarTextoNoVacio(hora), "La hora no puede estar vacía"))
                .Add(new Validacion(!Validador.ValidarHora(hora), "El formato de la hora no es correcto"));

            return validacionCompuesta;
        }
    }
}
