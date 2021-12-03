using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
using Repository;
using SlotsSave;
using WpfAppEasySave.ViewModel;

namespace WpfAppEasySave.View
{
    /// <summary>
    /// Logique d'interaction pour PageSauvegarde.xaml
    /// </summary>
    public partial class PageSauvegarde : Page
    {
        private RepositoryViewModel repositoryViewModel;
        private Window window;

        public PageSauvegarde(Window newWindow)
        {
            InitializeComponent();
            window = newWindow;
            Display();
            repositoryViewModel = new RepositoryViewModel();
        }

        public void Display() // Montrer toutes les sauvegardes et les boutons
        {
            var bc = new BrushConverter(); // Pour changer la couleur (création de la variable)
            List<SaveModel> maListeDeSauvegarde = Context.GetInstance().GetListSaves().GetListSaves(); // On va chercher le contenu de notre liste
            //Trace.WriteLine(maListeDeSauvegarde.Count); // vérification du contenu de la liste sous forme de int 
            for (int i = 0; i < maListeDeSauvegarde.Count; i++) // Pour chaque élément de la liste on va ajouter plusieurs données
            {
                RowDefinition gridRow1 = new RowDefinition();
                gridRow1.Height = new GridLength(45);
                TheGrid.RowDefinitions.Add(gridRow1); // Ajout de la première ligne c'est l'entête

                TextBlock Numero = new TextBlock(); // Affiche le numéro de la sauvegarde
                Numero.Text = i.ToString(); // On met le numéro dans le tableau
                Numero.FontSize = 12; // Taille de la police
                Numero.FontWeight = FontWeights.Bold; // Epaisseur de la police
                Grid.SetRow(Numero, i + 1); // On fait le numéro + 1 car on a une première ligne qui est l'entête et aussi pour afficher les autres numéros par la suite
                Grid.SetColumn(Numero, 0); // La place dans le tableau 0 car première case

                TextBlock NameSave = new TextBlock(); // Le nom de la sauvegarde
                NameSave.Text = maListeDeSauvegarde[i].Name; // Récupère le numéro de l'élément (par exemple 0 si premier élément) dans la liste pour mettre le bon nom de sauvegarde
                NameSave.FontSize = 12;
                NameSave.FontWeight = FontWeights.Bold;
                Grid.SetRow(NameSave, i + 1);
                Grid.SetColumn(NameSave, 1);

                TextBlock RepositorySource = new TextBlock(); // Chemin du répertoire source de la sauvegarde
                RepositorySource.Text = maListeDeSauvegarde[i].FolderSource;
                RepositorySource.FontSize = 12;
                Grid.SetRow(RepositorySource, i + 1);
                Grid.SetColumn(RepositorySource, 2);

                TextBlock RepositoryTarget = new TextBlock(); // Chemin du répertoire cible de la sauvegarde
                RepositoryTarget.Text = maListeDeSauvegarde[i].FolderTarget;
                RepositoryTarget.FontSize = 12;
                Grid.SetRow(RepositoryTarget, i + 1);
                Grid.SetColumn(RepositoryTarget, 3);

                Button ButtonRemove = new Button(); // Bouton supprimer
                ButtonRemove.Content = "Supprimer"; // Nom du bouton
                ButtonRemove.Click += Btn_Remove; // Méthode appeler lors du clique sur le bouton
                ButtonRemove.Name = "BtnRemove_" + i.ToString(); // Nom du bouton + numéro de ligne
                ButtonRemove.Background = (Brush)bc.ConvertFrom("#fa5252"); // couleur
                Grid.SetRow(ButtonRemove, i + 1);
                Grid.SetColumn(ButtonRemove, 4);

                Button ButtonEdit = new Button(); // Bouton édit
                ButtonEdit.Content = "Edition";
                ButtonEdit.Click += Btn_Edit;
                ButtonEdit.Name = "BtnEdit_" + i.ToString();
                ButtonEdit.Background = (Brush)bc.ConvertFrom("#228be6");
                Grid.SetRow(ButtonEdit, i + 1);
                Grid.SetColumn(ButtonEdit, 5);

                Button ButtonFull = new Button(); // Bouton pour sauvegarde complète
                ButtonFull.Content = "Sauvegarde complète";
                ButtonFull.Click += Btn_Full;
                ButtonFull.Name = "BtnFull_" + i.ToString();
                ButtonFull.Background = (Brush)bc.ConvertFrom("#82c91e");
                Grid.SetRow(ButtonFull, i + 1);
                Grid.SetColumn(ButtonFull, 6);

                Button ButtonPartial = new Button(); // Bouton pour sauvegarde partielle
                ButtonPartial.Content = "Sauvegarde partielle";
                ButtonPartial.Click += Btn_Partial;
                ButtonPartial.Name = "BtnPartial_" + i.ToString();
                ButtonPartial.Background = (Brush)bc.ConvertFrom("#82c91e");
                Grid.SetRow(ButtonPartial, i + 1);
                Grid.SetColumn(ButtonPartial, 7);

                //ProgressBar Progress = new ProgressBar(); //Barre de progression
                //Progress.Name = "progress_" + i.ToString();
                //Progress.Value = 0;
                //Grid.SetRow(Progress, i + 1);
                //Grid.SetColumn(Progress, 8);

                // Ajoute les éléments dans le tableau
                TheGrid.Children.Add(Numero);
                TheGrid.Children.Add(NameSave);
                TheGrid.Children.Add(RepositorySource);
                TheGrid.Children.Add(RepositoryTarget);
                TheGrid.Children.Add(ButtonRemove);
                TheGrid.Children.Add(ButtonEdit);
                TheGrid.Children.Add(ButtonFull);
                TheGrid.Children.Add(ButtonPartial);
                //TheGrid.Children.Add(Progress);
            }
        }

        public void Update() // Mise à jour de la page
        {
            PageSauvegarde pageSauvegarde = new PageSauvegarde(window);
            window.Content = pageSauvegarde;
        }

        private void Btn_Edit(object sender, RoutedEventArgs e) // Méthode pour le bouton édition
        {
            PageEdit pageEdit = new PageEdit(window);
            int iIndex = int.Parse((sender as Button).Name.Split("_")[1]); // On récupère le numéro de la sauvegarde grâce au numéro du bouton en séparant à partir de _ pour prendre le numéro
            SaveModel save = Context.GetInstance().GetListSaves().GetListSaves().ElementAt(iIndex); // Récupère les données qu'on a besoin
            pageEdit.FillForm(iIndex, save.Name, save.FolderSource, save.FolderTarget); // appel de la méthode pour remplir les textbox avec les données
            window.Content = pageEdit;
        }

        private void Btn_Full(object sender, RoutedEventArgs e) // Méthode pour le bouton sauvegarde complète
        {
            int iIndex = int.Parse((sender as Button).Name.Split("_")[1]);
            SaveModel save = Context.GetInstance().GetListSaves().GetListSaves().ElementAt(iIndex);
            repositoryViewModel.FullCopyRepository(save.FolderSource, save.FolderTarget, save.Name); // Méthode pour la sauvegarde complète
        }
        private void Btn_Partial(object sender, RoutedEventArgs e) // Méthode pour le bouton sauvegarde partielle
        {
            int iIndex = int.Parse((sender as Button).Name.Split("_")[1]);
            SaveModel save = Context.GetInstance().GetListSaves().GetListSaves().ElementAt(iIndex);
            repositoryViewModel.PartialCopyRepository(save.FolderSource, save.FolderTarget, save.Name); // Méthode pour la sauvegarde partielle
        }

        private void Btn_Remove(object sender, RoutedEventArgs e)
        {
            Context.GetInstance().GetListSaves().RemoveSave(int.Parse((sender as Button).Name.Split("_")[1])); // On récupère le numéro pour supprimer la sauvegarde
            Update(); // Appel de la mise à jour
            // Si sauvegardes qui se gardent il faudra pt rajouter un truc pour le supprimer dans fichier Json ou autre
        }

        private void Btn_Create(object sender, RoutedEventArgs e) // Méthode pour le bouton créer
        {
            PageAdd pageAdd = new PageAdd(window);
            window.Content = pageAdd; // Aller à la page
        }

        private void Btn_Back(object sender, RoutedEventArgs e)
        {
            PageAccueil pageAccueil = new PageAccueil(window);
            window.Content = pageAccueil;
        }
    }
}
