using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.PurchaseCenter
{
    public interface IOUT00
    {
        Task<bool> AddOUT00s(List<OUT00Entity> OUT00Entities);
        Task<bool> DelOUT00(int id);
        Task<bool> UpdateOUT00(OUT00Entity OUT00Entity);
        Task<OUT00Entity> OUT00(int id);
        Task<IEnumerable<OUT00Entity>> OUT00List();
    }
}
