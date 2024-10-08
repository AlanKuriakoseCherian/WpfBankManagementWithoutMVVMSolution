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
using WpfBankManagementWithoutWVVM;

namespace WpfBankManagementWithoutMVVM
{
    /// <summary>
    /// Interaction logic for NewAccount.xaml
    /// </summary>
    public partial class NewAccount : Window
    {
        public NewAccount()
        {
            InitializeComponent();
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            var AccNo = txtAccountNo.Text;
            var Name = txtName.Text;
            var Balance = txtBalance.Text;
            var Email = txtEmail.Text;
            var Address = txtAddress.Text;
            var Phone = txtPhone.Text;

            Account account = new Account
            {
                AccNo = int.Parse(AccNo),
                Name = Name,
                Balance = int.Parse(Balance),
                Email = Email,
                Address = Address,
                PhNo = Phone
            };

            FormConfig.repo.Create(account);
            
        }
    }
}
