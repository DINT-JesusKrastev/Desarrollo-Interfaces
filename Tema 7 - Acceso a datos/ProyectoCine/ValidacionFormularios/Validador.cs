using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProyectoCine.ValidacionFormularios
{
    public static class Validador
    {
        public static bool ValidarTextoNoVacio(string texto) => (texto != "");

        public static bool ValidarNumeroEntero(string numero) => Regex.IsMatch(numero, @"^\d+$");

        public static bool ValidarHora(string hora) => Regex.IsMatch(hora, @"^([0-9]|0[0-9]|1[0-9]|2[0-3]):([0-5]?[0-9])$");
    }
}
