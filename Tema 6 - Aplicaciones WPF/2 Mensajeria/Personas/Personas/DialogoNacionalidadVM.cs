using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
<<<<<<< HEAD
using CommunityToolkit.Mvvm.Messaging;
=======
>>>>>>> eb9692e2ab6d2d9ecb99ffd2e85f9717b3c0b7c2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class DialogoNacionalidadVM : ObservableObject
    {
<<<<<<< HEAD
        private string nacionalidad;
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public void Aceptar()
        {
            WeakReferenceMessenger.Default.Send(new NuevaNacionalidadMessage(Nacionalidad));
        }
=======
        // TODO
>>>>>>> eb9692e2ab6d2d9ecb99ffd2e85f9717b3c0b7c2
    }
}
