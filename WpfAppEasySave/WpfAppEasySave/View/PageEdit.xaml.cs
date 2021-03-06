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
            DataContext = new SaveListViewModel();
            window = newWindow;
        }

        private void Btn_Modify(object sender, RoutedEventArgs e) // Bouton modifier pour modifier le contenu du formulaire
        {
            //int iIndex = int.Parse(Id.Text); 
            string sName = Repository_name.Text;
            string sRepositorySource = Repository_source.Text;
            string sRepositoryCible = Repository_target.Text;
            Context.GetInstance().GetListSaves().EditSave(sName, sRepositorySource, sRepositoryCible);
        }

        private void Btn_Back(object sender, RoutedEventArgs e) // bouton retour
        {
            PageSauvegarde pageSauvegarde = new PageSauvegarde(window);
            window.Content = pageSauvegarde;
        }

        /*public void FillForm(int iIndex, string sName, string sFolderSource, string sFolderTarget) // Bouton qui va remplir le contenu du formulaire
        {
            Repository_name.Text = sName;
            Repository_source.Text = sFolderSource;
            Repository_target.Text = sFolderTarget;
            Id.Text = Convert.ToString(iIndex);
        }*/
    }
}
