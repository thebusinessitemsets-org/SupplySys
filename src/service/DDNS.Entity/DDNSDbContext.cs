using DDNS.Entity.Events;
using DDNS.Entity.LoginLog;
using DDNS.Entity.SupplyCenter;
using DDNS.Entity.DataCenter;
using DDNS.Entity.Tunnel;
using DDNS.Entity.Users;
using DDNS.Entity.Verify;
using Microsoft.EntityFrameworkCore;

namespace DDNS.Entity
{
    public class DDNSDbContext : DbContext
    {
        public DDNSDbContext(DbContextOptions<DDNSDbContext> options) : base(options) { }

        public DbSet<UsersEntity> Users { get; set; }

        public DbSet<VerifyEntity> Verifies { get; set; }

        public DbSet<LoginLogEntity> LoginLog { get; set; }

        public DbSet<TunnelsEntity> Tunnels { get; set; }

        public DbSet<CloseConnectionEntity> CloseConnections { get; set; }

        public DbSet<CloseTunnelEntity> CloseTunnels { get; set; }

        //DataCenter
        public DbSet<ProdUnitEntity> ProdUnit { get; set; }
        public DbSet<ProdDepEntity> ProdDep { get; set; }
        public DbSet<ProdKindEntity> ProdKind { get; set; }



        public DbSet<OrderEntity> Order { get; set; }
        public DbSet<Order01Entity> Order01 { get; set; }
        public DbSet<ColOrderEntity> ColOrder { get; set; }
        public DbSet<ColOrder01Entity> ColOrder01 { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}