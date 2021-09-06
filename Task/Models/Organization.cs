using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task.Models
{
    public class Organization
    {
        [Key] public int OrganizationId { get; set; }
        [MaxLength(500)] [Required] public string NameOrganization { get; set; }
        [MaxLength(30)] [Required] public string ContractNumber { get; set; }
        [Required] public DateTime ContractDate { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

        public Organization()
        {
            Cars = new List<Car>();
        }
    }
}
