using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KaiCoinMVC.Models
{
    public class Account
    {
        [Key]
        [Display(Name = "Account Number")]
        public decimal AccountNumber { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [Display(Name = "Zip Code")]
        public decimal? ZipCode { get; set; }
        public string State { get; set; }
        [Display(Name = "Open Date")]
        public string OpeningDate { get; set; }
        public decimal? Balance { get; set; }
    }
}
