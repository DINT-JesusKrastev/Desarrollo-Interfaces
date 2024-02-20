using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoCine.Servicios
{
    public static class DialogoService
    {
        public static void DialogoInformativo(string mensaje, string cabecera) => MessageBox.Show(mensaje, cabecera, MessageBoxButton.OK, MessageBoxImage.Exclamation);

        public static void DialogoError(string mensaje) => MessageBox.Show(mensaje, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    }
}
