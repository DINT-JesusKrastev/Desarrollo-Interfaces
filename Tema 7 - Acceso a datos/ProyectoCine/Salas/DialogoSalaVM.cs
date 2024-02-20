using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ProyectoCine.Modelos;
using ProyectoCine.Servicios;
using ProyectoCine.ValidacionFormularios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Salas
{
    public class DialogoSalaVM : ObservableObject
    {
        private Sala salaSeleccionada;
        public Sala SalaSeleccionada
        {
            get { return salaSeleccionada; }
            set { SetProperty(ref salaSeleccionada, value); }
        }
        public ObservableCollection<string> Disponibilidad { get; set; }

        public DialogoSalaVM()
        {
            WeakReferenceMessenger.Default.Register<SalaMessage>(this, (r, m) =>
            {
                this.SalaSeleccionada = m.Value;
            });
            this.Disponibilidad = new ObservableCollection<string>()
            {
                "Disponible",
                "No disponible"
            };
        }

        public void GuardarSala(Sala sala)
        {
            sala.Id = SalaSeleccionada.Id;
            if (SalaSeleccionada.Id == -1) // Insertar
            {
                if(SQLiteService.InsertSala(sala))
                {
                    DialogoService.DialogoInformativo("Sala insertada correctamente.", "Sala insertada");
                } else
                {
                    DialogoService.DialogoError("Sala insertada incorrectamente.");
                }
            } else // Actualizar
            {
                if (SQLiteService.UpdateSala(sala))
                {
                    DialogoService.DialogoInformativo("Sala actualizada correctamente.", "Sala actualizada");
                }
                else
                {
                    DialogoService.DialogoError("Sala actualizada incorrectamente.");
                }
            }
        }
    }
}
