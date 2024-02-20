using ProyectoCine.FichaPelicula;
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

namespace ProyectoCine.Tickets
{
    public partial class DialogoTickets : Window
    {
        private DialogoTicketsVM vm;

        public DialogoTickets()
        {
            InitializeComponent();
            vm = new DialogoTicketsVM();
            this.DataContext = vm;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            string idSesion = (comboBoxSesion.SelectedItem != null) ? comboBoxSesion.SelectedItem.ToString() : "";
            string cantidad = textBoxCantidad.Text.ToString();
            string metodoPago = (comboBoxMetodoPago.SelectedItem != null) ? comboBoxMetodoPago.SelectedItem.ToString() : "";
            ValidadorDialogoTicket validador = new ValidadorDialogoTicket();
            ValidacionCompuesta validacion = validador.valida(idSesion, cantidad, metodoPago);

            if (!validacion.HayError)
            {
                Ticket ticket = new Ticket(0, 0, int.Parse(cantidad), metodoPago);
                vm.GuardarTicket(ticket);
            }
            else
            {
                DialogoService.DialogoError(validacion.MensajeError);
            }
        }
    }
}
