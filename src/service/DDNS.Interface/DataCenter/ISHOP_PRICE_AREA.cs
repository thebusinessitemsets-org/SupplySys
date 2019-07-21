using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.DataCenter
{
    public interface ISHOP_PRICE_AREA
    {
        Task<bool> AddSHOP_PRICE_AREAs(List<SHOP_PRICE_AREAEntity> sHOP_PRICE_AREAEntities);
        Task<bool> DelSHOP_PRICE_AREA(int id);
        Task<bool> UpdateSHOP_PRICE_AREA(SHOP_PRICE_AREAEntity sHOP_PRICE_AREAEntity);
        Task<SHOP_PRICE_AREAEntity> SHOP_PRICE_AREA(int id);
        Task<IEnumerable<SHOP_PRICE_AREAEntity>> SHOP_PRICE_AREAList();
    }
}
