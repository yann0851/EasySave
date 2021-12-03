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
    /// Logique d'interaction pour PageLangue.xaml
    /// </summary>
    public partial class PageLangue : Page
    {
        public PageLangue()
        {
            InitializeComponent();
        }

        private void Btn_Retour(object sender, RoutedEventArgs e)
        {
            Content = null;
        }
    }
}
