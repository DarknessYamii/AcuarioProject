using System;
using System.Windows;

namespace Acuario
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio() => InitializeComponent();
        // Control page
        private void btnControlPiscinas(object sender, RoutedEventArgs e)
        {
            ControlPiscinas cp = new ControlPiscinas();
            base.Close();
            cp.Show();
        }
        // Salas page
        private void btnSalasAcuario(object sender, RoutedEventArgs e)
        {
            SalasAcuario sa = new SalasAcuario();
            base.Close();
            sa.Show();
        }
        // Minijuego page
        private void btnMinijuego(object sender, RoutedEventArgs e)
        {
            Minijuego mj = new Minijuego();
            mj.Show();
        }
        // Contacto page
        private void btnContacto(object sender, RoutedEventArgs e)
        {
            Contacto cont = new Contacto();
            base.Close();
            cont.Show();

        }
    }
}
