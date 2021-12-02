using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Acuario
{
    public class Logistic
    {
        public ObservableCollection<MenuGestion> listGestion { get; set; }

        public Logistic()
        {
            listGestion = new ObservableCollection<MenuGestion>();
            listGestion.Add(new MenuGestion(MenuGestion.rooms[0], "-10", "Peces", new DateTime(2020,02,02), "Limpiar agua"));
        }

        public void addGestion(MenuGestion gestion)
        {
            listGestion.Add(gestion);
        }

        public void deleteGestion(int index)
        {
            listGestion.RemoveAt(index);
        }
        public void modifyGestion(int index, MenuGestion gestion)
        {
            listGestion[index] = gestion;
        }
    }
}
