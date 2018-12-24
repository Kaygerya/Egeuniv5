namespace BankaIslemleri.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using BankaIslemleri.Data.Entities;

    public partial class BankaIslemleriModel : DbContext
    {
        public BankaIslemleriModel()
            : base("name=BankaIslemleriModel")
        {
        }


        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
