using System;
using System.Collections.Generic;
using System.Text;
using KaiCoinMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KaiCoinMVC.Data
{
    public class BankDbContext : IdentityDbContext<IdentityUser>
    {
        public BankDbContext(DbContextOptions<BankDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Account { get; set; }

        public DbSet<Transaction> Transaction { get; set; }

    }
}
