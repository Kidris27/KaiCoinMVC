using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KaiCoinMVC.Models
{
    public class Transaction
    {
        [Key]
        public int AccountNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal? Amount { get; set; }
        public TransactionOption TransactionType { get; set; }

    }

    public enum TransactionOption
    {
        Debit = 0,
        Credit = 1
    }

}
