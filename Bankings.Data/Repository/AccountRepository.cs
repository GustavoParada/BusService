using Banking.Domain.Interfaces;
using Banking.Domain.Models;
using Bankings.Data.Context;
using System.Collections.Generic;

namespace Bankings.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _ctx;
        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
