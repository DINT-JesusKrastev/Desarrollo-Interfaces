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
using System.Windows.Controls;

namespace ProyectoCine
{
    public class MainWindowVM : ObservableObject
    {
        private NavegacionService navegacionService;
        public RelayCommand NavegarASalasCommand { get; }
        public RelayCommand NavegarAPeliculasCommand { get; }
        public RelayCommand RestaurarBaseDatosCommand { get; }
        public RelayCommand NavegarATicketsCommand { get; }
        private UserControl contenidoVista;
        public UserControl ContenidoVista
        {
            get { return contenidoVista; }
            set { SetProperty(ref contenidoVista, value); }
        }

        public MainWindowVM()
        {
            SQLiteService.DeleteAllTickets();
            this.navegacionService = new NavegacionService();
            SQLiteService.Connect();
            this.NavegarAPeliculas();
            NavegarASalasCommand = new RelayCommand(NavegarASalas);
            NavegarAPeliculasCommand = new RelayCommand(NavegarAPeliculas);
            NavegarATicketsCommand = new RelayCommand(NavegarATickets);
            RestaurarBaseDatosCommand = new RelayCommand(RestaurarBaseDatos);
        }

        private void NavegarASalas() => ContenidoVista = navegacionService.NavigateToSalas();
        private void NavegarAPeliculas() => ContenidoVista = navegacionService.NavigateToListaPeliculas();
        private void NavegarATickets() => ContenidoVista = navegacionService.NavigateToTickets();
        private void RestaurarBaseDatos()
        {
            SQLiteService.RestartBD();
            DialogoService.DialogoInformativo("Datos restaurados.", "Sistema restaurado");
        }
    }
}
