using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.DataCenter
{
    public interface IProdKind
    {
        Task<bool> AddProdKind(ProdKindEntity prodKindEntity);
        Task<bool> AddProdKinds(List<ProdKindEntity> prodKindEntitys);
        Task<bool> DelProdKind(int id);
        Task<bool> UpdateProdKind(ProdKindEntity prodKindEntity);
        Task<ProdKindEntity> ProdKind(int id);
        Task<IEnumerable<ProdKindEntity>> ProdKindList();
    }
}
