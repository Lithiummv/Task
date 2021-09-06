using System;

namespace Task.Models
{
    class Heeelp
    {
        public int RequestId { get; set; }
        public DateTime DateRequest { get; set; }
        public DateTime TimeRequest { get; set; }
        public string WaybillNumber { get; set; }
        public int? CarId { get; set; }
        public Car Car { get; set; }
        public string CarBrand { get; set; }
        public string StateRegistrationNumber { get; set; }
        public double BodyCapacity { get; set; }
    }
}
