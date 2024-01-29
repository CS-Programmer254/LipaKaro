using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaBankMicroservice.Domian.Entities
{
    public class AbsaBankDbContext:DbContext
    {
		public DbSet<AccountNumbers>BankAccounts { get; set; }	
		public DbSet<StudentAccount>StudentAccounts { get; set; }	
		public DbSet<AccountNumbers>BankAccounts { get; set; }	
		public DbSet<MoneyTransfer>MoneyTransfer{ get; set; }	
		public DbSet<TransactionStatus> TransactionStatus { get; set; }


        public AbsaBankDbContext(DbContextOptions<AbsaBankDbContext>options):base(options)
		{
			try
			{

			}
			catch (Exception)
			{

				throw;
			}

        }

    }
}
