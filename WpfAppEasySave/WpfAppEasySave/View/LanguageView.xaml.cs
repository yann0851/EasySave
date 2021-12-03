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

        private void Button_FR(object sender, RoutedEventArgs e)
        {
            SelectCulture("fr-FR");
        }
        private void Button_EN(object sender, RoutedEventArgs e)
        {
            SelectCulture("en-EN");
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Content = null;
        }
        public static void SelectCulture(string culture = null)
        {
            ResourceDictionary dict = new ResourceDictionary
            {
                Source = new Uri(@"Resources\" + (string.IsNullOrWhiteSpace(culture) ? string.Empty : culture) + ".xaml", UriKind.Relative)
            };

            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dict);
        }
    }
}
