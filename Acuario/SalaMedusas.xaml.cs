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
    /// Lógica de interacción para SalaMedusas.xaml
    /// </summary>
    public partial class SalaMedusas : Window
    {
        public SalaMedusas()
        {
            InitializeComponent();
            // Text of TextBlock
            medusasTxt.Text = "Las medusas (Medusozoa), también llamadas aguamalas, malaguas, aguavivas, aguacuajito, aguacuajada, o lágrimas de mar, son animales marinos pertenecientes al filo Cnidaria (más conocidos como celentéreos); son pelágicos, de cuerpo gelatinoso, con forma de campana de la que cuelga un manubrio tubular, con la boca en el extremo inferior, a veces prolongado por largos tentáculos cargados con células urticantes llamados cnidocitos. Aparecieron hace unos 500 millones de años en el Cámbrico.1​\nPara desplazarse por el agua se impulsan por contracciones rítmicas de todo su cuerpo; toman agua, que se introduce en su cavidad gastrovascular, y la expulsan usándola como propulsor.\nEl concepto de medusa es tanto taxonómico como morfológico.Muchos cnidarios tienen una alternancia de generaciones, con pólipos sésiles que se reproducen asexualmente y medusas pelágicas que llevan a cabo la reproducción sexual.Solo los antozoos carecen de forma medusa; las otras tres clases de cnidarios(hidrozoos, escifozoos y cubozoos) poseen forma pólipo y forma medusa; dichas medusas presentan características distintivas en las tres clases, de modo que se puede hablar de hidromedusas, escifomedusas y cubomedusas respectivamente.";
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
