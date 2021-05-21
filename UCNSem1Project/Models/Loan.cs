using System;

namespace UCNSem1Project.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public int Volume_Id { get; set; }
        public string Member_SSN { get; set; }
        public DateTime Checkout_Date { get; set; }
        public DateTime Expiry_Date { get; set; }
        public bool Is_Returned { get; set; }

    }
}