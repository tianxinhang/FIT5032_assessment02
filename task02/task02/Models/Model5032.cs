namespace task02.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model5032 : DbContext
    {
        public Model5032()
            : base("name=Model5032")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(e => e.Units)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }
    }
}
