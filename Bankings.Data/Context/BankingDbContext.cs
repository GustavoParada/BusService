using Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Bankings.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Account> Accounts { get; set; }
    }
}
