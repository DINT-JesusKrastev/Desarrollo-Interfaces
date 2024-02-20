using CommunityToolkit.Mvvm.ComponentModel;
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
    public class DialogoSesionVM : ObservableObject
    {
        private ObservableCollection<Sala> salas;
        public ObservableCollection<Sala> Salas
        {
            get { return salas; }
            set { SetProperty(ref salas, value); }
        }
        private Sesion sesionSeleccionado;
        public Sesion SesionSeleccionado
        {
            get { return sesionSeleccionado; }
            set { SetProperty(ref sesionSeleccionado, value); }
        }
        private Pelicula peliculaSeleccionada;
        public Pelicula PeliculaSeleccionada { 
            get { return peliculaSeleccionada; } 
            set { SetProperty(ref  peliculaSeleccionada, value); }
        }
        private Sala? salaSeleccionada;
        public Sala? SalaSeleccionada
        {
            get { return salaSeleccionada; }
            set { SetProperty(ref salaSeleccionada, value); }
        }

        public DialogoSesionVM()
        {
            WeakReferenceMessenger.Default.Register<SesionMessage>(this, (r, m) =>
            {
                this.SesionSeleccionado = m.Value;
                this.PeliculaSeleccionada = SQLiteService.GetPelicula(m.Value.Pelicula);
                this.SalaSeleccionada = (SesionSeleccionado.Sala >= 0) ? SQLiteService.GetSala(SesionSeleccionado.Sala) : null;
            });
            this.Salas = SQLiteService.GetSalasDisponibles();
        }

        public void GuardarSesion(Sesion sesion)
        {
            sesion.Id = SesionSeleccionado.Id;
            sesion.Pelicula = PeliculaSeleccionada.Id;
            sesion.Sala = SalaSeleccionada.Id;
            if (SesionSeleccionado.Id == -1) // Insertar
            {
                if (SQLiteService.InsertSesion(sesion))
                {
                    DialogoService.DialogoInformativo("Sesión insertada correctamente.", "Sesión insertada");
                }
                else
                {
                    DialogoService.DialogoError("Sesión insertada incorrectamente.");
                }
            }
            else // Actualizar
            {
                if (SQLiteService.UpdateSesion(sesion))
                {
                    DialogoService.DialogoInformativo("Sesión actualizada correctamente.", "Sesión actualizada");
                }
                else
                {
                    DialogoService.DialogoError("Sesión actualizada incorrectamente.");
                }
            }
        }
    }
}
