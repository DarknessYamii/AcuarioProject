using System;
using System.Linq;
using System.Windows;

namespace Acuario
{
    /// <summary>
    /// Lógica de interacción para FormGestion.xaml
    /// </summary>
    public partial class FormGestion : Window
    {
        public MenuGestion mg;
        // Index to control data
        private int index;
        public FormGestion()

        {
            InitializeComponent();
            this.index = -1;
            mg = new MenuGestion();
            // Get Room names
            ComboBoxRooms.ItemsSource = MenuGestion.rooms;
            this.DataContext = mg;
        }

        public FormGestion(int index)
        {
            InitializeComponent();
            this.index = index;
            mg = new MenuGestion();
            // Get Room names
            ComboBoxRooms.ItemsSource = MenuGestion.rooms;
            // Get ComboBox value and set into listGestion
            ComboBoxRooms.SelectedItem = ControlPiscinas.logic.listGestion.ElementAt(index).roomName;
            this.DataContext = ControlPiscinas.logic.listGestion.ElementAt(index);
        }
        // Method to add values into datagrid
        private void btnAdd(object sender, RoutedEventArgs e)
        {
            // Check if it exist or its ne
            if (index > -1)
            {
                // Get every value in each box 
                mg = new MenuGestion(ComboBoxRooms.SelectedItem.ToString(), temperature.Text, species.Text, (DateTime)revisionDate.SelectedDate, treatment.Text);
                ControlPiscinas.logic.modifyGestion(index, mg);
                this.Close();
            }
            else
            {
                // Add new values into logic 
                ControlPiscinas.logic.addGestion(mg);
            }
            mg = new MenuGestion();
            this.DataContext = mg;
        }
            // Close the form
        private void btnCancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
