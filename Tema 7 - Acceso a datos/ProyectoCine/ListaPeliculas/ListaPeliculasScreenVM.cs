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
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoCine.ListaPeliculas
{
    public class ListaPeliculasScreenVM : ObservableObject
    {
        private ObservableCollection<Pelicula> peliculas;
        public ObservableCollection<Pelicula> Peliculas
        {
            get { return peliculas; }
            set { SetProperty(ref peliculas, value); }
        }
        private Pelicula? peliculaSeleccionada;
        public Pelicula? PeliculaSeleccionada
        {
            get { return peliculaSeleccionada; }
            set { SetProperty(ref peliculaSeleccionada, value); }
        }
        private NavegacionService navegacionService;

        public ListaPeliculasScreenVM()
        {
            this.navegacionService = new NavegacionService();
            this.PeliculaSeleccionada = null;
            this.Peliculas = SQLiteService.GetCartelera();
        }

        public void NavegarAFichaPelicula(Pelicula peliculaSeleccionada)
        {
            navegacionService.NavigateToDialogoFichaPelicula();
            WeakReferenceMessenger.Default.Send(new PeliculaMessage(peliculaSeleccionada));
        }
    }
}