using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Modelos
{
    public class Ticket : ObservableObject
    {
        private int id;
        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }
        private int sesion;
        public int Sesion
        {
            get => sesion;
            set => SetProperty(ref sesion, value);
        }
        private int cantidad;
        public int Cantidad
        {
            get => cantidad;
            set => SetProperty(ref cantidad, value);
        }
        private string pago;
        public string Pago
        {
            get => pago;
            set => SetProperty(ref pago, value);
        }
        public Pelicula PeliculaTicket
        {
            get { return SQLiteService.GetPelicula(SQLiteService.getSesion(Sesion).Pelicula); }
        }
        public Sala SalaTicket
        {
            get { return SQLiteService.GetSala(SQLiteService.getSesion(Sesion).Sala); }
        }
        public Sesion SesionTicket
        {
            get { return SQLiteService.getSesion(Sesion); }
        }

        public Ticket(int id, int sesion, int cantidad, string pago)
        {
            this.Id = id;
            this.Sesion = sesion;
            this.Cantidad = cantidad;
            this.Pago = pago;
        }
    }
}
