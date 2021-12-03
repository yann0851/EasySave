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
        private Window window;
        private RepositoryViewModel repositoryViewModel;

        public PageSauvegarde(Window newWindow)
        {
            InitializeComponent();
            window = newWindow;
            Display();
            repositoryViewModel = new RepositoryViewModel();
        }

        private void Btn_Back(object sender, RoutedEventArgs e)
        {
            window.Content = new MainWindow();
        }

        private void Btn_save(object sender, RoutedEventArgs e)
        {
            RepositoryViewModel repositoryViewModel = new RepositoryViewModel();
            //SlotsSaveView slotSaveView = new SlotsSaveView();
            //slotSaveView.SlotsSaveV();
            //repositoryViewModel.PartialCopyRepository();
        }

        public void Display()
        {

            var bc = new BrushConverter();
            List<SaveModel> maListeDeSauvegarde = Context.GetInstance().GetListSaves().GetListSaves();
            Trace.WriteLine(maListeDeSauvegarde.Count);
            for (int i = 0; i < maListeDeSauvegarde.Count; i++)
            {
                RowDefinition gridRow1 = new RowDefinition();
                gridRow1.Height = new GridLength(45);
                TheGrid.RowDefinitions.Add(gridRow1);

                TextBlock Numero = new TextBlock();
                Numero.Text = i.ToString();
                Numero.FontSize = 12;
                Numero.FontWeight = FontWeights.Bold;
                Grid.SetRow(Numero, i + 1);
                Grid.SetColumn(Numero, 0);

                TextBlock NameSave = new TextBlock();
                NameSave.Text = maListeDeSauvegarde[i].Name;
                NameSave.FontSize = 12;
                NameSave.FontWeight = FontWeights.Bold;
                Grid.SetRow(NameSave, i + 1);
                Grid.SetColumn(NameSave, 1);

                TextBlock RepositorySource = new TextBlock();
                RepositorySource.Text = maListeDeSauvegarde[i].FolderSource;
                RepositorySource.FontSize = 12;
                Grid.SetRow(RepositorySource, i + 1);
                Grid.SetColumn(RepositorySource, 2);

                TextBlock RepositoryTarget = new TextBlock();
                RepositoryTarget.Text = maListeDeSauvegarde[i].FolderTarget;
                RepositoryTarget.FontSize = 12;
                Grid.SetRow(RepositoryTarget, i + 1);
                Grid.SetColumn(RepositoryTarget, 3);

                Button ButtonRemove = new Button();
                ButtonRemove.Content = "Supprimer";
                ButtonRemove.Click += Btn_Remove;
                ButtonRemove.Name = "BtnRemove_" + i.ToString();
                ButtonRemove.Background = (Brush)bc.ConvertFrom("#fa5252");
                Grid.SetRow(ButtonRemove, i + 1);
                Grid.SetColumn(ButtonRemove, 4);

                Button ButtonEdit = new Button();
                ButtonEdit.Content = "Edition";
                ButtonEdit.Click += Btn_Edit;
                ButtonEdit.Name = "BtnEdit_" + i.ToString();
                ButtonEdit.Background = (Brush)bc.ConvertFrom("#228be6");
                Grid.SetRow(ButtonEdit, i + 1);
                Grid.SetColumn(ButtonEdit, 5);

                Button ButtonFull = new Button();
                ButtonFull.Content = "Sauvegarde complète";
                ButtonFull.Click += Btn_Full;
                ButtonFull.Name = "BtnFull_" + i.ToString();
                ButtonFull.Background = (Brush)bc.ConvertFrom("#82c91e");
                Grid.SetRow(ButtonFull, i + 1);
                Grid.SetColumn(ButtonFull, 6);

                Button ButtonPartial = new Button();
                ButtonPartial.Content = "Sauvegarde partielle";
                ButtonPartial.Click += Btn_Partial;
                ButtonPartial.Name = "BtnPartial_" + i.ToString();
                ButtonPartial.Background = (Brush)bc.ConvertFrom("#82c91e");
                Grid.SetRow(ButtonPartial, i + 1);
                Grid.SetColumn(ButtonPartial, 7);

                /*ProgressBar Progress = new ProgressBar();
                Progress.Name = "progress_" + i.ToString();
                Progress.Value = 0;
                Grid.SetRow(Progress, i + 1);
                Grid.SetColumn(Progress, 8);*/

                // Add first row to Grid
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

        public void Update()
        {
            PageSauvegarde pageSauvegarde = new PageSauvegarde(window);
            window.Content = pageSauvegarde;
        }

        private void Btn_Edit(object sender, RoutedEventArgs e)
        {
            PageEdit pageEdit = new PageEdit(window);
            int iIndex = int.Parse((sender as Button).Name.Split("_")[1]);
            SaveModel save = Context.GetInstance().GetListSaves().GetListSaves().ElementAt(iIndex);
            pageEdit.FillForm(iIndex, save.Name, save.FolderSource, save.FolderTarget);
            window.Content = pageEdit;
        }

        private void Btn_Full(object sender, RoutedEventArgs e)
        {
            int iIndex = int.Parse((sender as Button).Name.Split("_")[1]);
            SaveModel save = Context.GetInstance().GetListSaves().GetListSaves().ElementAt(iIndex);
            repositoryViewModel.FullCopyRepository(save.FolderSource, save.FolderTarget, save.Name);
        }
        private void Btn_Partial(object sender, RoutedEventArgs e)
        {
            int iIndex = int.Parse((sender as Button).Name.Split("_")[1]);
            SaveModel save = Context.GetInstance().GetListSaves().GetListSaves().ElementAt(iIndex);
            repositoryViewModel.PartialCopyRepository(save.FolderSource, save.FolderTarget, save.Name);
        }

        private void Btn_Remove(object sender, RoutedEventArgs e)
        {
            Context.GetInstance().GetListSaves().RemoveSave(int.Parse((sender as Button).Name.Split("_")[1]));
            Update();
        }

        private void Btn_Create(object sender, RoutedEventArgs e)
        {
            PageAdd pageAdd = new PageAdd(window);
            window.Content = pageAdd;
        }
    }
}
