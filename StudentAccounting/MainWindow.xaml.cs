using StudentAccounting.BusinessLogic.Implementations;
using StudentAccounting.Controllers;
using StudentAccounting.Model.DataBaseModels;
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

namespace StudentAccounting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OrganizationService _organizationService = new();
        public MainWindow()
        {
           InitializeComponent();
            UpdateGrid();
        }
        public void AddNewOrganization_Clicked(object sender, RoutedEventArgs e)
        {
            OrganizationWindow win = new OrganizationWindow();
            win.Show();
        }
        public void UpdateGrid()
        {
            dataGridTutorial.ItemsSource = null;
            dataGridTutorial.ItemsSource =  _organizationService.Get();
        }
        public void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {

            if (dataGridTutorial.SelectedItems.Count > 0 && MessageBox.Show("Подтвердить удаление", "Удаление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                for (int i = 0; i < dataGridTutorial.SelectedItems.Count; i++)
                {
                    Organization organization = dataGridTutorial.SelectedItems[i] as Organization;
                    if (organization != null)
                    {
                        _organizationService.Delete(organization);
                    }
                }
            }
            UpdateGrid();

        }
        public void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            _organizationService.Edit(e.Row.Item as Organization);
            UpdateGrid();
        }
    }
}
