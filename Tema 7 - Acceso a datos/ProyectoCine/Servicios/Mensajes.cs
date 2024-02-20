using CommunityToolkit.Mvvm.Messaging.Messages;
using ProyectoCine.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Servicios
{
    public class PeliculaMessage : ValueChangedMessage<Pelicula>
    {
        public PeliculaMessage(Pelicula pelicula) : base(pelicula) { }
    }
    public class SalaMessage : ValueChangedMessage<Sala>
    {
        public SalaMessage(Sala sala) : base(sala) { }
    }
    public class SesionMessage : ValueChangedMessage<Sesion>
    {
        public SesionMessage(Sesion sesion) : base(sesion) { }
    }
}
