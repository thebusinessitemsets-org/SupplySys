using DDNS.DataModel.DataCenter;
using DDNS.Entity.DataCenter;
using DDNS.Interface.DataCenter;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDNS.Provider.DataCenter
{
    public class ProdUnitProvider : IProdUnit
    {
        public readonly ProdUnitDataModel _data;
        public ProdUnitProvider(ProdUnitDataModel data)
        {
            _data = data;
        }

        public Task<bool> AddProdUnit(ProdUnitEntity prodUnitEntity)
        {
            return _data.AddProdUnit(prodUnitEntity);
        }

        public Task<bool> DelProdUnit(int ID)
        {
            return _data.DelProdUnit(ID);
        }

        public Task<bool> UpdateProdUnit(ProdUnitEntity prodUnitEntity)
        {
            return _data.UpdateProdUnit(prodUnitEntity);
        }

        public Task<ProdUnitEntity> ProdUnit(int id)
        {
            return _data.ProdUnit(id);
        }

        public Task<IEnumerable<ProdUnitEntity>> ProdUnitList()
        {
            return _data.ProdUnitList();
        }

    }
}
