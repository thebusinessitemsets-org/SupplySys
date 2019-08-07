using DDNS.Entity.Events;
using DDNS.Entity.LoginLog;
using DDNS.Entity.SupplyCenter;
using DDNS.Entity.DataCenter;
using DDNS.Entity.PurchaseCenter;
using DDNS.Entity.SysMangerment;
using DDNS.Entity.Tunnel;
using DDNS.Entity.Users;
using DDNS.Entity.Verify;
using Microsoft.EntityFrameworkCore;

namespace DDNS.Entity
{
    public class DDNSDbContext : DbContext
    {
        public DDNSDbContext(DbContextOptions<DDNSDbContext> options) : base(options) { }

        public DbSet<ManagerEntity> Manager { get; set; }

        public DbSet<VerifyEntity> Verifies { get; set; }

        public DbSet<LoginLogEntity> LoginLog { get; set; }

        public DbSet<TunnelsEntity> Tunnels { get; set; }

        public DbSet<CloseConnectionEntity> CloseConnections { get; set; }

        public DbSet<CloseTunnelEntity> CloseTunnels { get; set; }

        //DataCenter
        public DbSet<PROD_CateEntity> PROD_Cate { get; set; }
        public DbSet<ProdUnitEntity> ProdUnit { get; set; }
        public DbSet<ProdDepEntity> ProdDep { get; set; }
        public DbSet<ProdKindEntity> ProdKind { get; set; }
        public DbSet<SHOP_PRICE_AREAEntity> SHOP_PRICE_AREA { get; set; }
        public DbSet<STOCK00Entity> STOCK00 { get; set; }
        public DbSet<STOCK01Entity> STOCK01 { get; set; }
        public DbSet<PRODUCT00Entity> PRODUCT00 { get; set; }
        public DbSet<PRODUCT01Entity> PRODUCT01 { get; set; }
        public DbSet<COMPONENT00Entity> COMPONENT00 { get; set; }
        public DbSet<COMPONENT01Entity> COMPONENT01 { get; set; }

        //PurchaseCenter
        public DbSet<Purchase00Entity> Purchase00 { get; set; }
        public DbSet<Purchase01Entity> Purchase01 { get; set; }
        public DbSet<TAKEIN10Entity> TAKEIN10 { get; set; }
        public DbSet<TAKEIN11Entity> TAKEIN11 { get; set; }
        public DbSet<OUT00Entity> OUT00 { get; set; }
        public DbSet<OUT01Entity> OUT01 { get; set; }
        public DbSet<IN00Entity> IN00 { get; set; }
        public DbSet<IN01Entity> IN01 { get; set; }

        public DbSet<OUT_BACK00Entity> OUT_BACK00 { get; set; }
        public DbSet<OUT_BACK01Entity> OUT_BACK01 { get; set; }




        public DbSet<OrderEntity> Order { get; set; }
        public DbSet<Order01Entity> Order01 { get; set; }
        public DbSet<ColOrderEntity> ColOrder { get; set; }
        public DbSet<ColOrder01Entity> ColOrder01 { get; set; }
        public DbSet<ColOrder02Entity> ColOrder02 { get; set; }

        public DbSet<MenuInfoEntity> MenuInfo { get; set; }
        public DbSet<MenuControlInfoEntity> MenuControlInfo { get; set; }
        public DbSet<DIVISIONEntity> DIVISION { get; set; }
        public DbSet<BranchEntity> Branch { get; set; }

        //manager



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}