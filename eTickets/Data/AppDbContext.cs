using UniversalSolutionApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalSolutionApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DimensionCombination>().HasKey(dc => dc.Id);
            modelBuilder.Entity<DimensionCombination>().HasOne(dc => dc.Item).WithMany(it => it.DimCombs).HasForeignKey(dc => dc.ItemId);
            modelBuilder.Entity<DimensionCombination>().HasOne(dc => dc.DimHeader).WithMany(it => it.DimCombs).HasForeignKey(dc => dc.DimHeaderId);


            modelBuilder.Entity<DimensionLine>().HasKey(ll => new
            {
                ll.DimensionHeaderId,
                ll.LineNum
            });
            modelBuilder.Entity<DimensionLine>().HasAlternateKey(ll => ll.LotId);

            modelBuilder.Entity<DimensionLine>().HasOne(ll => ll.DimensionHeader).WithMany(lh => lh.Lines).HasForeignKey(ll => ll.DimensionHeaderId);

            modelBuilder.Entity<ListLine>().HasKey(ll => new
            {
                ll.ListHeaderId,
                ll.LineNum
            });
            modelBuilder.Entity<ListLine>().HasAlternateKey(ll => ll.LotId);

            modelBuilder.Entity<ListLine>().HasOne(ll => ll.ListHeader).WithMany(lh => lh.Lines).HasForeignKey(ll => ll.ListHeaderId);

            // delete actions

            modelBuilder.Entity<DimensionCombination>()
                .HasOne(dc => dc.DimHeader)
                .WithMany(dh => dh.DimCombs)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<DimensionCombination>()
                .HasOne(dc => dc.Item)
                .WithMany(dh => dh.DimCombs)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<DimensionHeader>()
                .HasMany(dc => dc.Lines)
                .WithOne(dh => dh.DimensionHeader)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ListHeader>()
                .HasMany(dc => dc.Lines)
                .WithOne(dh => dh.ListHeader)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Item>().HasOne(m => m.Module).WithMany(i => i.Items).HasForeignKey(i => i.ModuleId);

            modelBuilder.Entity<Module>()
                .HasMany(dc => dc.Items)
                .WithOne(dh => dh.Module)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Item>().HasOne(m => m.ItemGroup).WithMany(i => i.Items).HasForeignKey(i => i.ItemGroupId);

            modelBuilder.Entity<ItemGroup>()
                .HasMany(dc => dc.Items)
                .WithOne(dh => dh.ItemGroup)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Module>().HasOne(m => m.ItemGroup).WithMany(i => i.Modules).HasForeignKey(i => i.ItemGroupId);

            modelBuilder.Entity<ItemGroup>()
                .HasMany(dc => dc.Modules)
                .WithOne(dh => dh.ItemGroup)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Item>().HasMany(m => m.DimLines).WithOne(i => i.Item).HasForeignKey(i => i.ItemId);
            modelBuilder.Entity<Item>().HasMany(m => m.ListLines).WithOne(i => i.Item).HasForeignKey(i => i.ItemId);

            modelBuilder.Entity<DimensionLine>()
                .HasOne(dc => dc.Item)
                .WithMany(dh => dh.DimLines)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ListLine>()
                .HasOne(dc => dc.Item)
                .WithMany(dh => dh.ListLines)
                .OnDelete(DeleteBehavior.Restrict);

            // user
            modelBuilder.Entity<User>().HasMany(m => m.ItemGroups).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.Items).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.DimensionHeaders).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.ListHeaders).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.Modules).WithOne(i => i.User).HasForeignKey(i => i.UserId);

            modelBuilder.Entity<User>()
                .HasMany(dc => dc.Modules)
                .WithOne(dh => dh.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(dc => dc.ItemGroups)
                .WithOne(dh => dh.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(dc => dc.ListHeaders)
                .WithOne(dh => dh.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(dc => dc.DimensionHeaders)
                .WithOne(dh => dh.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(dc => dc.Items)
                .WithOne(dh => dh.User)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);

            //Precision

            modelBuilder.Entity<ListLine>()
                .Property(b => b.LineNum)
                .HasPrecision(20, 2);

            modelBuilder.Entity<DimensionLine>()
                .Property(b => b.LineNum)
                .HasPrecision(20, 2);

            modelBuilder.Entity<DimensionLine>()
                .Property(b => b.Double)
                .HasPrecision(15, 2);
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
