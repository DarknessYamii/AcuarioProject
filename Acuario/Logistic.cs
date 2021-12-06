using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Acuario
{
    public class Logistic
    {
        // List of MenuGestion
        public ObservableCollection<MenuGestion> listGestion { get; set; }
        // Default Constructor 
        public Logistic()
        {
            // Item to test
            listGestion = new ObservableCollection<MenuGestion>();
            listGestion.Add(new MenuGestion(MenuGestion.rooms[0], "-10", "Peces", new DateTime(2020,02,02), "Limpiar agua"));
        }
        // Method add to the list
        public void addGestion(MenuGestion gestion)
        {
            listGestion.Add(gestion);
        }
        // Method delete of the list

        public void deleteGestion(int index)
        {
            listGestion.RemoveAt(index);
        }
        // Method modify the list
        public void modifyGestion(int index, MenuGestion gestion)
        {
            listGestion[index] = gestion;
        }
    }
}
