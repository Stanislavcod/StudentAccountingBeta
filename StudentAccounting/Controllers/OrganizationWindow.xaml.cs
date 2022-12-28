using StudentAccounting.BusinessLogic.Implementations;
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
using System.Windows.Shapes;

namespace StudentAccounting.Controllers
{
    /// <summary>
    /// Логика взаимодействия для OrganizationWindow.xaml
    /// </summary>
    public partial class OrganizationWindow : Window
    {
        OrganizationService _organizationService;
        public OrganizationWindow()
        {
            InitializeComponent();
            _organizationService = new OrganizationService();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(NameOrganization.Text) || !String.IsNullOrEmpty(AddressOrganization.Text) || !String.IsNullOrEmpty(ContactsOrganization.Text))
                {
                    _organizationService.Create(new Organization { Fullname = NameOrganization.Text, Address = AddressOrganization.Text, Contacts = ContactsOrganization.Text });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
