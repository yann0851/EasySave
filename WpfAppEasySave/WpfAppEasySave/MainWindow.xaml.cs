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
using WpfAppEasySave.View;
using Language;

namespace WpfAppEasySave
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Ouverture_menu();
        }

        private void OpenSave(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageSauvegarde(this);
        }

        private void OpenLogs(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageLog(this);
        }

        private void OpenEtat(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageEtat(this);
        }

        /* private void Ouvrir_Langue(object sender, RoutedEventArgs e)
        {
            Main.Content = new LanguageView();
        }

        private void Ouvrir_Sauvegarde(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageSauvegarde(this);
        }

        private void Ouvrir_Log(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageLog(this);
        }

        private void Ouvrir_Etat(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageEtat();
        }*/

        //public void Ouverture_menu()
        //{
        //    PageAccueil pageAccueil = new PageAccueil(this);
        //    Content = pageAccueil;
        //}
    }
}
