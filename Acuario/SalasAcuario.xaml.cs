using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Acuario
{
    /// <summary>
    /// Lógica de interacción para SalasAcuario.xaml
    /// </summary>
    public partial class SalasAcuario : Window
    {
        public SalasAcuario()
        {
            InitializeComponent();
        }

        private void btnHome(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Close();
            inicio.Show();
        }

        private void btnMedusas(object sender, RoutedEventArgs e)
        {

        }

        private void btnCrustaceos(object sender, RoutedEventArgs e)
        {

        }

        private void btnTiburones(object sender, RoutedEventArgs e)
        {

        }

        private void btnMamiferos(object sender, RoutedEventArgs e)
        {

        }

        private void btnTropical(object sender, RoutedEventArgs e)
        {

        }
    }
}
