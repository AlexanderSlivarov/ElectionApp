using Data.Model;
using System.Data.Entity;

namespace Data
{
    // <summary>
    /// Context class with DbSet which stores a list of Parties.
    /// </summary>
    public class ElectionContext : DbContext
    {
        public ElectionContext() : base("name=ElectionContext") { }

        public DbSet<Party> Parties { get; set; }
    }
}