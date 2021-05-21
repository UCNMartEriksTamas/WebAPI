using System.ComponentModel.DataAnnotations.Schema;

namespace UCNSem1Project.Models
{
    [Table(name:"Member")]
    public class Member
    {
        public int SSN { get; set; }
        public string Fname { get; set; }
        public string Minit { get; set; }
        public string Lname { get; set; }
        public bool Is_Professor { get; set; }
        public string Addr_State { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Street { get; set; }
        public int House_No { get; set; }
        public int Apt_No { get; set; }
        public string Campus { get; set; }
        public int Phone { get; set; }
    }
}