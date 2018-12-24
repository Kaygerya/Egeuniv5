
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaIslemleri.Data.Entities
{
    public class User
    {

        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }
        public string Tel { get; set; }

        public virtual ICollection<BankAccount> BankAccounts { get; set; }

    }
}
