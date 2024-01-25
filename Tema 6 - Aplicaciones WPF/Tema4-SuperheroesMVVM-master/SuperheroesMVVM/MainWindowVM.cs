using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroesMVVM
{
    class MainWindowVM : ObservableObject
    {
        private List<Superheroe> heroes;

        private Superheroe heroeActual;

        public Superheroe HeroeActual
        {
            get { return heroeActual; }
            set 
            { 
                SetProperty(ref heroeActual, value);
            }
        }

        private int total;

        public int Total
        {
            get { return total; }
            set 
            {
                SetProperty(ref total, value);
            }
        }

        private int actual;

        public int Actual
        {
            get { return actual; }
            set 
            {
                SetProperty(ref actual, value);
            }
        }

        public RelayCommand SiguienteCommand { get; }
        public RelayCommand AnteriorCommand { get; }


        public MainWindowVM()
        {
            heroes = SuperheroeService.GetSamples();
            HeroeActual = heroes[0];
            Total = heroes.Count;
            Actual = 1;
            SiguienteCommand = new RelayCommand(Siguiente);
            AnteriorCommand = new RelayCommand(Anterior);
        }

        public void Siguiente()
        {
            Actual = (Actual + 1 <= heroes.Count) ? Actual + 1 : 1;
            HeroeActual = heroes[Actual-1];
        }

        public void Anterior()
        {
            Actual = (Actual - 1 >= 1) ? Actual - 1 : heroes.Count;
            HeroeActual = heroes[Actual-1];
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
