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

namespace ProyectoCine.Salas
{
    public class SalasScreenVM : ObservableObject
    {
        public RelayCommand AnyadirNuevaSalaCommand { get; }
        public RelayCommand EditarSalaCommand { get; }
        public RelayCommand ActualizarListaSalasCommand { get; }
        private NavegacionService ServicioNavegacion { get; set; }
        private ObservableCollection<Sala> salas;
        public ObservableCollection<Sala> Salas { 
            get { return salas; }
            set { SetProperty(ref salas, value); } 
        }
        private Sala? salaSeleccionada;
        public Sala? SalaSeleccionada
        {
            get { return salaSeleccionada; }
            set { SetProperty(ref salaSeleccionada, value); }
        }

        public SalasScreenVM()
        {
            this.ServicioNavegacion = new NavegacionService();
            this.Salas = SQLiteService.GetSalas();
            this.SalaSeleccionada = null;
            this.AnyadirNuevaSalaCommand = new RelayCommand(AnyadirNuevaSala);
            this.EditarSalaCommand = new RelayCommand(EditarSala);
            this.ActualizarListaSalasCommand = new RelayCommand(ActualizarListaSalas);
        }

        private void AnyadirNuevaSala()
        {
            ServicioNavegacion.NavigateToDialogoSala();
            WeakReferenceMessenger.Default.Send(new SalaMessage(new Sala(-1, "0", 0, false)));
        }

        private void EditarSala()
        {
            ServicioNavegacion.NavigateToDialogoSala();
            WeakReferenceMessenger.Default.Send(new SalaMessage(SalaSeleccionada));
        }

        private void ActualizarListaSalas() => this.Salas = SQLiteService.GetSalas();
    }
}
