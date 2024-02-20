using ProyectoCine.Modelos;
using ProyectoCine.ValidacionFormularios;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Salas
{
    public class ValidadorDialogoSala
    {
        private ValidacionCompuesta validacionCompuesta;

        public ValidadorDialogoSala()
        {
            this.validacionCompuesta = new ValidacionCompuesta();
        }

        public ValidacionCompuesta valida(string numeroSala, string capacidad, string disponible)
        {
            validacionCompuesta
                .Add(new Validacion(!Validador.ValidarTextoNoVacio(numeroSala), "El número de sala no debe estar vacío"))
                .Add(new Validacion(!Validador.ValidarNumeroEntero(numeroSala), "El número de sala debe ser un número válido"))
                .Add(new Validacion(!Validador.ValidarTextoNoVacio(capacidad), "La capacidad no puede estar vacío"))
                .Add(new Validacion(!Validador.ValidarNumeroEntero(capacidad), "La capacidad debe ser un número válido"))
                .Add(new Validacion(!Validador.ValidarTextoNoVacio(disponible), "La disponibilidad no puede estar vacío"));

            return validacionCompuesta;
        }
    }
}
