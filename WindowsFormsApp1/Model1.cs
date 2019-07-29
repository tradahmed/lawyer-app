namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<RDV> RDVs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RDV>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<RDV>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<RDV>()
                .Property(e => e.num)
                .IsFixedLength();

            modelBuilder.Entity<RDV>()
                .Property(e => e.mail)
                .IsUnicode(false);
        }
    }
}
