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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppEasySave.View
{
    /// <summary>
    /// Logique d'interaction pour PageLog.xaml
    /// </summary>
    public partial class PageLog : Page
    {
        private Window window;

        public PageLog(Window newWindow)
        {
            InitializeComponent();
            window = newWindow;
        }

        private void Btn_Back(object sender, RoutedEventArgs e)
        {
            
            PageAccueil pageAccueil = new PageAccueil(window);
            window.Content = pageAccueil;
        }
    }
}
