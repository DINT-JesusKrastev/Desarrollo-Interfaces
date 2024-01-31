using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace SuperheroesMVVM
{
    public partial class MainWindow : Window
    {
        private MainWindowVM vm;

        public MainWindow()
        {
            InitializeComponent();
            vm = new MainWindowVM();
            this.DataContext = vm;
        }
    }
}