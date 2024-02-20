using ProyectoCine.FichaPelicula;
using ProyectoCine.ListaPeliculas;
using ProyectoCine.Salas;
using ProyectoCine.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ProyectoCine.Servicios
{
    public class NavegacionService
    {
        public UserControl NavigateToSalas() => new SalasScreen();

        public UserControl NavigateToTickets() => new TicketsScreen();

        public UserControl NavigateToListaPeliculas() => new ListaPeliculasScreen();

        public void NavigateToDialogoFichaPelicula()
        {
            new DialogoFichaPelicula().Show();
        }

        public void NavigateToDialogoSala()
        {
            new DialogoSala().Show();
        }

        public void NavigateToDialogoSesion()
        {
            new DialogoSesion().Show();
        }

        public void NavigateToDialogoTicket()
        {
            new DialogoTickets().Show();
        }
    }
}
