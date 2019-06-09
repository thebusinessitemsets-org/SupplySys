using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.DataCenter;
using System.Threading.Tasks;


namespace DDNS.Interface.DataCenter
{
    public interface IProdDep
    {
        Task<bool> AddProdDep(ProdDepEntity prodDepEntity);
        Task<bool> DelProdDep(int id);
        Task<bool> UpdateProdDep(ProdDepEntity prodDepEntity);
        Task<ProdDepEntity> ProdDep(int id);
        Task<IEnumerable<ProdDepEntity>> ProdDepList();
    }
}
