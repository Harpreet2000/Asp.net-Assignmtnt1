using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GetThatLook.Models
{
    //MODIFY the DbContext to handle the User Identities and the Roles
    //Last parameter indicated the PK of Userid value as a string
    public partial class GetThatLookContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public GetThatLookContext()
        {
        }

        public GetThatLookContext(DbContextOptions<GetThatLookContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
  //              optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=GetThatLook;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Add to get Identity to work! This is a Bug Fix!
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryName).IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.PhoneNumber).ValueGeneratedNever();

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
