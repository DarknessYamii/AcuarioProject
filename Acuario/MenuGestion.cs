using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Acuario
{
    public class MenuGestion : INotifyPropertyChanged
    {
        public static List<String> rooms = new List<String>() { "Tropical", "Crustáceos", "Mamíferos", "Tiburones", "Medusas" };

        public String roomName { get; set; }

        public String species { get; set; }

        public String temperature { get; set; }

        public DateTime revisionDate { get; set; }

        public String treatment { get; set; }

        public MenuGestion()
        {
        }

        public MenuGestion(String roomName, string temperature, string species, DateTime revisionDate, string treatment)
        {
            this.roomName = roomName;
            this.temperature = temperature;
            this.species = species;
            this.revisionDate = revisionDate;
            this.treatment = treatment;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}


