using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using ContactManagerApp.Attributes;

namespace ContactManagerApp.Models
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; } = null!;

        [E164Phone]
        public string Phone { get; set; } = null!;

        [EmailAddress]
        [StringLength(30)]
        public string? Email { get; set; } = null;

        public string? Address
        {
            get
            {
                if (string.IsNullOrWhiteSpace(StreetAddress))
                {
                    return null;
                }
                else
                {
                    return $"{StreetAddress}, {City}, {Region}, {Country}";
                }
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var adressParts = value.Split(", ");

                    StreetAddress = adressParts[0];
                    City = adressParts[1];
                    Region = adressParts[2];
                    Country = adressParts[3];
                }
            }
        }

        [NotMapped]
        public string? StreetAddress { get; set; } = null;

        [NotMapped]
        public string? City { get; set; } = null;

        [NotMapped]
        public string? Region { get; set; } = null;


        [NotMapped]
        public string? Country { get; set; } = null;
    }
}
