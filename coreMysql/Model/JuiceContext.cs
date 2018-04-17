using System;
using Microsoft.EntityFrameworkCore;

namespace coreMysql.Model
{
    public class JuiceContext : DbContext
    {
        public DbSet<Bug> Bug { get; set; }
        public JuiceContext(DbContextOptions<JuiceContext> options)
    : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"server=ec2-54-213-118-72.us-west-2.compute.amazonaws.com;database=juiceittest;user=root;password=moksha;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var e = modelBuilder.Entity<Bug>();

            e.HasKey(x => x.Id);
            e.Property(x => x.Name);
            e.Property(x => x.Description);

           
        }
    }
}
