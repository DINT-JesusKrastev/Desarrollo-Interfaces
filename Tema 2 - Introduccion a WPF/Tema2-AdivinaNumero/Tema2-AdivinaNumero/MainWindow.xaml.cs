using System;
using System.Windows;

namespace Tema2_AdivinaNumero {
    public partial class MainWindow : Window {
        public int numeroAleatorio;

        public MainWindow() {
            InitializeComponent();
            this.numeroAleatorio = GeneraNumeroAleatorio(0, 100);
        }

        public int GeneraNumeroAleatorio(in int numeroMinimo, in int numeroMaximo) => new Random().Next(numeroMinimo, numeroMaximo + 1);

        private void ComprobarButton_Click(object sender, RoutedEventArgs e) {
            if(int.Parse(numeroIntroducidoTextBlock.Text) > this.numeroAleatorio) {
                pistaTextBlock.Text = "Te has pasado";
            } else if(int.Parse(numeroIntroducidoTextBlock.Text) < this.numeroAleatorio) {
                pistaTextBlock.Text = "Te has quedado corto";
            } else {
                pistaTextBlock.Text = "¡Has acertado!";
            }
        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e) {
            this.numeroAleatorio = GeneraNumeroAleatorio(0, 100);
            pistaTextBlock.Text = string.Empty;
            numeroIntroducidoTextBlock.Text = string.Empty;
        }
    }
}