using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfBankManagementWithoutWVVM;

namespace WpfBankManagementWithoutMVVM
{
    public class AccountMemoryRepo : IAccountRepo
    {
        ObservableCollection<Account> accounts = new ObservableCollection<Account>()
        {
            new Account
            {
                AccNo = 1234,
                Name = "Alan",
                Balance = 0,
                AccType = "savings",
                Email = "alan@gmail.com",
                PhNo = "789456123",
                Address = "xxx street",
                IsActive = true,
                InterestPercentage = "0",
                TransactionCount = 0,
                LastTransactionDate = DateTime.Now,
            },
            new Account
            {
                AccNo = 1964,
                Name = "Girish",
                Balance = 0,
                AccType = "savings",
                Email = "girish@gmail.com",
                PhNo = "789456123",
                Address = "xxx street",
                IsActive = true,
                InterestPercentage = "0",
                TransactionCount = 0,
                LastTransactionDate = DateTime.Now,


            },
              new Account
            {
                AccNo = 1134,
                Name = "Abhijith",
                Balance = 0,
                AccType = "savings",
                Email = "abhijith@gmail.com",
                PhNo = "789456123",
                Address = "xxx street",
                IsActive = true,
                InterestPercentage = "0",
                TransactionCount = 0,
                LastTransactionDate = DateTime.Now,


            }
        };
        public void CalculateInterestAndUpdateBalance()
        {
            throw new NotImplementedException();
        }

        public void Create(Account accModel)
        {
            accounts.Add(accModel);
        }

       

        public void DeleteAccount(Account account)
        {
            throw new NotImplementedException();
        }

      

        public void Deposit(int acNo, int Amount)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Account> ReadAllAccount()
        {
            return accounts;
        }

        public List<Account> SortByName()
        {
            throw new NotImplementedException();
        }

        public List<Account> SortByNum()
        {
            throw new NotImplementedException();
        }

        public void UpdateAccount(Account accModel)
        {
            throw new NotImplementedException();
        }

       
        public void Withdraw(int acNo, int Amount)
        {
            throw new NotImplementedException();
        }


    }
}
