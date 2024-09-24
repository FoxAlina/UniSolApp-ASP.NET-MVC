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
            modelBuilder = this.setPrivateKeys(modelBuilder);

            modelBuilder.Entity<DimensionLine>().HasAlternateKey(ll => ll.LotId);
            modelBuilder.Entity<ListLine>().HasAlternateKey(ll => ll.LotId);

            modelBuilder = this.setForeignKeys(modelBuilder);
            //modelBuilder = this.setConstraints(modelBuilder);
            modelBuilder = this.setDeleteActions(modelBuilder);
            modelBuilder = this.setIndeces(modelBuilder);

            //Precision
            modelBuilder.Entity<ListLine>().Property(b => b.LineNum).HasPrecision(20, 2);
            modelBuilder.Entity<DimensionLine>().Property(b => b.LineNum).HasPrecision(20, 2);
            modelBuilder.Entity<DimensionLine>().Property(b => b.Double).HasPrecision(15, 2);

            base.OnModelCreating(modelBuilder);
        }

        private ModelBuilder setPrivateKeys(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasKey(t => new { t.Id, t.UserId });
            modelBuilder.Entity<ItemGroup>().HasKey(t => new { t.Id, t.UserId });
            modelBuilder.Entity<Module>().HasKey(t => new { t.Id, t.UserId });
            modelBuilder.Entity<DimensionHeader>().HasKey(t => new { t.Id, t.UserId });
            modelBuilder.Entity<ListHeader>().HasKey(t => new { t.Id, t.UserId });
            modelBuilder.Entity<Network>().HasKey(f => f.Id);
            modelBuilder.Entity<DimensionCombination>().HasKey(dc => new { dc.Id, dc.UserId });
            modelBuilder.Entity<DimensionGroup>().HasKey(dc => new { dc.Id, dc.UserId });
            modelBuilder.Entity<LinkedFormattingEntity>().HasKey(lf => new { lf.Id, lf.UserId });
            modelBuilder.Entity<ListFormattingEntity>().HasKey(lf => new { lf.Id, lf.UserId });
            modelBuilder.Entity<TextFormattingEntity>().HasKey(tf => new { tf.Id, tf.UserId });

            modelBuilder.Entity<DimensionLine>().HasKey(ll => new
            {
                ll.DimensionCombinationId,
                ll.LineNum,
                ll.DimCombinationUserId
            });

            modelBuilder.Entity<ListLine>().HasKey(ll => new
            {
                ll.ListHeaderId,
                ll.LineNum,
                ll.ListHeaderUserId
            });

            return modelBuilder;
        }

        private ModelBuilder setConstraints(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTransaction>().HasCheckConstraint("ModuleToUserTransaction", "TransLinkName = \"Module\"");
            modelBuilder.Entity<UserTransaction>().HasCheckConstraint("ListToUserTransaction", "TransLinkName = \"ListHeader\"");
            modelBuilder.Entity<UserTransaction>().HasCheckConstraint("ItemToUserTransaction", "TransLinkName = \"Item\"");

            modelBuilder.Entity<ListHeader>().HasCheckConstraint("ModuleToListHeader", "FilterRefName = \"Module\"");
            modelBuilder.Entity<ListHeader>().HasCheckConstraint("ItemGroupToListHeader", "FilterRefName = \"ItemGroup\"");
            modelBuilder.Entity<ListHeader>().HasCheckConstraint("DimensionHeaderToListHeader", "FilterRefName = \"DimensionHeader\"");

            modelBuilder.Entity<Module>().HasCheckConstraint("ItemGroupToModule", "FilterLinkName = \"ItemGroup\"");
            modelBuilder.Entity<Module>().HasCheckConstraint("DimensionHeaderToModule", "FilterLinkName = \"DimensionHeader\"");

            modelBuilder.Entity<LinkedFormattingEntity>().HasCheckConstraint("ListFormatting", "FormattingType = \"List\"");
            modelBuilder.Entity<LinkedFormattingEntity>().HasCheckConstraint("TextFormatting", "FormattingType = \"Text\"");

            modelBuilder.Entity<LinkedFormattingEntity>().HasCheckConstraint("FormattingModule", "FilterLinkName = \"Module\"");
            modelBuilder.Entity<LinkedFormattingEntity>().HasCheckConstraint("FormattingListHeader", "FilterLinkName = \"ListHeader\"");
            modelBuilder.Entity<LinkedFormattingEntity>().HasCheckConstraint("FormattingDimensionHeader", "FilterLinkName = \"DimensionHeader\"");
            modelBuilder.Entity<LinkedFormattingEntity>().HasCheckConstraint("FormattingDimensionLine", "FilterLinkName = \"DimensionLine\"");
            modelBuilder.Entity<LinkedFormattingEntity>().HasCheckConstraint("FormattingItem", "FilterLinkName = \"Item\"");
            modelBuilder.Entity<LinkedFormattingEntity>().HasCheckConstraint("FormattingItemGroup", "FilterLinkName = \"ItemGroup\"");
            modelBuilder.Entity<LinkedFormattingEntity>().HasCheckConstraint("FormattingDimensionGroup", "FilterLinkName = \"DimensionGroup\"");

            modelBuilder.Entity<UserTransaction>().HasOne(m => m.Module).WithMany(i => i.Trans)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId })
                .HasConstraintName("ModuleToUserTransaction");
            modelBuilder.Entity<UserTransaction>().HasOne(m => m.Item).WithMany(i => i.Trans)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId })
                .HasConstraintName("ItemToUserTransaction");
            modelBuilder.Entity<UserTransaction>().HasOne(m => m.ListHeader).WithMany(i => i.Trans)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId })
                .HasConstraintName("ListToUserTransaction");

            modelBuilder.Entity<ListHeader>().HasOne(i => i.ModuleRef).WithMany(dh => dh.ListHeaderRefs)
                .HasForeignKey(i => new { i.FilterRefId, i.FilterRefUserId })
                .HasConstraintName("ModuleToListHeader");
            modelBuilder.Entity<ListHeader>().HasOne(i => i.ItemGroupRef).WithMany(dh => dh.ListHeaderRefs)
                .HasForeignKey(i => new { i.FilterRefId, i.FilterRefUserId })
                .HasConstraintName("ItemGroupToListHeader");
            modelBuilder.Entity<ListHeader>().HasOne(i => i.DimHeaderRef).WithMany(dh => dh.ListHeaderRefs)
                .HasForeignKey(i => new { i.FilterRefId, i.FilterRefUserId })
                .HasConstraintName("DimensionHeaderToListHeader");

            modelBuilder.Entity<Module>().HasOne(i => i.ItemGroup).WithMany(ig => ig.Modules)
                .HasForeignKey(i => new { i.FilterLinkId, i.FilterLinkUserId })
                .HasConstraintName("ItemGroupToModule");
            modelBuilder.Entity<Module>().HasOne(i => i.DimHeader).WithMany(dh => dh.Modules)
                .HasForeignKey(i => new { i.FilterLinkId, i.FilterLinkUserId })
                .HasConstraintName("DimensionHeaderToModule");

            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.Module).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId })
                .HasConstraintName("FormattingModule");
            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.ListHeader).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId })
                .HasConstraintName("FormattingListHeader");
            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.DimensionHeader).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId })
                .HasConstraintName("FormattingDimensionHeader");
            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.DimensionLine).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId })
                .HasConstraintName("FormattingDimensionLine");
            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.Item).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId })
                .HasConstraintName("FormattingItem");
            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.ItemGroup).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId })
                .HasConstraintName("FormattingItemGroup");
            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.DimensionGroup).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId })
                .HasConstraintName("FormattingDimensionGroup");

            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.TextFormattingEntity).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId })
                .HasConstraintName("TextFormatting");
            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.ListFormattingEntity).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId })
                .HasConstraintName("ListFormatting");

            return modelBuilder;
        }

        private ModelBuilder setForeignKeys(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Network>().HasOne(f => f.UserRef).WithMany(u => u.UserRefs).HasForeignKey(f => f.UserRefId);
            modelBuilder.Entity<Network>().HasOne(f => f.FollowerRef).WithMany(u => u.Followers).HasForeignKey(f => f.FollowerRefId);

            modelBuilder.Entity<DimensionCombination>().HasOne(i => i.Item).WithMany(dh => dh.DimCombs).HasForeignKey(i => new { i.ItemId, i.ItemUserId });
            modelBuilder.Entity<DimensionCombination>().HasOne(i => i.DimHeader).WithMany(dh => dh.DimCombs).HasForeignKey(i => new { i.DimHeaderId, i.DimHeaderUserId });

            modelBuilder.Entity<User>().HasMany(m => m.ItemGroups).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.Items).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.DimensionHeaders).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.ListHeaders).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.Modules).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.DimensionGroups).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.LinkedFormattingEntity).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.ListFormattingEntity).WithOne(i => i.User).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<User>().HasMany(m => m.TextFormattingEntity).WithOne(i => i.User).HasForeignKey(i => i.UserId);

            modelBuilder.Entity<Item>().HasOne(i => i.ItemGroup).WithMany(ig => ig.Items).HasForeignKey(i => new { i.ItemGroupId, i.ItemGroupUserId });
            modelBuilder.Entity<Item>().HasOne(m => m.Module).WithMany(i => i.Items).HasForeignKey(i => new { i.ModuleId, i.ModuleUserId });

            modelBuilder.Entity<Module>().HasOne(i => i.ItemGroup).WithMany(ig => ig.Modules).HasForeignKey(i => new { i.FilterLinkId, i.FilterLinkUserId });
            modelBuilder.Entity<Module>().HasOne(i => i.DimHeader).WithMany(dh => dh.Modules).HasForeignKey(i => new { i.FilterLinkId, i.FilterLinkUserId });
            modelBuilder.Entity<Module>().HasOne(i => i.ModuleRef).WithMany(dh => dh.ModuleRefs).HasForeignKey(i => new { i.ModuleRefId, i.ModuleRefUserId });

            modelBuilder.Entity<DimensionHeader>().HasOne(i => i.DimensionGroup).WithMany(dh => dh.DimHeaders).HasForeignKey(i => new { i.DimGroupId, i.DimGroupUserId});
            modelBuilder.Entity<DimensionHeader>().HasOne(i => i.ListHeader).WithMany(dh => dh.DimHeaders).HasForeignKey(i => new { i.ListHeaderId, i.ListHeaderUserId });

            modelBuilder.Entity<DimensionLine>().HasOne(i => i.DimensionCombination).WithMany(dh => dh.Lines).HasForeignKey(i => new { i.DimensionCombinationId, i.DimCombinationUserId });
            modelBuilder.Entity<DimensionLine>().HasOne(i => i.Item).WithMany(dh => dh.DimLines).HasForeignKey(i => new { i.ItemId, i.ItemUserId });
            
            modelBuilder.Entity<ListHeader>().HasOne(i => i.Module).WithMany(dh => dh.ListHeaders).HasForeignKey(i => new { i.ModuleId, i.ModuleUserId });
            modelBuilder.Entity<ListLine>().HasOne(i => i.ListHeader).WithMany(dh => dh.Lines).HasForeignKey(i => new { i.ListHeaderId, i.ListHeaderUserId });
            modelBuilder.Entity<ListLine>().HasOne(m => m.Item).WithMany(i => i.ListLines).HasForeignKey(i => new { i.ItemId, i.ItemUserId });

            modelBuilder.Entity<ListHeader>().HasOne(i => i.ModuleRef).WithMany(dh => dh.ListHeaderRefs).HasForeignKey(i => new { i.FilterRefId, i.FilterRefUserId });
            modelBuilder.Entity<ListHeader>().HasOne(i => i.ItemGroupRef).WithMany(dh => dh.ListHeaderRefs).HasForeignKey(i => new { i.FilterRefId, i.FilterRefUserId });
            modelBuilder.Entity<ListHeader>().HasOne(i => i.DimHeaderRef).WithMany(dh => dh.ListHeaderRefs).HasForeignKey(i => new { i.FilterRefId, i.FilterRefUserId });

            modelBuilder.Entity<UserTransaction>().HasOne(m => m.User).WithMany(i => i.Trans).HasForeignKey(i => i.UserId);
            modelBuilder.Entity<UserTransaction>().HasOne(m => m.Module).WithMany(i => i.Trans).HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId });
            modelBuilder.Entity<UserTransaction>().HasOne(m => m.Item).WithMany(i => i.Trans).HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId });
            modelBuilder.Entity<UserTransaction>().HasOne(m => m.ListHeader).WithMany(i => i.Trans).HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId });

            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.Module).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId });
            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.ListHeader).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId });
            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.DimensionHeader).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId });
            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.DimensionLine).WithMany(dh => dh.LinkedFormattingEntities)
                .HasPrincipalKey(i => new { i.LotId, i.DimCombinationUserId});
            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.Item).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId });
            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.ItemGroup).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId });
            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.DimensionGroup).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId });

            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.TextFormattingEntity).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId });
            modelBuilder.Entity<LinkedFormattingEntity>().HasOne(i => i.ListFormattingEntity).WithMany(dh => dh.LinkedFormattingEntities)
                .HasForeignKey(i => new { i.TransLinkId, i.TransLinkUserId });

            return modelBuilder;
        }

        private ModelBuilder setDeleteActions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DimensionCombination>().HasOne(dc => dc.DimHeader).WithMany(dh => dh.DimCombs).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<DimensionCombination>().HasOne(dc => dc.Item).WithMany(dh => dh.DimCombs).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<DimensionCombination>().HasMany(dc => dc.Lines).WithOne(dh => dh.DimensionCombination).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DimensionHeader>().HasOne(dh => dh.ListHeader).WithMany(l => l.DimHeaders).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<DimensionHeader>().HasMany(dh => dh.Modules).WithOne(l => l.DimHeader).OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<DimensionGroup>().HasMany(dh => dh.DimHeaders).WithOne(l => l.DimensionGroup).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ListHeader>().HasMany(dc => dc.Lines).WithOne(dh => dh.ListHeader).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ListHeader>().HasOne(dc => dc.DimHeaderRef).WithMany(dh => dh.ListHeaderRefs).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ListHeader>().HasOne(dc => dc.Module).WithMany(dh => dh.ListHeaders).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Module>().HasMany(dc => dc.Items).WithOne(dh => dh.Module).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Module>().HasMany(dc => dc.ListHeaderRefs).WithOne(dh => dh.ModuleRef).OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<ItemGroup>().HasMany(dc => dc.Items).WithOne(dh => dh.ItemGroup).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ItemGroup>().HasMany(dc => dc.Modules).WithOne(dh => dh.ItemGroup).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ItemGroup>().HasMany(dc => dc.ListHeaderRefs).WithOne(dh => dh.ItemGroupRef).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DimensionLine>().HasOne(dc => dc.Item).WithMany(dh => dh.DimLines).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ListLine>().HasOne(dc => dc.Item).WithMany(dh => dh.ListLines).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>().HasMany(dc => dc.Modules).WithOne(dh => dh.User).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasMany(dc => dc.ItemGroups).WithOne(dh => dh.User).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasMany(dc => dc.ListHeaders).WithOne(dh => dh.User).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasMany(dc => dc.DimensionHeaders).WithOne(dh => dh.User).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasMany(dc => dc.Items).WithOne(dh => dh.User).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasMany(dc => dc.Followers).WithOne(dh => dh.FollowerRef).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<User>().HasMany(dc => dc.UserRefs).WithOne(dh => dh.UserRef).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasMany(m => m.DimensionGroups).WithOne(i => i.User).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserTransaction>().HasOne(m => m.Item).WithMany(i => i.Trans).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<UserTransaction>().HasOne(m => m.Module).WithMany(i => i.Trans).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<UserTransaction>().HasOne(m => m.ListHeader).WithMany(i => i.Trans).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<UserTransaction>().HasOne(m => m.Item).WithMany(i => i.Trans).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<UserTransaction>().HasOne(m => m.Item).WithMany(i => i.Trans).OnDelete(DeleteBehavior.NoAction);

            return modelBuilder;
        }

        private ModelBuilder setIndeces(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(i => i.Id, "UserIdx").IsUnique().IncludeProperties(p => new { p.NickName, p.Name, p.Surname, p.Email });
            modelBuilder.Entity<User>().HasIndex(i => i.NickName, "NickNameIdx").IsUnique();

            modelBuilder.Entity<Module>().HasIndex(i => new { i.Id, i.UserId }, "ModuleIdx").IsUnique().IncludeProperties(p => new { p.Name });
            modelBuilder.Entity<Module>().HasIndex(i => new { i.UserId }, "UserIdx").IncludeProperties(p => new { p.Id, p.Name });
            modelBuilder.Entity<Module>().HasIndex(i => new { i.FilterLinkId, i.FilterLinkUserId, i.FilterLinkName }, "FilterLinkIdx").IncludeProperties(p => new { p.Id, p.UserId });
            modelBuilder.Entity<Module>().HasIndex(i => new { i.ModuleRefId, i.ModuleRefUserId }, "ModuleRefIdx").IncludeProperties(p => new { p.Id, p.UserId });

            modelBuilder.Entity<Item>().HasIndex(i => new { i.Id, i.UserId }, "ItemIdx").IsUnique().IncludeProperties(p => new { p.ItemGroupId, p.ModuleId, p.Name });
            modelBuilder.Entity<Item>().HasIndex(i => new { i.UserId }, "UserIdx").IncludeProperties(p => new { p.Id, p.ItemGroupId, p.ModuleId, p.Name });
            modelBuilder.Entity<Item>().HasIndex(i => new { i.ItemGroupId }, "ItemGroupIdx").IncludeProperties(p => new { p.Id, p.UserId, p.ModuleId, p.Name });
            modelBuilder.Entity<Item>().HasIndex(i => new { i.ModuleId }, "ModuleIdx").IncludeProperties(p => new { p.Id, p.UserId, p.ItemGroupId, p.Name });

            modelBuilder.Entity<UserTransaction>().HasIndex(i => new { i.Id, i.UserId }, "TransIdx").IsUnique().IncludeProperties(p => new { p.TransType });
            modelBuilder.Entity<UserTransaction>().HasIndex(i => new { i.UserId }, "UserIdx").IncludeProperties(p => new { p.Id });
            modelBuilder.Entity<UserTransaction>().HasIndex(i => new { i.TransLinkId, i.TransLinkUserId, i.TransLinkName }, "TransLinkIdx").IncludeProperties(p => new { p.Id });

            modelBuilder.Entity<ItemGroup>().HasIndex(i => new { i.Id, i.UserId }, "ItemGroupIdx").IsUnique();
            modelBuilder.Entity<ItemGroup>().HasIndex(i => new { i.UserId }, "UserIdx").IncludeProperties(i => new { i.Id });

            modelBuilder.Entity<DimensionHeader>().HasIndex(i => new { i.Id, i.UserId }, "DimHeaderIdx").IsUnique();
            modelBuilder.Entity<DimensionHeader>().HasIndex(i => new { i.ListHeaderId }, "ListIdx").IncludeProperties(p => new { p.Id, p.UserId });
            modelBuilder.Entity<DimensionHeader>().HasIndex(i => new { i.UserId }, "UserIdx").IncludeProperties(p => new { p.Id });

            modelBuilder.Entity<DimensionCombination>().HasIndex(i => new { i.Id }, "DimCombIdx").IsUnique();
            modelBuilder.Entity<DimensionCombination>().HasIndex(i => new { i.ItemId, i.ItemUserId }, "ItemIdx").IncludeProperties(i => i.Id);
            modelBuilder.Entity<DimensionCombination>().HasIndex(i => new { i.DimHeaderId, i.DimHeaderUserId }, "DimHeaderIdx").IncludeProperties(i => i.Id);

            modelBuilder.Entity<DimensionLine>().HasIndex(i => new { i.DimensionCombinationId, i.LineNum, i.DimCombinationUserId }, "LineNumIdx").IsUnique().IncludeProperties(p => new { p.LotId });
            modelBuilder.Entity<DimensionLine>().HasIndex(i => new { i.DimensionCombinationId, i.DimCombinationUserId }, "DimHeaderIdx").IncludeProperties(p => new { p.LotId });
            modelBuilder.Entity<DimensionLine>().HasIndex(i => new { i.ItemId, i.ItemUserId }, "ItemIdx").IncludeProperties(p => new { p.LotId, p.LineNum, p.DimensionCombinationId });

            modelBuilder.Entity<ListHeader>().HasIndex(i => new { i.Id, i.UserId }, "ListHeaderIdx").IsUnique();
            modelBuilder.Entity<ListHeader>().HasIndex(i => new { i.UserId }, "UserIdx").IncludeProperties(p => new { p.Id, p.ModuleId });
            modelBuilder.Entity<ListHeader>().HasIndex(i => new { i.ModuleId, i.ModuleUserId }, "ModuleIdx").IncludeProperties(p => new { p.Id, p.UserId });
            modelBuilder.Entity<ListHeader>().HasIndex(i => new { i.FilterRefId, i.FilterRefUserId }, "ModuleRefIdx").IncludeProperties(p => new { p.Id, p.UserId, p.ModuleId });
            modelBuilder.Entity<ListHeader>().HasIndex(i => new { i.FilterRefId, i.FilterRefUserId }, "ItemGroupRefIdx").IncludeProperties(p => new { p.Id, p.UserId, p.ModuleId });
            modelBuilder.Entity<ListHeader>().HasIndex(i => new { i.FilterRefId, i.FilterRefUserId }, "DimHeaderRefIdx").IncludeProperties(p => new { p.Id, p.UserId, p.ModuleId });

            modelBuilder.Entity<ListLine>().HasIndex(i => new { i.ListHeaderId, i.LineNum, i.ListHeaderUserId }, "LineNumIdx").IsUnique().IncludeProperties(p => new { p.LotId });
            modelBuilder.Entity<ListLine>().HasIndex(i => new { i.ListHeaderId, i.ListHeaderUserId }, "ListHeaderIdx").IncludeProperties(p => new { p.LotId });
            modelBuilder.Entity<ListLine>().HasIndex(i => new { i.ItemId, i.ItemUserId }, "ItemIdx").IncludeProperties(p => new { p.LotId, p.LineNum, p.ListHeaderId });

            modelBuilder.Entity<Network>().HasIndex(i => new { i.Id }, "FollowerIdx").IsUnique();
            modelBuilder.Entity<Network>().HasIndex(i => new { i.FollowerRefId }, "FollowerRefIdx").IncludeProperties(p => p.Id);
            modelBuilder.Entity<Network>().HasIndex(i => new { i.UserRefId }, "UserRefIdx").IncludeProperties(p => p.Id);

            return modelBuilder;
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemGroup> ItemGroups { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<DimensionCombination> DimensionCombinations { get; set; }
        public DbSet<DimensionGroup> DimensionGroups { get; set; }
        public DbSet<DimensionHeader> DimensionHeaders { get; set; }
        public DbSet<DimensionLine> DimensionLines { get; set; }
        public DbSet<ListHeader> ListHeaders { get; set; }
        public DbSet<ListLine> ListLines { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Network> Followers { get; set; }
        public DbSet<LinkedFormattingEntity> LinkedFormattingEntities { get; set; }
        public DbSet<ListFormattingEntity> ListFormattingEntities { get; set; }
        public DbSet<TextFormattingEntity> TextFormattingEntities { get; set; }
        public DbSet<UserTransaction> UserTransactions { get; set; }
    }
}
