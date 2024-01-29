using Microsoft.EntityFrameworkCore;
using WebApiBank.Models;

namespace WebApiBank.DataBase
{
    public class BankApiDB : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<CardAccount> CardAccounts { get; set; }
        public DbSet<CardReport> CardReports { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<InvestmentAccount> Investments { get; set; }
        public DbSet<InvestmentReport> InvestmentsReport { get; set;}
        public DbSet<InvestmentType> InvestmentTypes { get; set;}
        public DbSet<LoanAccount> Loans { get; set; }
        public DbSet<LoanType> LoansType { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAccount> UsersAccount { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocumentType>()
                .HasMany(DocumentType => DocumentType.Users)
                .WithOne(Users => Users.DocumentType)
                .HasForeignKey(Users => Users.DocumentTypeId)
                .IsRequired();
            
            modelBuilder.Entity<UserType>()
                .HasMany(UserType  => UserType.Users)
                .WithOne(Users => Users.UserType)
                .HasForeignKey(Users => Users.UserTypeId)
                .IsRequired();

            modelBuilder.Entity<Site>()
                .HasMany(Site => Site.Users)
                .WithOne(Users => Users.Site)
                .HasForeignKey(Users => Users.SiteId)
                .IsRequired();

            modelBuilder.Entity<Site>()
                .HasMany(Site => Site.Accounts)
                .WithOne(Accounts => Accounts.Site)
                .HasForeignKey(Accounts => Accounts.SiteId)
                .IsRequired();

            modelBuilder.Entity<AccountType>()
                .HasMany(AccountType => AccountType.Accounts)
                .WithOne(Accounts => Accounts.AccountType)
                .HasForeignKey(Accounts => Accounts.AccountTypeId)
                .IsRequired();
            
            modelBuilder.Entity<Account>()
                .HasMany(Account => Account.CardAccount)
                .WithOne(CardAccount => CardAccount.Account)
                .HasForeignKey(CardAccount => CardAccount.CardAccountId)
                .IsRequired();

            modelBuilder.Entity<Account>()
                .HasMany(Account => Account.InvestmentAccount)
                .WithOne(InvestmentAccount => InvestmentAccount.Account)
                .HasForeignKey(InvestmentAccount => InvestmentAccount.InvestmentAccountId)
                .IsRequired();

            modelBuilder.Entity<Account>()
                .HasMany(Account => Account.LoanAccounts)
                .WithOne(LoanAccount => LoanAccount.Account)
                .HasForeignKey(LoanAccount => LoanAccount.LoanId)
                .IsRequired();

            modelBuilder.Entity<Account>()
                .HasMany(Account => Account.UserAccounts)
                .WithOne(UserAccount => UserAccount.Accounts)
                .HasForeignKey(UserAccount => UserAccount.AccountId)
                .IsRequired();

            modelBuilder.Entity<User>()
                .HasMany(User => User.UsersAccount)
                .WithOne(UserAccount => UserAccount.Users)
                .HasForeignKey(UserAccount => UserAccount.UserId)
                .IsRequired();


            base.OnModelCreating(modelBuilder);
        }
    }
}
