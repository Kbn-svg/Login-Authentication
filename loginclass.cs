using System.ComponentModel.DataAnnotations;

namespace webapi
{
    public interface loginclass
    {

        [Key]
        public int ID { get; set; }
        public string Otp { get; set; }
        public string PhoneNo { get; set; }
    }
}
