using System;
using System.Reflection;
using System.Windows;

namespace Acuario
{
    /// <summary>
    /// Lógica de interacción para Contacto.xaml
    /// </summary>
    public partial class Contacto : Window
    {


        public Contacto()
        {
            InitializeComponent();
        }



        // Go to inicio
        private void back(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            base.Close();
            inicio.Show();
        }
    }
}

