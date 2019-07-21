using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.PurchaseCenter
{
    public interface ITAKEIN11
    {
        Task<bool> AddTAKEIN11s(List<TAKEIN11Entity> tAKEIN11Entities);
        Task<bool> DelTAKEIN11(int id);
        Task<bool> UpdateTAKEIN11(TAKEIN11Entity tAKEIN11Entity);
        Task<TAKEIN11Entity> TAKEIN11(int id);
        Task<IEnumerable<TAKEIN11Entity>> TAKEIN11List();
    }
}
