using System.Windows;
using System.Windows.Controls;

namespace FaVSD
{
    public partial class KonverteraVy : UserControl
    {
        public KonverteraVy()
        {
            InitializeComponent();
        }


        private void GaTillMeny(Object sender, RoutedEventArgs e)
        {
            var mainWin = (MainWindow)Window.GetWindow(this);
            mainWin.Vy.Content = new MenyVy();
        }

        private void TestaLaggTillOffertKlick(Object sender, RoutedEventArgs e)
        {
        }
        private void TaBortValdKlick(Object sender, RoutedEventArgs e)
        {
        }

        private void AndraValdOffert(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
        }

        private void UppdateraValdOffertKlick(Object sender, RoutedEventArgs e)
        {
        }

        private void AndraSorteringKlick(Object sender, RoutedEventArgs e)
        {
        }
        private void SokKlick(Object sender, RoutedEventArgs e)
        {
        }
        private void KonverteraValdOffertKlick(Object sender, RoutedEventArgs e)
        {
        }

    }
}

