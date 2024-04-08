using UniversalSolutionApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DimensionLine>().HasKey(ll => new
            {
                ll.DimHeaderId,
                ll.LotId,
                ll.LineNum
            });

            modelBuilder.Entity<DimensionLine>().HasOne(ll => ll.DimensionHeader).WithMany(lh => lh.Lines).HasForeignKey(ll => ll.DimHeaderId);

            modelBuilder.Entity<ListLine>().HasKey(ll => new
            {
                ll.ListHeaderId,
                ll.LotId,
                ll.LineNum
            });

            modelBuilder.Entity<ListLine>().HasOne(ll => ll.ListHeader).WithMany(lh => lh.Lines).HasForeignKey(ll => ll.ListHeaderId);
            //modelBuilder.Entity<ListLine>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Item> Item { get; set; }
        public DbSet<ItemGroup> ItemGroup { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<DimensionHeader> DimensionHeader { get; set; }
        public DbSet<DimensionLine> DimensionLine { get; set; }
        public DbSet<ListHeader> ListHeader { get; set; }
        public DbSet<ListLine> ListLine { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserTransaction> UserTransaction { get; set; }
    }
}
