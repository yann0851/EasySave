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
using WpfAppEasySave.ViewModel;

namespace WpfAppEasySave.View
{
    /// <summary>
    /// Logique d'interaction pour PageEdit.xaml
    /// </summary>
    public partial class PageEdit : Page
    {
        private Window window;
        public PageEdit(Window newWindow)
        {
            InitializeComponent();
            window = newWindow;
        }

        private void Btn_Modify(object sender, RoutedEventArgs e)
        {
            string Name = Repository_name.Text;
            string RepositorySource = Repository_source.Text;
            string RepositoryCible = Repository_target.Text;
            //Context.GetInstance().GetListSaves().EditSave(Name, RepositorySource, RepositoryCible);
        }

        private void Btn_Back(object sender, RoutedEventArgs e)
        {
            PageSauvegarde pageSauvegarde = new PageSauvegarde(window);
            window.Content = pageSauvegarde;
        }
    }
}
