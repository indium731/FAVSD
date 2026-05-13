using System.Windows;
using System.Windows.Controls;

namespace FaVSD
{
    public partial class NyOffertKunderPanel: UserControl
    {
        public NyOffertKunderPanel()
        {
            InitializeComponent();
        }


        private void GaTillMeny(Object sender, RoutedEventArgs e)
        {
            var mainWin = (MainWindow)Window.GetWindow(this);
            mainWin.Vy.Content = new MenyVy();
        }

        private void LaggTillKundKlick(Object sender, RoutedEventArgs e)
        {
        }
        private void TaBortValdKlick(Object sender, RoutedEventArgs e)
        {
        }
        private void TaBortProduktKlick(Object sender, RoutedEventArgs e)
        {

        }
        private void LaggTillProduktKlick(Object sender, RoutedEventArgs e)
        {

        }


    }
}

