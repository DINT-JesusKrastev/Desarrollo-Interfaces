using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Personas
{
    public class UserControlNuevaPersonaVM
    {
        public ObservableCollection<string> Nacionalidades { get; set; }
        private NacionalidadService nacionalidadService;
        public RelayCommand AbrirDialogoNacionalidadCommand { get; }
        private NavegacionService navegacionService;

        public UserControlNuevaPersonaVM()
        {
            this.nacionalidadService = new NacionalidadService();
            navegacionService = new NavegacionService();
            AbrirDialogoNacionalidadCommand = new RelayCommand(AbrirDialogoNacionalidad);
            this.Nacionalidades = nacionalidadService.GetSamples();
        }

        public void AbrirDialogoNacionalidad() => navegacionService.AbrirDialogoNacionalidad();
    }
}
