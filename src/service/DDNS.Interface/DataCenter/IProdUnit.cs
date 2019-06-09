using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.DataCenter
{
    public interface IProdUnit
    {
        Task<bool> AddProdUnit(ProdUnitEntity orderEntity);
        Task<bool> DelProdUnit(int id);
        Task<bool> UpdateProdUnit(ProdUnitEntity orderEntity);
        Task<ProdUnitEntity> ProdUnit(int id);
        Task<IEnumerable<ProdUnitEntity>> ProdUnitList();
    }
}
