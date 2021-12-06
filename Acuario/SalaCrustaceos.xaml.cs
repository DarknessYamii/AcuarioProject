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
    /// Lógica de interacción para SalaCrustaceos.xaml
    /// </summary>
    public partial class SalaCrustaceos : Window
    {
        public SalaCrustaceos()
        {
            InitializeComponent();
            // Text of TextBlock
            crustaceosTxt.Text = "Los crustáceos (Crustacea; del latín crusta, ‘costra’ y aceum, ‘relación o naturaleza de algo’) son un extenso subfilo de artrópodos, con más de 67 000 especies (sin duda, faltan por descubrir hasta cinco o diez veces este número).1​ Incluyen varios grupos de animales comestibles, como las langostas, los cangrejos, los langostinos, los camarones y los percebes.\nLos crustáceos son fundamentalmente acuáticos y habitan en todas las profundidades y en distintos medios, como el mar, el agua salobre y el agua dulce.Unos pocos han colonizado el medio terrestre, como la cochinilla de la humedad(isópodos). Los crustáceos son uno de los grupos zoológicos con mayor éxito biológico, tanto por el número de especies vivientes como por la diversidad de hábitats que colonizan; dominan los mares, como los insectos dominan la tierra.\nLos primeros crustáceos conocidos en el registro fósil datan de mediados del Cámbrico, se trata de los géneros Canadaspis y Perspicaris hallados en el yacimiento de Burgess Shale.2​ Numerosos restos fósiles pertenecientes a las clases Branchiopoda, Maxillopoda y Malacostraca aparecen a finales del Cámbrico.Cephalocarida es la única clase de la que no se ha encontrado registro fósil.3​\nComo casi todos los artrópodos, los crustáceos se caracterizan por poseer un exoesqueleto articulado, formado principalmente de quitina, un carbohidrato.\nUna característica propia y definitoria del grupo es la presencia de la larva nauplio, provista de un ojo naupliano en alguna etapa de su vida, que puede ser sustituido más tarde por dos ojos compuestos.Son los únicos artrópodos con dos pares de antenas y apéndices birrámeos. Tienen al menos un par de maxilas y pasan por periodos de muda e intermuda para poder crecer. Todos, excepto los de la infraclase Cirripedia, son de sexos separados.A la ciencia que estudia a los crustáceos se le denomina carcinología.";
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
