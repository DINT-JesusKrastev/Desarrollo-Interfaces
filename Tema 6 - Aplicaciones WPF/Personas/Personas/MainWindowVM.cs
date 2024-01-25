using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Personas
{
    public class MainWindowVM : ObservableObject 
    {
        private UserControl contenidoVista;
        public UserControl ContenidoVista
        {
            get { return contenidoVista; }
            set { SetProperty(ref contenidoVista, value); }
        }
        public RelayCommand VistaNuevaPersonaCommand { get; }
        public RelayCommand VistaListadoPersonasCommand { get; }
        public RelayCommand VistaConsultaPersonaCommand { get; }
        private NavegacionService navegacionService;

        public MainWindowVM()
        {
            VistaNuevaPersonaCommand = new RelayCommand(CargaVistaNuevaPersona);
            VistaListadoPersonasCommand = new RelayCommand(CargaVistaListaPersonas);
            VistaConsultaPersonaCommand = new RelayCommand(CargaVistaConsultaPersona);
            navegacionService = new NavegacionService();
        }

        public void CargaVistaNuevaPersona() => ContenidoVista = navegacionService.ObtenUserControlNuevaPersona();

        public void CargaVistaListaPersonas() => ContenidoVista = navegacionService.ObtenUserControlListadoPersonas();

        public void CargaVistaConsultaPersona() => ContenidoVista = navegacionService.ObtenUserControlConsultaPersona();
    }
}
