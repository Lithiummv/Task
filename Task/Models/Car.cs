using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.Models
{
    public class Car
    {
        [Key] public int CarId { get; set; }
        public int? OrganizationId { get; set; }
        [ForeignKey("OrganizationId")] public virtual Organization Organization { get; set; }
        [MaxLength(30)] [Required] public string CarBrand { get; set; }
        [MaxLength(30)] [Required] public string CarModel { get; set; }
        [MaxLength(15)] [Required] public string StateRegistrationNumber { get; set; }
        [Required] public double BodyCapacity { get; set; }
        public virtual ICollection<Request> Requests { get; set; }

        public Car()
        {
            Requests = new List<Request>();
        }
    }
}