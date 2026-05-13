

using System.Windows;
using System.Windows.Controls;

namespace FaVSD
{
    public partial class NyOffertVy : UserControl
    {
        public NyOffertVy()
        {
            InitializeComponent();
        }


        private void GaTillMeny(Object sender, RoutedEventArgs e)
        {
            var mainWin = (MainWindow)Window.GetWindow(this);
            mainWin.Vy.Content = new MenyVy();
        }

        private void LaggTillOffertKlick(Object sender, RoutedEventArgs e)
        {

        }
        private void OppnaKundPanel(Object sender, RoutedEventArgs e)
        {
            DetaljPanel.Content = new NyOffertKunderPanel();
        }
        private void OppnaProduktPanel(Object sender, RoutedEventArgs e)
        {
            DetaljPanel.Content = new NyOffertProdukterPanel();
        }



    }
}

