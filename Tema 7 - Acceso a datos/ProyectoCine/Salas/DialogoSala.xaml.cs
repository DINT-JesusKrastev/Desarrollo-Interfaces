using ProyectoCine.Modelos;
using ProyectoCine.Servicios;
using ProyectoCine.ValidacionFormularios;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ProyectoCine.Salas
{
    public partial class DialogoSala : Window
    {
        private DialogoSalaVM vm;

        public DialogoSala()
        {
            InitializeComponent();
            vm = new DialogoSalaVM();
            this.DataContext = vm;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            string numeroSala = textBoxNumeroSala.Text.ToString();
            string capacidad = textBoxCapacidad.Text.ToString();
            string disponible = comboBoxDisponible.SelectedItem.ToString();
            ValidadorDialogoSala validador = new ValidadorDialogoSala();
            ValidacionCompuesta validacion = validador.valida(numeroSala, capacidad, disponible);

            if(!validacion.HayError)
            {
                Sala sala = new Sala(-1, numeroSala, int.Parse(capacidad), (disponible == "Disponible"));
                vm.GuardarSala(sala);
            } else
            {
                DialogoService.DialogoError(validacion.MensajeError);
            }
        }
    }
}
