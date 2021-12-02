using System;
using System.Linq;
using System.Windows;

namespace Acuario
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void btnInicio(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            base.Close();
            inicio.Show();
        }
    }
}
