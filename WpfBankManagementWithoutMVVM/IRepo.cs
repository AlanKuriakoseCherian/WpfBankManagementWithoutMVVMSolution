using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfBankManagementWithoutWVVM;

namespace WpfBankManagementWithoutMVVM
{
    public interface IAccountRepo
    {
        void Create(Account accModel);

        void UpdateAccount(Account accModel);

        void DeleteAccount(Account account);
        void Deposit(int acNo, int Amount);
        void Withdraw(int acNo, int Amount);
        void CalculateInterestAndUpdateBalance();
        ObservableCollection<Account> ReadAllAccount();

        List<Account> SortByName();
        List<Account> SortByNum();

    }
}
