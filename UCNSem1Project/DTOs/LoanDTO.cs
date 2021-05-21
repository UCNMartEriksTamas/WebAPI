using System;

namespace UCNSem1Project.DTOs
{
    public class LoanDTO
    {
        public int Id { get; set; }
        public int VolumeId { get; set; }
        public string MemberSsn { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsReturned { get; set; }
    }
}