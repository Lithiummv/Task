using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.Models
{
    public class Request
    {
        [Key] public int RequestId { get; set; }
        [Required] public DateTime DateRequest { get; set; }
        [Required] public DateTime TimeRequest { get; set; }
        [MaxLength(15)] [Required] public string WaybillNumber { get; set; }
        public int? CarId { get; set; }
        [ForeignKey("CarId")] public virtual Car Car { get; set; }
    }
}
