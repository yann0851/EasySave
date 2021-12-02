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

namespace Language
{
    /// <summary>
    /// Logique d'interaction pour LanguageView.xaml
    /// </summary>
    public partial class LanguageView : Page
    {
        LanguageViewModel languageViewModel;
        public LanguageView()
        {
            InitializeComponent();
            languageViewModel = new LanguageViewModel();
        }
        public void Button_FR(object sender, RoutedEventArgs e)
        {
            languageViewModel.Button_FR();
        }

        public void Button_EN(object sender, RoutedEventArgs e)
        {
            languageViewModel.Button_EN();
        }
    }
}
