using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KaiCoinMVC.Models
{
    public class InterestRate
    {
        public decimal AccountNumber { get; set; }
        public string Name { get; set; }
        public decimal? AnnualInterestRate { get; set; }
        [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy}")]
        public DateTime? StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy}")]
        public DateTime? MaturationDate { get; set; }
    }
}
