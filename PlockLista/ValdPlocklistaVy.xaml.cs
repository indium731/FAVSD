using System.Windows;
using System.Windows.Controls;

namespace FaVSD
{
    public partial class ValdPlocklistaVy : UserControl
    {
        public ValdPlocklistaVy()
        {
            InitializeComponent();
        }


        private void GaTillMeny(Object sender, RoutedEventArgs e)
        {
            var mainWin = (MainWindow)Window.GetWindow(this);
            mainWin.Vy.Content = new MenyVy();
        }
         private void OppnaHuvudPanel(Object sender, RoutedEventArgs e)
        {
            var mainWin = Window.GetWindow(this);
            
            var vyInstance = mainWin.FindName("Vy") as ContentControl;
            if (vyInstance.Content is PlocklistaVy plv)
            {

                plv.SattDetaljPanel(new PlocklistaHuvudPanel());
            }
        }

        private void SparaAndringKlick(Object sender, RoutedEventArgs e)
        {
            var mainWin = (MainWindow)Window.GetWindow(this);
            mainWin.Vy.Content = new MenyVy();
        }

    }
}

