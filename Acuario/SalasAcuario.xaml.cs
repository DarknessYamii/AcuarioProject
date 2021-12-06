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
        // Button Home
        private void btnHome(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Close();
            inicio.Show();
        }
        // Button Medusas
        private void btnMedusas(object sender, RoutedEventArgs e)
        {
            SalaMedusas sm = new SalaMedusas();
            this.Close();
            sm.Show();
        }
        // Button Crustaceos
        private void btnCrustaceos(object sender, RoutedEventArgs e)
        {
            SalaCrustaceos sc = new SalaCrustaceos();
            this.Close();
            sc.Show();
        }
        // Button Tiburones
        private void btnTiburones(object sender, RoutedEventArgs e)
        {
            SalaTiburones st = new SalaTiburones();
            this.Close();
            st.Show();
        }
        // Button Mamiferos
        private void btnMamiferos(object sender, RoutedEventArgs e)
        {
            SalaMamiferos sm = new SalaMamiferos();
            this.Close();
            sm.Show();
        }
        // Button Tropical
        private void btnTropical(object sender, RoutedEventArgs e)
        {
            SalaTropical st = new SalaTropical();
            this.Close();
            st.Show();
        }
    }
}
