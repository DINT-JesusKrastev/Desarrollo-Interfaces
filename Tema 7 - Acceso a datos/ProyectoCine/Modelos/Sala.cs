using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Modelos
{
    public class Sala : ObservableObject
    {
        private int id;
        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }
        private string numero;
        public string Numero
        {
            get => numero;
            set => SetProperty(ref numero, value);
        }
        private int capacidad;
        public int Capacidad
        {
            get => capacidad;
            set => SetProperty(ref capacidad, value);
        }
        private bool disponible;
        public bool Disponible
        {
            get => disponible;
            set => SetProperty(ref disponible, value);
        }
        public string Ocupacion
        {
            get { return $"{SQLiteService.GetOcupacionSala(Id)}/{Capacidad}"; }
        }

        public Sala(int id, string numero, int capacidad, bool disponible)
        {
            this.Id = id;
            this.Numero = numero;
            this.Capacidad = capacidad;
            this.Disponible = disponible;
        }

        public override string ToString()
        {
            return $"Sala {Numero}";
        }
    }
}
