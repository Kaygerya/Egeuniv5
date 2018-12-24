
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaIslemleri.Data.Entities
{
    public class BankAccount
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        //public string UserId { get; set; }
        public string AccountNumber { get; set; }
        public int Amount { get; set; }

        public virtual User User { get; set; }
    }
}
