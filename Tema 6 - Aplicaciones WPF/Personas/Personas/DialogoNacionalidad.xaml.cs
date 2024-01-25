using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Personas
{
    public partial class DialogoNacionalidad : Window
    {
        private DialogoNacionalidadVM vm;

        public DialogoNacionalidad()
        {
            InitializeComponent();
            vm = new DialogoNacionalidadVM();
            this.DataContext = vm;
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.Aceptar();
            DialogResult = true;
        }
    }
}
