using System.Windows;
using System.Windows.Controls;

namespace FaVSD 
{
    public partial class MenyVy : UserControl
    {
        public MenyVy()
        {
            InitializeComponent();
            KontrolleraAtkomster();
        }

        private void TestaUtloggKlick(Object sender, RoutedEventArgs e)
        {
            var mainWin = (MainWindow)Window.GetWindow(this);
            mainWin.Vy.Content = new InloggVy();
        }

        private void GaTillValdVy(Object sender, RoutedEventArgs e)
        {
            Button knapp = (Button)sender;
            var mainWin = (MainWindow)Window.GetWindow(this);
            mainWin.Vy.Content = knapp.Tag;
        }
        private void KontrolleraAtkomster()
        {

        }
    }
}

