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
    /// Lógica de interacción para SalaMamiferos.xaml
    /// </summary>
    public partial class SalaMamiferos : Window
    {
        public SalaMamiferos()
        {
            InitializeComponent();
            // Text of TextBlock
            mamiferosTxt.Text = "Los mamíferos marinos son un grupo variado de aproximadamente 130 especies de mamíferos que se han adaptado a la vida en el mar o dependen de él para su alimentación. El término mamífero marino no designa a un conjunto taxonómico preciso. En este grupo se incluyen los cetáceos (ballenas, delfines y marsopas), los sirenios (manatíes y dugongos), los pinnipedos (focas verdaderas, otarios y morsas) y algunas nutrias (la nutria marina y el gato de mar). El oso polar, aunque no es un animal acuático, también se suele agrupar con los mamíferos marinos debido a que vive en los hielos marinos durante todo o la mayor parte del año y a su alto grado de adaptación a la vida en el mar.\nLos mamíferos marinos adquirieron distintos rasgos para adaptarse a la vida en el mar, como un tamaño generalmente mayor, forma corporal hidrodinámica, modificaron apéndices y experimentaron adaptaciones termoregulatorias. Las diferentes especies, sin embargo, se adaptaron a la vida marina en distintos grados. Los más adaptados son los cetáceos y los sirenios, cuyo ciclo de vida discurre totalmente en el agua, mientras que los demás grupos pasan al menos algún tiempo en tierra.\nA pesar de que los mamíferos marinos son una megafauna carismática y que cuenta con el apoyo de grupos ecologistas, muchas poblaciones son vulnerables o están en peligro de extinción debido a una larga historia de explotación comercial para obtener grasa, aceite, carne, marfil y piel. La mayor parte de las especies de mamíferos marinos se encuentran protegidas frente a la explotación comercial.";
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
