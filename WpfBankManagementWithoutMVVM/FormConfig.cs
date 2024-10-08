using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBankManagementWithoutMVVM
{
    public static class FormConfig
    {
        public static NewAccount newAccount = null;
        public static CreateAccount createAccount = null;
        public static IAccountRepo repo = null;

        static FormConfig()
        {
            repo = new AccountMemoryRepo();
            newAccount = new NewAccount();
            createAccount = new CreateAccount();

        }

    }
}
