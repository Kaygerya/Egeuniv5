using BankaIslemleri.Data;
using BankaIslemleri.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaIslemleri.Services
{
    public static class UserService
    {
        public static void CreateUser(User user)
        {
            BankaIslemleriModel entities = new BankaIslemleriModel();
            entities.Users.Add(user);
            entities.SaveChanges();
        }

        public static User GetUserById(int userId)
        {
            if (userId >0)
            {
                BankaIslemleriModel entities = new BankaIslemleriModel();
                var user = entities.Users.Where(k => k.Id == userId).FirstOrDefault();
                return user;
            }
            else return null;
        }

        public static List<User> GetAllUsers()
        {
            BankaIslemleriModel entities = new BankaIslemleriModel();
            return entities.Users.ToList();
        }

        public static void InsertBankAccountToUser(BankAccount bankAccount, int userId)
        {
            if (bankAccount != null)
            {
                BankaIslemleriModel entities = new BankaIslemleriModel();
                var user = GetUserById(userId);
                if (user != null)
                {
                    entities.Users.Where(k => k.Id == userId).FirstOrDefault().BankAccounts.Add(bankAccount);
                    entities.SaveChanges();
                }
            }
        }

        public static void UpdateUser(User user)
        {
            BankaIslemleriModel entities = new BankaIslemleriModel();
            entities.SaveChanges();
        }
    }
}
