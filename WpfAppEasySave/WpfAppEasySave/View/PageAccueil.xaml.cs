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
    /// Logique d'interaction pour PageAccueil.xaml
    /// </summary>
    public partial class PageAccueil : Page
    {
        private Window window;
        public PageAccueil(Window newWindow)
        {
            InitializeComponent();
            window = newWindow;
        }
        private void Ouvrir_Langue(object sender, RoutedEventArgs e)
        {
            Accueil.Content = new PageLangue(window);
        }

        private void Ouvrir_Sauvegarde(object sender, RoutedEventArgs e)
        {
            Accueil.Content = new PageSauvegarde(window);
        }

        private void Ouvrir_Log(object sender, RoutedEventArgs e)
        {
            Accueil.Content = new PageLog(window);
        }

        private void Ouvrir_Etat(object sender, RoutedEventArgs e)
        {
            Accueil.Content = new PageEtat(window);
        }

    }
}
