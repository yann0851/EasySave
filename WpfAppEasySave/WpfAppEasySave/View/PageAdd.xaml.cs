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
    /// Logique d'interaction pour PageAdd.xaml
    /// </summary>
    public partial class PageAdd : Page
    {
        private Window window;
        public PageAdd(Window newWindow)
        {
            InitializeComponent();
            window = newWindow;
        }

        private void Btn_Back(object sender, RoutedEventArgs e) // Bouton retour en arrière
        {
            PageSauvegarde pageSauvegarde = new PageSauvegarde(window);
            window.Content = pageSauvegarde; // Retour sur la page sauvegarde
        }
        public void Btn_FolderBrowserSource(object sender, RoutedEventArgs e) // Ouvrir un sélecteur de fichier
        {
            System.Windows.Forms.FolderBrowserDialog openFileDlg = new System.Windows.Forms.FolderBrowserDialog();
            var result = openFileDlg.ShowDialog();
            if (result.ToString() != string.Empty)
            {
                string sSelectedRepository = openFileDlg.SelectedPath; // Répertoire sélectionné
                Repository_source.Text = sSelectedRepository;
            }
        }
        public void Btn_FolderBrowserTarget(object sender, RoutedEventArgs e) // Ouvrir un sélecteur de fichier
        {
            System.Windows.Forms.FolderBrowserDialog openFileDlg = new System.Windows.Forms.FolderBrowserDialog();
            var result = openFileDlg.ShowDialog();
            if (result.ToString() != string.Empty)
            {
                string sSelectedRepository = openFileDlg.SelectedPath; // Répertoire sélectionné
                Repository_target.Text = sSelectedRepository;
            }
        }

        private void Btn_CreateSave(object sender, RoutedEventArgs e) // Créer une sauvegarde
        {
            string Name = Repository_name.Text;
            string RepositorySource = Repository_source.Text;
            string RepositoryCible = Repository_target.Text;
            Context.GetInstance().GetListSaves().AddSave(Name, RepositorySource, RepositoryCible); // On reprend toutes les variables et on appelle la fonction
        }
    }
}
