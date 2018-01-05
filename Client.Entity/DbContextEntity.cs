using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Client.Entity
{
    public class DbContextEntity : DbContext
    {
        public DbContextEntity() : base("name=SeguroConnection")
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
    }
}
