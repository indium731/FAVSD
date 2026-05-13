using System.Windows;
using System.Windows.Controls;

namespace FaVSD 
{
    public partial class InloggVy : UserControl
    {
        public InloggVy()
        {
            InitializeComponent();
        }
    

        private void TestaInloggKlick(object sender, RoutedEventArgs e)
        {
            var mainWin = (MainWindow)Window.GetWindow(this);
            mainWin.Vy.Content = new MenyVy();
        }
    }
}

