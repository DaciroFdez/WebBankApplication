using Microsoft.EntityFrameworkCore;
using WebApiBank.Models;

namespace WebApiBank.DataBase
{
    
    public class BankApiDB : DbContext
    {
        public IConfiguration _config { get; set; }
        public BankApiDB(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("BankApiDB"));
        }

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
            modelBuilder.Entity<Account>()
                .HasKey(Account => Account.AccountId);

            modelBuilder.Entity<AccountType>()
                .HasKey(AccountType => AccountType.AccountTypeId);

            modelBuilder.Entity<CardAccount>()
                .HasKey(CardAccount => CardAccount.CardAccountId);

            modelBuilder.Entity<CardReport>()
                .HasKey(CardReport => CardReport.CardReportId);

            modelBuilder.Entity<CardType>()
                .HasKey(CardType => CardType.CardTypeId);

            modelBuilder.Entity<DocumentType>()
                .HasKey(DocumentType => DocumentType.DocumentTypeId);

            modelBuilder.Entity<InvestmentAccount>()
                .HasKey(InvestmentAccount => InvestmentAccount.InvestmentAccountId);

            modelBuilder.Entity<InvestmentReport>()
                .HasKey(InvestmentReport => InvestmentReport.InvestmentReportId);

            modelBuilder.Entity<InvestmentType>()
                .HasKey(InvestmentType => InvestmentType.InvestmentTypeId);

            modelBuilder.Entity<LoanAccount>()
                .HasKey(LoanAccount => LoanAccount.LoanId);

            modelBuilder.Entity<LoanType>()
                .HasKey(LoanType => LoanType.LoanTypeId);

            modelBuilder.Entity<Site>()
                .HasKey(Site => Site.SiteId);

            modelBuilder.Entity<Transaction>()
                .HasKey(Transaction => Transaction.TransactionId);

            modelBuilder.Entity<TransactionType>()
                .HasKey(TransactionType => TransactionType.TransactionTypeId);

            modelBuilder.Entity<User>()
                .HasKey(User => User.UserId);

            modelBuilder.Entity<UserType>()
                .HasKey(UserType => UserType.UserTypeId);

            modelBuilder.Entity<UserAccount>()
                .HasKey(UserAccount => UserAccount.UserAccoutId);


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

            modelBuilder.Entity<InvestmentAccount>()
                .HasMany(InvestmentAccount => InvestmentAccount.Investments)
                .WithOne(InvestmentReport => InvestmentReport.Investment)
                .HasForeignKey(InvestmentReport => InvestmentReport.InvestmentId)
                .IsRequired();

            modelBuilder.Entity<InvestmentType>()
                .HasMany(InvestmentType => InvestmentType.Account)
                .WithOne(InvestmentAccount => InvestmentAccount.InvestmentType)
                .HasForeignKey(InvestmentAccount => InvestmentAccount.InvestmentTypeId)
                .IsRequired();

            modelBuilder.Entity<CardAccount>()
                .HasMany(CardAccount => CardAccount.Report)
                .WithOne(CardReport => CardReport.CardAccount)
                .HasForeignKey(CardReport => CardReport.CardAccountId)
                .IsRequired();

            modelBuilder.Entity<CardType>()
                .HasMany(CardType => CardType.CardAccount)
                .WithOne(CardAccount => CardAccount.CardType)
                .HasForeignKey(CardAccount => CardAccount.CardTypeId)
                .IsRequired();

            modelBuilder.Entity<LoanType>()
                .HasMany(LoanType => LoanType.LoanAccounts)
                .WithOne(LoanAccount => LoanAccount.LoanType)
                .HasForeignKey(LoanAccount => LoanAccount.LoanId)
                .IsRequired();

            modelBuilder.Entity<TransactionType>()
                .HasMany(TransactionType => TransactionType.Transactions)
                .WithOne(Transaction => Transaction.TransactionType)
                .HasForeignKey(Transaction => Transaction.TransactionTypeId)
                .IsRequired();

            modelBuilder.Entity<Account>()
                .HasMany(Account => Account.TransactionOrigin)
                .WithOne(Transaction => Transaction.AccountOrigin)
                .HasForeignKey(Transaction => Transaction.AccountOriginId)
                .IsRequired();

            modelBuilder.Entity<Account>()
                .HasMany(Account => Account.TransactionDestiny)
                .WithOne(Transaction => Transaction.AccountDestination)
                .HasForeignKey(Transaction => Transaction.AccountDestinationId)
                .IsRequired();

            //Ajuste
            modelBuilder.Entity<Transaction>()
                .Property(Transaction => Transaction.Amount)
                .HasColumnType("decimal(18, 2)");

            //base.OnModelCreating(modelBuilder);
        }
    }
}
