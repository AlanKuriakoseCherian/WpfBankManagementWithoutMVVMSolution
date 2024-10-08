using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBankManagementWithoutWVVM
{
    public class Account 
    {
        private decimal _balance;
        public int AccNo { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public string AccType { get; set; }
        public String Email { get; set; }
        public String PhNo { get; set; }

        public string Address { get; set; }
      
        public bool IsActive { get; set; }
        public string InterestPercentage { get; set; }

        public int TransactionCount { get; set; }   
      
        public DateTime LastTransactionDate {  get; set; }

        
    }
}