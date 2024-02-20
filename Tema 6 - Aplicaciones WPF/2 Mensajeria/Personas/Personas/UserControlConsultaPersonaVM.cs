using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class UserControlConsultaPersonaVM : ObservableRecipient
    {
        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; } 
            set { SetProperty(ref personaSeleccionada, value); }
        }

        public UserControlConsultaPersonaVM()
        {
            this.PersonaSeleccionada = WeakReferenceMessenger.Default.Send<PersonaSeleccionadaMessage>();
        }
    }
}
