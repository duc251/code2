using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QLHĐSolotion.Data.Entity;
using QLHĐSolotion.Data.Config;
using QLHĐSolotion.Data.Extensions;
using Data.Entity;
using Data.Config;

namespace QLHĐSolotion.Data.EF
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions options): base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API

            modelBuilder.ApplyConfiguration(new CtrKhachHangConfiguration());
            modelBuilder.ApplyConfiguration(new CtrCongNoConfiguration());
            modelBuilder.ApplyConfiguration(new CtrHopDongConfiguration());
            modelBuilder.ApplyConfiguration(new DoiTacConfiguration());
            modelBuilder.ApplyConfiguration(new FileHopDongConfiguration());
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());

            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());

         
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());

            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());

           

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            //Data seeding
            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<AppConfig> AppConfigs { get; set; }


        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public  DbSet<CtrDoiTac> CtrDoiTacs { get; set; }
        public  DbSet<CtrHopDong> CtrHopDongs { get; set; }
        public  DbSet<CtrKhachHang> CtrKhachHangs { get; set; }
        public  DbSet<CtrCongNo> CtrCongNos { get; set; }
        public DbSet<FileHopDong> FileHopDongs { get; set; }
    }
}
