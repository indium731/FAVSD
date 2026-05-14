
using System.Windows;
using System.Windows.Controls;

namespace FaVSD
{
    public partial class PlocklistaHuvudPanel: UserControl
    {
        public PlocklistaHuvudPanel()
        {
            InitializeComponent();
        }


        private void GaTillMeny(Object sender, RoutedEventArgs e)
        {
            var mainWin = (MainWindow)Window.GetWindow(this);
            mainWin.Vy.Content = new MenyVy();
        }

        private void TestaLaggTillPlocklistaKlick(Object sender, RoutedEventArgs e)
        {
        }
        private void TaBortValdKlick(Object sender, RoutedEventArgs e)
        {

        }

        private void AndraValdPlocklista(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
        }

        private void UppdateraValdPlocklistaKlick(Object sender, RoutedEventArgs e)
        {
            var mainWin = Window.GetWindow(this);
            
            var vyInstance = mainWin.FindName("Vy") as ContentControl;
            if (vyInstance.Content is PlocklistaVy plv)
            {

                plv.SattDetaljPanel(new ValdPlocklistaVy());
            }
        }

        private void AndraSorteringKlick(Object sender, RoutedEventArgs e)
        {
        }
        private void SokKlick(Object sender, RoutedEventArgs e)
        {
        }

    }
}

