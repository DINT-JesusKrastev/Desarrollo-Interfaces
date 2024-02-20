using ProyectoCine.ValidacionFormularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Tickets
{
    public class ValidadorDialogoTicket
    {
        private ValidacionCompuesta validacionCompuesta;

        public ValidadorDialogoTicket()
        {
            this.validacionCompuesta = new ValidacionCompuesta();
        }

        public ValidacionCompuesta valida(string idSesion, string cantidad, string metodoPago)
        {
            validacionCompuesta
                .Add(new Validacion(!Validador.ValidarTextoNoVacio(idSesion), "La sesión no debe estar vacío"))
                .Add(new Validacion(!Validador.ValidarTextoNoVacio(cantidad), "La cantidad no puede estar vacía"))
                .Add(new Validacion(!Validador.ValidarNumeroEntero(cantidad), "La cantidad debe tener formato numérico"))
                .Add(new Validacion(!Validador.ValidarTextoNoVacio(metodoPago), "El método de pago no puede estar vacío"));

            return validacionCompuesta;
        }
    }
}
