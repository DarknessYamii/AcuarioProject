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
    /// Lógica de interacción para SalaTiburones.xaml
    /// </summary>
    public partial class SalaTiburones : Window
    {
        public SalaTiburones()
        {
            InitializeComponent();
            // Text of TextBlock
            tiburonesTxt.Text = "Los selaquimorfos o selacimorfos (Selachimorpha, del griego σελαχος, selachos, tiburón, y μορφή, morphé, forma) son un superorden de condrictios (peces cartilaginosos) conocidos comúnmente con el nombre de tiburones o escualos. Algunos grandes escualos, como el tiburón blanco y el toro, son conocidos a veces con el nombre de jaquetones.\nSe caracterizan por ser grandes depredadores, tener esqueleto cartilaginoso y(generalmente) boca ventral. Los tiburones incluyen desde especies pequeñas de las profundidades marinas, hasta el tiburón ballena, el mayor de los peces, el cual se cree puede llegar a medir una longitud de 17 m y se alimenta únicamente de plancton.El tiburón toro puede desplazarse a agua dulce y algunos ataques de tiburones han ocurrido en ríos.Algunas de las especies mayores, en especial el tiburón mako y el tiburón blanco, son endotermos parciales, capaces de mantener parcialmente su temperatura corporal por encima de la que tiene el medio acuático en el que viven. De las más de 375 especies de tiburones encontradas en los océanos del mundo, las especies responsables de la mayoría de los ataques a humanos sin mediar provocación son el tiburón blanco, el tiburón tigre, y el tiburón toro.";
        }
        // Button Inicio
        private void back(object sender, RoutedEventArgs e)
        {
            SalasAcuario sa = new SalasAcuario();
            this.Close();
            sa.Show();
        }
    }
}
