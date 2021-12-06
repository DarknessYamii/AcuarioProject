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
    /// Lógica de interacción para SalaTropical.xaml
    /// </summary>
    public partial class SalaTropical : Window
    {
        public SalaTropical()
        {
            InitializeComponent();
            // Text of TextBlock
            tropicalTxt.Text = "Los peces tropicales son peces que habitan en medios ambientes tropicales en diversas partes del mundo, incluyendo tanto a especies de agua dulce como a especies de agua salada.\nLos peces tropicales son populares como peces para acuario, ya que muy a menudo poseen colores brillantes. En los peces de agua dulce, esta coloración por lo general deriva de la iridiscencia, mientras que en los peces marinos por lo general es producto de pigmentos.\nLos acuaristas a menudo utilizan el término peces tropicales para referirse especialmente a aquellos de agua dulce, mientras que los peces tropicales marinos son llamados simplemente peces marinos.";
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
