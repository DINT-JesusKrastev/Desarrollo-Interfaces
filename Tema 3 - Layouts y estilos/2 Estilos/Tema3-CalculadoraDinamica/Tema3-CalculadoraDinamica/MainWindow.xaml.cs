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

namespace Tema3_CalculadoraDinamica {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            GeneraBotones();
        }

        private void NumeroButton_Click(object sender, RoutedEventArgs e) => numerosIntroducidosTextBox.Text += ((Button)sender).Tag.ToString();

        private void GeneraBotones() {
            const int filas = 4, columnas = 2;
            int contador = 1;
            Viewbox viewbox;
            Button btnNumero;
            TextBlock numero;

            for (int i = 2; i <= filas; i++) {
                for(int j = 0; j <= columnas; j++) {
                    viewbox = new Viewbox();
                    btnNumero = new Button { Tag = contador };
                    numero = new TextBlock { Text = contador.ToString() };

                    Grid.SetRow(btnNumero, i);
                    Grid.SetColumn(btnNumero, j);
                    viewbox.Child = numero;
                    btnNumero.Content = viewbox;
                    gridBotones.Children.Add(btnNumero); // Button -> Viewbox -> TextBlock
                    contador++;
                }
            }
            viewbox = new Viewbox();
            btnNumero = new Button { Tag = 0 };
            numero = new TextBlock { Text = "0" };

            Grid.SetRow(btnNumero, 5);
            Grid.SetColumnSpan(btnNumero, 3);
            viewbox.Child = numero;
            btnNumero.Content = viewbox;
            gridBotones.Children.Add(btnNumero);
        }
    }
}
