using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Modelos
{
    public class Sesion : ObservableObject
    {
        private int id;
        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }
        private int sala;
        public int Sala
        {
            get => sala;
            set => SetProperty(ref sala, value);
        }
        public string NumeroSala
        {
            get { return $"Sala {SQLiteService.GetSala(sala).Numero}"; }
        }
        private string hora;
        public string Hora
        {
            get => hora;
            set => SetProperty(ref hora, value);
        }
        private int pelicula;
        public int Pelicula
        {
            get => pelicula;
            set => SetProperty(ref pelicula, value);
        }

        public Sesion(int id, int sala, string hora, int pelicula)
        {
            this.Id = id;
            this.Sala = sala;
            this.Hora = hora;
            this.Pelicula = pelicula;
        }
    }
}
