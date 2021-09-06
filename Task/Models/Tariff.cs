using System.ComponentModel.DataAnnotations;

namespace Task.Models
{
    class Tariff
    {
        [Key] public int TariffId { get; set; }
        [Required] public double TariffOrder { get; set; }
        [Required] public double VATOrder { get; set; }
    }
}
