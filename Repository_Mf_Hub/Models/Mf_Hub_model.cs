namespace Repository_Mf_Hub
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Mf_Hub_model : DbContext
    {
        public Mf_Hub_model()
            : base("name=Mf_Hub_model")
        {
        }

        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
