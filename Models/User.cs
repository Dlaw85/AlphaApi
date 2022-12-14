using System.ComponentModel.DataAnnotations;

namespace UserTemplateApi.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]

        public string? FirstName { get; set; }
        [Required]

        public string? LastName { get; set;  }
        [Required]

        public string? Location { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
    }
}
