using System.Collections.Generic;
using System.ComponentModel;

class Superheroe : INotifyPropertyChanged
{
    private string _nombre;
    public string Nombre { 
        get { return this._nombre; }
        set { 
            if(this._nombre != value) {
                this._nombre = value;
                this.NotifyPropertyChanged("Nombre");
            }
        }
    }
    private string _imagen;
    public string Imagen {
        get { return this._imagen; }
        set {
            if (this._imagen != value) {
                this._imagen = value;
                this.NotifyPropertyChanged("Imagen");
            }
        }
    }
    private bool _vengador;
    public bool Vengador
    {
        get { return this._vengador; }
        set
        {
            if (this._vengador != value)
            {
                this._vengador = value;
                this.NotifyPropertyChanged("Vengador");
            }
        }
    }
    private bool _xmen;
    public bool Xmen
    {
        get { return this._xmen; }
        set
        {
            if (this._xmen != value)
            {
                this._xmen = value;
                this.NotifyPropertyChanged("Xmen");
            }
        }
    }
    private bool _heroe;
    public bool Heroe
    {
        get { return this._heroe; }
        set
        {
            if (this._heroe != value)
            {
                this._heroe = value;
                this.NotifyPropertyChanged("Heroe");
            }
        }
    }

    public Superheroe() { }

    public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
    {
        Nombre = nombre;
        Imagen = imagen;
        Vengador = vengador;
        Xmen = xmen;
        Heroe = heroe;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void NotifyPropertyChanged(string propertyName) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public static List<Superheroe> GetSamples()
    {
        List<Superheroe> ejemplos = new List<Superheroe>();

        Superheroe ironman = new Superheroe("Ironman", @"https://dossierinteractivo.com/wp-content/uploads/2021/01/Iron-Man.png", true, false, true);
        Superheroe kingpin = new Superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false);
        Superheroe spiderman = new Superheroe("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true, true);
        Superheroe wolverine = new Superheroe("Wolverine", @"https://www.fayerwayer.com/resizer/yd15mD9mwNffno4PWRA6pmcX1x4=/1024x1024/filters:format(jpg):quality(70)/cloudfront-us-east-1.images.arcpublishing.com/metroworldnews/FNOHDGI3YZG4HAPGTYX4LPMZWY.jpg", false, true, true);
        Superheroe escorpion = new Superheroe("Escorpión", @"https://static.wikia.nocookie.net/marveldatabase/images/1/16/Scorpion_%28Earth-1610%29_from_Ultimate_Spider-Man_Vol_1_97_0001.jpg/revision/latest?cb=20191202030857", false, false, false);
        Superheroe venom = new Superheroe("Venom", @"https://www.mundodeportivo.com/alfabeta/hero/2023/03/marvel-presenta-la-nueva-forma-de-venom-en-los-comics.jpg?width=768&aspect_ratio=16:9&format=nowebp", false, false, false);

        ejemplos.Add(ironman);
        ejemplos.Add(kingpin);
        ejemplos.Add(spiderman);
        ejemplos.Add(escorpion);
        ejemplos.Add(wolverine);
        ejemplos.Add(venom);

        return ejemplos;
    }
}