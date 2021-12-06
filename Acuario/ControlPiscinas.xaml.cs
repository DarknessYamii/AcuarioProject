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
            // Get data from Logic.class
            datagridAcuario.DataContext = logic;
        }

         // Button add
        private void btnAgregar(object sender, RoutedEventArgs e)
        {
            // Show form
            FormGestion fg = new FormGestion();
            fg.Show();
        }
        // Button modify
        private void btnModify(object sender, RoutedEventArgs e)
        {
            // Check if some element is selected
            if(datagridAcuario.SelectedIndex != -1)
            {
                // Show the index with respective values
                new FormGestion(datagridAcuario.SelectedIndex).Show();
            }
        }
        // Button delete
        private void btnDelete(object sender, RoutedEventArgs e)
        {
            // Check if some element is selected
            if(datagridAcuario.SelectedIndex != -1)
            {
                // Delete from Logic the index 
                logic.deleteGestion(datagridAcuario.SelectedIndex);
            }
        }
        // Button Inicio
        private void btnHome(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Close();
            inicio.Show();
        }
    }
}
