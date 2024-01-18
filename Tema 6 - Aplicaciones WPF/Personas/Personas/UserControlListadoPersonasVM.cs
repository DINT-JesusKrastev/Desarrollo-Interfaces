using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class UserControlListadoPersonasVM : ObservableObject
    {
        private ObservableCollection<Persona> personas;
        public ObservableCollection<Persona> Personas
        {
            get { return personas; }
            set { SetProperty(ref personas, value); }
        }
        private PersonaService personaService;

        public UserControlListadoPersonasVM()
        {
            this.personaService = new PersonaService();
            this.personas = personaService.GetSamples();
        }
    }
}
