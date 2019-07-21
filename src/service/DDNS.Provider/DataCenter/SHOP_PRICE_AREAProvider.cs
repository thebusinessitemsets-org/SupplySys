using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.DataCenter;
using DDNS.Entity.DataCenter;
using DDNS.Interface.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.DataCenter
{
    public class SHOP_PRICE_AREAProvider:ISHOP_PRICE_AREA
    {
        public readonly SHOP_PRICE_AREADataModel _data;
        public SHOP_PRICE_AREAProvider(SHOP_PRICE_AREADataModel data)
        {
            _data = data;
        }

        public Task<bool> AddSHOP_PRICE_AREAs(List<SHOP_PRICE_AREAEntity> sHOP_PRICE_AREAEntities)
        {
            return _data.AddSHOP_PRICE_AREAs(sHOP_PRICE_AREAEntities);
        }

        public Task<bool> DelSHOP_PRICE_AREA(int ID)
        {
            return _data.DelSHOP_PRICE_AREA(ID);
        }

        public Task<bool> UpdateSHOP_PRICE_AREA(SHOP_PRICE_AREAEntity sHOP_PRICE_AREAEntity)
        {
            return _data.UpdateSHOP_PRICE_AREA(sHOP_PRICE_AREAEntity);
        }

        public Task<SHOP_PRICE_AREAEntity> SHOP_PRICE_AREA(int id)
        {
            return _data.SHOP_PRICE_AREA(id);
        }

        public Task<IEnumerable<SHOP_PRICE_AREAEntity>> SHOP_PRICE_AREAList()
        {
            return _data.SHOP_PRICE_AREAList();
        }
    }
}
