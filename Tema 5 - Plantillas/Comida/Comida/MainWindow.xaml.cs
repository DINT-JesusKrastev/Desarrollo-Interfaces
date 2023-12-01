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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Comida
{
    public partial class MainWindow : Window
    {
        private MainWindowVM vm;

        public MainWindow()
        {
            InitializeComponent();
            vm = new MainWindowVM();
            this.DataContext = vm;
            vm.DeshabilitarEditorPlato(editorPlato);
        }

        private void Plato_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) => vm.HabilitarEditorPlato(editorPlato);

        private void BtnLimpiarSeleccion_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => vm.DeshabilitarEditorPlato(editorPlato);
    }
}
