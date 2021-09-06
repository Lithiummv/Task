using System.Data.Entity;
using Task.Models;

namespace Task
{
    class TaskContext : DbContext
    {
        public TaskContext()
            : base("DbConnection")
        {
        }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
    }
}
