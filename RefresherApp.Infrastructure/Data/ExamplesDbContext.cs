using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefresherApp.Domain.Entities.ExamplesEntities;

namespace RefresherApp.Infrastructure.Data
{
    public class ExamplesDbContext : DbContext
    {
        public ExamplesDbContext(DbContextOptions<ExamplesDbContext> options)
        : base(options)
        { }

        public DbSet<Examples> Examples { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Examples>()
                .Property(e => e.Name)
                .HasColumnType("varchar(512)");
            builder.Entity<Examples>().Property(e => e.Id.).HasColumnType("");
        }
    }
}
