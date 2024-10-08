using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfBankManagementWithoutWVVM;

namespace WpfBankManagementWithoutMVVM
{
    /// <summary>
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Window
    {
        ObservableCollection<Account> accounts = null; 

        public CreateAccount()
        {
            InitializeComponent();
            accounts = FormConfig.repo.ReadAllAccount();
            grdAccount.ItemsSource = accounts;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            FormConfig.newAccount.Show();

        }
    }
}
