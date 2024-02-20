using ProyectoCine.Modelos;
using ProyectoCine.Salas;
using ProyectoCine.Servicios;
using ProyectoCine.ValidacionFormularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyectoCine.FichaPelicula
{
    public partial class DialogoSesion : Window
    {
        private DialogoSesionVM vm;

        public DialogoSesion()
        {
            InitializeComponent();
            vm = new DialogoSesionVM();
            this.DataContext = vm;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            string idPelicula = textBoxPelicula.ToString();
            string idSala = (comboBoxSala.SelectedItem != null) ? comboBoxSala.SelectedItem.ToString() : "";
            string hora = textBoxHora.Text.ToString();
            ValidadorDialogoSesion validador = new ValidadorDialogoSesion();
            ValidacionCompuesta validacion = validador.valida(idPelicula, idSala, hora);

            if (!validacion.HayError)
            {
                Sesion sesion = new Sesion(-1, -1, hora, -1); // Ponemos los ids en el VM
                vm.GuardarSesion(sesion);
            }
            else
            {
                DialogoService.DialogoError(validacion.MensajeError);
            }
        }
    }
}
