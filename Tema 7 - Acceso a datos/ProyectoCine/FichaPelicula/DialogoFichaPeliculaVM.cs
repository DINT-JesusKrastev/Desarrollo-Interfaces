using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ProyectoCine.Modelos;
using ProyectoCine.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.FichaPelicula
{
    public class DialogoFichaPeliculaVM : ObservableRecipient
    {
        private Pelicula peliculaSeleccionada;
        public Pelicula PeliculaSeleccionada 
        {
            get { return peliculaSeleccionada; } 
            set { SetProperty(ref  peliculaSeleccionada, value); }
        }
        private ObservableCollection<Sesion> sesiones;
        public ObservableCollection<Sesion> Sesiones
        {
            get { return sesiones; }
            set { SetProperty(ref sesiones, value); }   
        }
        private Sesion sesionSeleccionado;
        public Sesion SesionSeleccionado
        {
            get { return sesionSeleccionado; }
            set { SetProperty(ref sesionSeleccionado, value); }
        }
        public RelayCommand AnyadirSesionCommand { get; }
        public RelayCommand EditarSesionCommand { get; }
        public RelayCommand EliminarSesionCommand { get; }
        public RelayCommand ActualizarListaSesionesCommand { get; }
        private NavegacionService ServicioNavegacion { get; set; }

        public DialogoFichaPeliculaVM()
        {
            this.ServicioNavegacion = new NavegacionService();
            WeakReferenceMessenger.Default.Register<PeliculaMessage>(this, (r, m) =>
            {
                this.PeliculaSeleccionada = m.Value;
                this.Sesiones = SQLiteService.getSesionesPorPelicula(PeliculaSeleccionada.Id);
            });
            this.SesionSeleccionado = null;
            this.AnyadirSesionCommand = new RelayCommand(AnyadirSesion);
            this.EditarSesionCommand = new RelayCommand(EditarSesion);
            this.EliminarSesionCommand = new RelayCommand(EliminarSesion);
            this.ActualizarListaSesionesCommand = new RelayCommand(ActualizarListaSesiones);
        }

        private void AnyadirSesion()
        {
            ServicioNavegacion.NavigateToDialogoSesion();
            WeakReferenceMessenger.Default.Send(new SesionMessage(new Sesion(-1, -1, "", PeliculaSeleccionada.Id)));
        }

        private void EditarSesion()
        {
            ServicioNavegacion.NavigateToDialogoSesion();
            WeakReferenceMessenger.Default.Send(new SesionMessage(SesionSeleccionado));
        }

        private void EliminarSesion()
        {
            if(SQLiteService.DeleteSesion(sesionSeleccionado))
            {
                DialogoService.DialogoInformativo("Eliminado sesión correctamente", "Sesión eliminada");
            } else
            {
                DialogoService.DialogoError("Eliminado sesión incorrectamente");
            }
        }

        private void ActualizarListaSesiones() => this.Sesiones = SQLiteService.getSesionesPorPelicula(PeliculaSeleccionada.Id);
    }
}