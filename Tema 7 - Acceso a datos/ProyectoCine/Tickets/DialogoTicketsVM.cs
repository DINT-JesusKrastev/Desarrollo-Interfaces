using CommunityToolkit.Mvvm.ComponentModel;
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
    public class DialogoTicketsVM : ObservableObject
    {
        public ObservableCollection<string> MetodosPago {  get; set; }
        private string? metodoPagoSeleccionado;
        public string? MetodoPagoSeleccionado
        {
            get { return metodoPagoSeleccionado; }
            set { SetProperty(ref metodoPagoSeleccionado, value); }
        }
        private ObservableCollection<Sesion> sesiones;
        public ObservableCollection<Sesion> Sesiones
        {
            get { return sesiones; }
            set { SetProperty(ref sesiones, value); }
        }
        private Sesion? sesionSeleccionado;
        public Sesion? SesionSeleccionado
        {
            get { return sesionSeleccionado; }
            set { SetProperty(ref sesionSeleccionado, value); }
        }

        public DialogoTicketsVM()
        {
            this.MetodosPago = new ObservableCollection<string>() {
                "Efectivo",
                "Tarjeta",
                "Bizum"
            };
            SesionSeleccionado = null;
            MetodoPagoSeleccionado = null;
            Sesiones = SQLiteService.getSesiones();
        }

        public void GuardarTicket(Ticket ticket)
        {
            ticket.Pago = MetodoPagoSeleccionado;
            ticket.Sesion = SesionSeleccionado.Id;
            if (SQLiteService.InsertTicket(ticket))
            {
                DialogoService.DialogoInformativo("Ticket insertado correctamente.", "Ticket insertado");
            }
            else
            {
                DialogoService.DialogoError("Ticket insertado incorrectamente.");
            }
        }
    }
}
