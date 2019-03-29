using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KaiCoinMVC.Views.Account
{
    public class AddAccountViewModel
    {
        public decimal AccountNumber { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public decimal? ZipCode { get; set; }
        public string State { get; set; }
        public string OpeningDate { get; set; }
        public decimal? Balance { get; set; }
    }
}
