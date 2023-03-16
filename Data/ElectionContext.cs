using Data.Model;
using System.Data.Entity;

namespace Data
{
    public class ElectionContext : DbContext
    {
        public ElectionContext() : base("name=ElectionContext") { }

        public DbSet<Party> Parties { get; set; }
    }
}