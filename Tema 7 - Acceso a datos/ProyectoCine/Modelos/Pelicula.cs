using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Modelos
{
    public class Pelicula : ObservableObject
    {
        private int id;
        public int Id { 
            get {  return id; } 
            set {  SetProperty(ref id, value); } 
        }

        private string titulo;
        public string Titulo
        {
            get { return titulo; }
            set { SetProperty(ref titulo, value); }
        }
        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { SetProperty(ref descripcion, value); }
        }
        private string cartel;
        public string Cartel
        {
            get { return cartel; }
            set { SetProperty(ref cartel, value); }
        }

        private int anyo;
        public int Anyo
        {
            get { return anyo; }
            set { SetProperty(ref anyo, value); }
        }
        public ObservableCollection<string> Generos { get; set; }

        private string calificacion;
        public string Calificacion
        {
            get { return calificacion; }
            set { SetProperty(ref calificacion, value); }
        }

        public Pelicula(int id, string titulo, string descripcion, string cartel, int anyo, ObservableCollection<string> generos, string calificacion)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Cartel = cartel;
            this.Anyo = anyo;
            this.Generos = generos;
            this.Descripcion = descripcion;
            this.Calificacion = calificacion;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Titulo: {Titulo}, Descripcion: {Descripcion}, Cartel: {Cartel}, Año: {Anyo}, Calificacion: {Calificacion}, Generos: {string.Join(", ", Generos)}";
        }
    }
}