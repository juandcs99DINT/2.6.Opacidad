using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Opacidad
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CambiarOpacity_mouseEnter(object sender, RoutedEventArgs e)
        {
            Image imagen = (Image)sender;
            imagen.Opacity = 1;
            
        }

        private void CambiarOpacity_mouseLeave(object sender, RoutedEventArgs e)
        {
            Image imagen = (Image)sender;
            imagen.Opacity = 0.5;
        }

    }
}
