using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class NacionalidadService
    {
        public ObservableCollection<string> GetSamples()
        {
            return new ObservableCollection<string>()
            {
                "Italiana",
                "Española",
                "Francesa"
            };
        }
    }
}
