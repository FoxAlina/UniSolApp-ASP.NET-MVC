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
            modelBuilder.Entity<Item>().HasKey(t => new { t.Id, t.UserId });
            modelBuilder.Entity<ItemGroup>().HasKey(t => new { t.Id, t.UserId });
            modelBuilder.Entity<Module>().HasKey(t => new { t.Id, t.UserId });
            modelBuilder.Entity<DimensionHeader>().HasKey(t => new { t.Id, t.UserId });
            modelBuilder.Entity<ListHeader>().HasKey(t => new { t.Id, t.UserId });

            modelBuilder.Entity<Follower>().HasKey(f => f.Id);
            modelBuilder.Entity<Follower>().HasOne(f => f.UserRef).WithMany(u => u.UserRefs).HasForeignKey(f => f.UserRefId);
            modelBuilder.Entity<Follower>().HasOne(f => f.FollowerRef).WithMany(u => u.Followers).HasForeignKey(f => f.FollowerRefId);

            modelBuilder.Entity<DimensionCombination>().HasKey(dc => new { dc.Id, dc.UserId });
            modelBuilder.Entity<DimensionCombination>().HasOne(i => i.Item).WithMany(dh => dh.DimCombs).HasForeignKey(i => new { i.ItemId, i.ItemUserId });
            modelBuilder.Entity<DimensionCombination>().HasOne(i => i.DimHeader).WithMany(dh => dh.DimCombs).HasForeignKey(i => new { i.DimHeaderId, i.DimHeaderUserId });

            modelBuilder.Entity<DimensionLine>().HasKey(ll => new
            {
                ll.DimensionHeaderId,
                ll.LineNum,
                ll.DimHeaderUserId
            });
            modelBuilder.Entity<DimensionLine>().HasAlternateKey(ll => ll.LotId);

            modelBuilder.Entity<ListLine>().HasKey(ll => new
            {
                ll.ListHeaderId,
                ll.LineNum,
                ll.ListHeaderUserId
            });
            modelBuilder.Entity<ListLine>().HasAlternateKey(ll => ll.LotId);

            // user pk foreign keys

            modelBuilder.Entity<Item>().HasOne(i => i.ItemGroup).WithMany(ig => ig.Items).HasForeignKey(i => new { i.ItemGroupId, i.ItemGroupUserId });
            modelBuilder.Entity<Item>().HasOne(m => m.Module).WithMany(i => i.Items).HasForeignKey(i => new { i.ModuleId, i.ModuleUserId });
            modelBuilder.Entity<Item>().HasOne(m => m.LinkItem).WithMany(i => i.LinkItems).HasForeignKey(i => new { i.LinkItemId, i.LinkItemUserId });
            modelBuilder.Entity<Module>().HasOne(i => i.ItemGroup).WithMany(ig => ig.Modules).HasForeignKey(i => new { i.ItemGroupId, i.ItemGroupUserId });
            modelBuilder.Entity<Module>().HasOne(i => i.DimHeader).WithMany(dh => dh.Modules).HasForeignKey(i => new { i.DimHeaderId, i.DimHeaderUserId });
            modelBuilder.Entity<Module>().HasOne(i => i.LinkModule).WithMany(dh => dh.LinkModules).HasForeignKey(i => new { i.LinkModuleId, i.LinkModuleUserId });
            modelBuilder.Entity<Module>().HasOne(i => i.ModuleRef).WithMany(dh => dh.ModuleRefs).HasForeignKey(i => new { i.ModuleRefId, i.ModuleRefUserId });
            modelBuilder.Entity<ItemGroup>().HasOne(m => m.LinkItemGroup).WithMany(i => i.LinkItemGroups).HasForeignKey(i => new { i.LinkItemGroupId, i.LinkItemGroupUserId });
            modelBuilder.Entity<DimensionHeader>().HasOne(i => i.LinkHeader).WithMany(dh => dh.LinkDimHeaders).HasForeignKey(i => new { i.LinkHeaderId, i.LinkHeaderUserId });
            modelBuilder.Entity<DimensionLine>().HasOne(i => i.DimensionHeader).WithMany(dh => dh.Lines).HasForeignKey(i => new { i.DimensionHeaderId, i.DimHeaderUserId });
            modelBuilder.Entity<DimensionLine>().HasOne(i => i.Item).WithMany(dh => dh.DimLines).HasForeignKey(i => new { i.ItemId, i.ItemUserId });
            modelBuilder.Entity<ListHeader>().HasOne(i => i.LinkListHeader).WithMany(dh => dh.LinkListHeaders).HasForeignKey(i => new { i.LinkListHeaderId, i.LinkListHeaderUserId });
            modelBuilder.Entity<ListHeader>().HasOne(i => i.Module).WithMany(dh => dh.ListHeaders).HasForeignKey(i => new { i.ModuleId, i.ModuleUserId });
            modelBuilder.Entity<ListLine>().HasOne(i => i.ListHeader).WithMany(dh => dh.Lines).HasForeignKey(i => new { i.ListHeaderId, i.ListHeaderUserId });
            modelBuilder.Entity<ListLine>().HasOne(m => m.Item).WithMany(i => i.ListLines).HasForeignKey(i => new { i.ItemId, i.ItemUserId });

            modelBuilder.Entity<ListHeader>().HasOne(i => i.ModuleRef).WithMany(dh => dh.ListHeaderRefs).HasForeignKey(i => new { i.ModuleRefId, i.ModuleRefUserId });
            modelBuilder.Entity<ListHeader>().HasOne(i => i.ItemGroupRef).WithMany(dh => dh.ListHeaderRefs).HasForeignKey(i => new { i.ItemGroupRefId, i.ItemGroupRefUserId });
            modelBuilder.Entity<ListHeader>().HasOne(i => i.DimHeaderRef).WithMany(dh => dh.ListHeaderRefs).HasForeignKey(i => new { i.DimHeaderRefId, i.DimHeaderRefUserId });

            modelBuilder.Entity<DimensionHeader>().HasOne(i => i.ListHeader).WithMany(dh => dh.DimHeaders).HasForeignKey(i => new { i.ListHeaderId, i.ListHeaderUserId });

            modelBuilder.Entity<UserTransaction>().HasOne(m => m.Module).WithMany(i => i.Trans).HasForeignKey(i => new { i.ModuleId, i.TransLinkUserId });
            modelBuilder.Entity<UserTransaction>().HasOne(m => m.Item).WithMany(i => i.Trans).HasForeignKey(i => new { i.ItemId, i.TransLinkUserId });
            modelBuilder.Entity<UserTransaction>().HasOne(m => m.List).WithMany(i => i.Trans).HasForeignKey(i => new { i.ListId, i.TransLinkUserId });
            modelBuilder.Entity<UserTransaction>().HasOne(m => m.User).WithMany(i => i.Trans).HasForeignKey(i => i.UserId);

            // delete actions
            modelBuilder.Entity<DimensionCombination>().HasOne(dc => dc.DimHeader).WithMany(dh => dh.DimCombs).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<DimensionCombination>().HasOne(dc => dc.Item).WithMany(dh => dh.DimCombs).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<DimensionHeader>().HasMany(dc => dc.Lines).WithOne(dh => dh.DimensionHeader).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<DimensionHeader>().HasOne(dh => dh.ListHeader).WithMany(l => l.DimHeaders).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<DimensionHeader>().HasMany(dh => dh.Modules).WithOne(l => l.DimHeader).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ListHeader>().HasMany(dc => dc.Lines).WithOne(dh => dh.ListHeader).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ListHeader>().HasOne(dc => dc.DimHeaderRef).WithMany(dh => dh.ListHeaderRefs).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ListHeader>().HasOne(dc => dc.Module).WithMany(dh => dh.ListHeaders).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Module>().HasMany(dc => dc.Items).WithOne(dh => dh.Module).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Module>().HasMany(dc => dc.ListHeaderRefs).WithOne(dh => dh.ModuleRef).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ItemGroup>().HasMany(dc => dc.Items).WithOne(dh => dh.ItemGroup).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ItemGroup>().HasMany(dc => dc.Modules).WithOne(dh => dh.ItemGroup).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ItemGroup>().HasMany(dc => dc.ListHeaderRefs).WithOne(dh => dh.ItemGroupRef).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DimensionLine>().HasOne(dc => dc.Item).WithMany(dh => dh.DimLines).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ListLine>().HasOne(dc => dc.Item).WithMany(dh => dh.ListLines).OnDelete(DeleteBehavior.Restrict);

            // user delete actions
            modelBuilder.Entity<User>().HasMany(m => m.ItemGroups).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.Items).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.DimensionHeaders).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.ListHeaders).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.Modules).WithOne(i => i.User).HasForeignKey(i => i.UserId);

            modelBuilder.Entity<User>().HasMany(dc => dc.Modules).WithOne(dh => dh.User).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasMany(dc => dc.ItemGroups).WithOne(dh => dh.User).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasMany(dc => dc.ListHeaders).WithOne(dh => dh.User).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasMany(dc => dc.DimensionHeaders).WithOne(dh => dh.User).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasMany(dc => dc.Items).WithOne(dh => dh.User).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasMany(dc => dc.Followers).WithOne(dh => dh.FollowerRef).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasMany(dc => dc.UserRefs).WithOne(dh => dh.UserRef).OnDelete(DeleteBehavior.Cascade);

            //Precision
            modelBuilder.Entity<ListLine>().Property(b => b.LineNum).HasPrecision(20, 2);
            modelBuilder.Entity<DimensionLine>().Property(b => b.LineNum).HasPrecision(20, 2);
            modelBuilder.Entity<DimensionLine>().Property(b => b.Double).HasPrecision(15, 2);

            //Indeces
            modelBuilder.Entity<User>().HasIndex(i => i.Id, "UserIdx").IsUnique().IncludeProperties(p => new { p.NickName, p.Name, p.Surname, p.Email });
            modelBuilder.Entity<User>().HasIndex(i => i.NickName, "NickNameIdx").IsUnique();

            modelBuilder.Entity<Module>().HasIndex(i => new { i.Id, i.UserId }, "ModuleIdx").IsUnique().IncludeProperties(p => new { p.Name });
            modelBuilder.Entity<Module>().HasIndex(i => new { i.UserId }, "UserIdx").IncludeProperties(p => new { p.Id, p.Name });
            modelBuilder.Entity<Module>().HasIndex(i => new { i.ItemGroupId, i.ItemGroupUserId }, "ItemGroupIdx").IncludeProperties(p => new { p.Id, p.UserId });
            modelBuilder.Entity<Module>().HasIndex(i => new { i.DimHeaderId, i.DimHeaderUserId }, "DimHeaderIdx").IncludeProperties(p => new { p.Id, p.UserId });
            modelBuilder.Entity<Module>().HasIndex(i => new { i.LinkModuleId, i.LinkModuleUserId }, "LinkModuleIdx").IncludeProperties(p => new { p.Id, p.UserId });
            modelBuilder.Entity<Module>().HasIndex(i => new { i.ModuleRefId, i.ModuleRefUserId}, "ModuleRefIdx").IncludeProperties(p => new { p.Id, p.UserId });

            modelBuilder.Entity<Item>().HasIndex(i => new { i.Id, i.UserId }, "ItemIdx").IsUnique().IncludeProperties(p => new { p.ItemGroupId, p.ModuleId, p.Name });
            modelBuilder.Entity<Item>().HasIndex(i => new { i.UserId }, "UserIdx").IncludeProperties(p => new { p.Id, p.ItemGroupId, p.ModuleId, p.Name });
            modelBuilder.Entity<Item>().HasIndex(i => new { i.ItemGroupId }, "ItemGroupIdx").IncludeProperties(p => new { p.Id, p.UserId, p.ModuleId, p.Name });
            modelBuilder.Entity<Item>().HasIndex(i => new { i.ModuleId }, "ModuleIdx").IncludeProperties(p => new { p.Id, p.UserId, p.ItemGroupId, p.Name });
            modelBuilder.Entity<Item>().HasIndex(i => new { i.LinkItemId, i.LinkItemUserId }, "LinkItemIdx").IncludeProperties(p => new { p.Id, p.UserId, p.ItemGroupId, p.ModuleId, p.Name });

            modelBuilder.Entity<UserTransaction>().HasIndex(i => new { i.Id, i.UserId }, "TransIdx").IsUnique().IncludeProperties(p => new { p.TransType });
            modelBuilder.Entity<UserTransaction>().HasIndex(i => new { i.UserId }, "UserIdx").IncludeProperties(p => new { p.Id });
            modelBuilder.Entity<UserTransaction>().HasIndex(i => new { i.ItemId, i.TransLinkUserId }, "ItemIdx").IncludeProperties(p => new { p.Id });
            modelBuilder.Entity<UserTransaction>().HasIndex(i => new { i.ListId, i.TransLinkUserId }, "ListIdx").IncludeProperties(p => new { p.Id });
            modelBuilder.Entity<UserTransaction>().HasIndex(i => new { i.ModuleId, i.TransLinkUserId }, "ModuleIdx").IncludeProperties(p => new { p.Id });

            modelBuilder.Entity<ItemGroup>().HasIndex(i => new { i.Id, i.UserId }, "ItemGroupIdx").IsUnique();
            modelBuilder.Entity<ItemGroup>().HasIndex(i => new { i.UserId }, "UserIdx").IncludeProperties(i => new { i.Id });
            modelBuilder.Entity<ItemGroup>().HasIndex(i => new { i.LinkItemGroupId }, "LinkItemGroupIdx").IncludeProperties(i => new { i.Id });

            modelBuilder.Entity<DimensionHeader>().HasIndex(i => new { i.Id, i.UserId }, "DimHeaderIdx").IsUnique();
            modelBuilder.Entity<DimensionHeader>().HasIndex(i => new { i.ListHeaderId }, "ListIdx").IncludeProperties(p => new { p.Id, p.UserId});
            modelBuilder.Entity<DimensionHeader>().HasIndex(i => new { i.UserId }, "UserIdx").IncludeProperties(p => new { p.Id });
            modelBuilder.Entity<DimensionHeader>().HasIndex(i => new { i.LinkHeaderId, i.LinkHeaderUserId }, "LinkDimHeaderIdx").IncludeProperties(p => new { p.Id, p.UserId });

            modelBuilder.Entity<DimensionCombination>().HasIndex(i => new { i.Id }, "DimCombIdx").IsUnique();
            modelBuilder.Entity<DimensionCombination>().HasIndex(i => new { i.ItemId, i.ItemUserId }, "ItemIdx").IncludeProperties(i => i.Id);
            modelBuilder.Entity<DimensionCombination>().HasIndex(i => new { i.DimHeaderId, i.DimHeaderUserId }, "DimHeaderIdx").IncludeProperties(i => i.Id);

            modelBuilder.Entity<DimensionLine>().HasIndex(i => new { i.DimensionHeaderId, i.LineNum, i.DimHeaderUserId }, "LineNumIdx").IsUnique().IncludeProperties(p => new { p.LotId });
            modelBuilder.Entity<DimensionLine>().HasIndex(i => new { i.DimensionHeaderId, i.DimHeaderUserId}, "DimHeaderIdx").IncludeProperties(p => new { p.LotId });
            modelBuilder.Entity<DimensionLine>().HasIndex(i => new { i.ItemId, i.ItemUserId }, "ItemIdx").IncludeProperties(p => new { p.LotId, p.LineNum, p.DimensionHeaderId });

            modelBuilder.Entity<ListHeader>().HasIndex(i => new { i.Id, i.UserId }, "ListHeaderIdx").IsUnique();
            modelBuilder.Entity<ListHeader>().HasIndex(i => new { i.UserId }, "UserIdx").IncludeProperties(p => new { p.Id, p.ModuleId });
            modelBuilder.Entity<ListHeader>().HasIndex(i => new { i.ModuleId, i.ModuleUserId }, "ModuleIdx").IncludeProperties(p => new { p.Id, p.UserId });
            modelBuilder.Entity<ListHeader>().HasIndex(i => new { i.ModuleRefId, i.ModuleRefUserId }, "ModuleRefIdx").IncludeProperties(p => new { p.Id, p.UserId, p.ModuleId });
            modelBuilder.Entity<ListHeader>().HasIndex(i => new { i.ItemGroupRefId, i.ItemGroupRefUserId}, "ItemGroupRefIdx").IncludeProperties(p => new { p.Id, p.UserId, p.ModuleId });
            modelBuilder.Entity<ListHeader>().HasIndex(i => new { i.DimHeaderRefId, i.DimHeaderRefUserId}, "DimHeaderRefIdx").IncludeProperties(p => new { p.Id, p.UserId, p.ModuleId });
            modelBuilder.Entity<ListHeader>().HasIndex(i => new { i.LinkListHeaderId, i.LinkListHeaderUserId}, "LinkListHeaderIdx").IncludeProperties(p => new { p.Id, p.UserId, p.ModuleId });


            modelBuilder.Entity<ListLine>().HasIndex(i => new { i.ListHeaderId, i.LineNum, i.ListHeaderUserId }, "LineNumIdx").IsUnique().IncludeProperties(p => new { p.LotId });
            modelBuilder.Entity<ListLine>().HasIndex(i => new { i.ListHeaderId, i.ListHeaderUserId }, "ListHeaderIdx").IncludeProperties(p => new { p.LotId });
            modelBuilder.Entity<ListLine>().HasIndex(i => new { i.ItemId, i.ItemUserId }, "ItemIdx").IncludeProperties(p => new { p.LotId, p.LineNum, p.ListHeaderId });

            modelBuilder.Entity<Follower>().HasIndex(i => new { i.Id }, "FollowerIdx").IsUnique();
            modelBuilder.Entity<Follower>().HasIndex(i => new { i.FollowerRefId }, "FollowerRefIdx").IncludeProperties(p => p.Id);
            modelBuilder.Entity<Follower>().HasIndex(i => new { i.UserRefId }, "UserRefIdx").IncludeProperties(p => p.Id);

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
