using DataAccesLayer.Repositories.AccountsRepo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.ServeceForAccounts
{
    public class AccountService
    {
        AccountsRepository _accountRepository;

        public AccountService(AccountsRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public DataTable GetAccountsPaybles()
        {
            return _accountRepository.GetAccountsPayble();
        }

        public DataTable GetPaidAccounts()
        {
            return _accountRepository.GetPaidAccounts();
        }

        public void PayAccount(int accountId, decimal amount)
        {
            _accountRepository.PayAccount(accountId, amount);
        }
    }
}
