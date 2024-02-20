using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ProyectoCine.Modelos;
using ProyectoCine.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Tickets
{
    public class TicketsScreenVM : ObservableObject
    {
        public RelayCommand AnyadirTicketCommand { get; }
        public RelayCommand ActualizarListaTicketsCommand { get; }
        private NavegacionService servicioNavegacion { get ; set; }
        private ObservableCollection<Ticket> tickets;
        public ObservableCollection<Ticket> Tickets
        {
            get { return tickets; }
            set { SetProperty(ref tickets, value); }
        }

        public TicketsScreenVM()
        {
            AnyadirTicketCommand = new RelayCommand(AnyadirTicket);
            ActualizarListaTicketsCommand = new RelayCommand(ActualizarListaTickets);
            this.servicioNavegacion = new NavegacionService();
            Tickets = SQLiteService.GetTickets();
        }

        private void AnyadirTicket()
        {
            servicioNavegacion.NavigateToDialogoTicket();
        }

        private void ActualizarListaTickets()
        {
            Tickets = SQLiteService.GetTickets();
        }
    }
}
