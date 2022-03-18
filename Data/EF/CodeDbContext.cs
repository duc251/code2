using Data.Conf;
using Data.Entiti;
using Data.Ext;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EF
{
    public class CodeDbContext :IdentityDbContext< AppUser,AppRole, Guid>
    {
        public CodeDbContext(DbContextOptions options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());

            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());

            modelBuilder.ApplyConfiguration(new CtrKhachHangConfiguration());
            modelBuilder.ApplyConfiguration(new CtrCongNoConfiguration());
            modelBuilder.ApplyConfiguration(new CtrHopDongConfiguration());
            modelBuilder.ApplyConfiguration(new DoiTacConfiguration());
            modelBuilder.ApplyConfiguration(new FileHopDongConfiguration());


            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });

            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);
            modelBuilder.Seed();

        }
        public DbSet<AppConfig> Configs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<CtrDoiTac> CtrDoiTacs { get; set; }
        public DbSet<CtrHopDong> CtrHopDongs { get; set; }
        public DbSet<CtrKhachHang> CtrKhachHangs { get; set; }
        public DbSet<CtrCongNo> CtrCongNos { get; set; }
        public DbSet<FileHopDong> FileHopDongs { get; set; }
    }
}
