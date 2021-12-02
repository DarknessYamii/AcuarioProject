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
        private int index;
        public FormGestion()

        {
            InitializeComponent();
            this.index = -1;
            mg = new MenuGestion();
            ComboBoxRooms.ItemsSource = MenuGestion.rooms;
            this.DataContext = mg;
        }

        public FormGestion(int index)
        {
            InitializeComponent();
            this.index = index;
            mg = new MenuGestion();
            ComboBoxRooms.ItemsSource = MenuGestion.rooms;
            ComboBoxRooms.SelectedItem = ControlPiscinas.logic.listGestion.ElementAt(index).roomName;
            this.DataContext = ControlPiscinas.logic.listGestion.ElementAt(index);
        }

        private void btnAdd(object sender, RoutedEventArgs e)
        {
            if (index > -1)
            {
                mg = new MenuGestion(ComboBoxRooms.SelectedItem.ToString(), temperature.Text, species.Text, (DateTime)revisionDate.SelectedDate, treatment.Text);
                ControlPiscinas.logic.modifyGestion(index, mg);
                this.Close();
            }
            else
            {
                ControlPiscinas.logic.addGestion(mg);
            }
            mg = new MenuGestion();
            this.DataContext = mg;
        }

        private void btnCancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
