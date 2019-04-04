using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KaiCoinMVC.Models
{
    public class Account
    {
        //Designating all the properties for a new account whence created.
        [Key]
        [Display(Name = "Account Number")]
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        public string State { get; set; }
        [Display(Name = "Open Date")]
        public DateTime OpeningDate { get; set; }
        public decimal? Balance { get; set; }

      
    }
}
