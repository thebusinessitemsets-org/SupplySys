using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.PurchaseCenter
{
    public interface IIN00
    {
        Task<bool> AddIN00s(List<IN00Entity> iN00Entities);
        Task<bool> DelIN00(int id);
        Task<bool> UpdateIN00(IN00Entity iN00Entity);
        Task<IN00Entity> IN00(int id);
        Task<IEnumerable<IN00Entity>> IN00List();
    }
}
