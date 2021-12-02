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
    /// Lógica de interacción para ControlPiscinas.xaml
    /// </summary>
    public partial class ControlPiscinas : Window
    {
        public static Logistic logic = new Logistic();
 
        public ControlPiscinas()
        {
            InitializeComponent();
            datagridAcuario.DataContext = logic;
        }


        private void btnAgregar(object sender, RoutedEventArgs e)
        {
            FormGestion fg = new FormGestion();
            fg.Show();
        }

        private void btnModify(object sender, RoutedEventArgs e)
        {
            if(datagridAcuario.SelectedIndex != -1)
            {
                new FormGestion(datagridAcuario.SelectedIndex).Show();
            }
        }

        private void btnDelete(object sender, RoutedEventArgs e)
        {
            if(datagridAcuario.SelectedIndex != -1)
            {
                logic.deleteGestion(datagridAcuario.SelectedIndex);
            }
        }

        private void btnHome(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Close();
            inicio.Show();
        }
    }
}
