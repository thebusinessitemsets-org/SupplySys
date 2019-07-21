using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.PurchaseCenter
{
    public interface IOUT01
    {
        Task<bool> AddOUT01s(List<OUT01Entity> oUT01Entities);
        Task<bool> DelOUT01(int id);
        Task<bool> UpdateOUT01(OUT01Entity oUT01Entity);
        Task<OUT01Entity> OUT01(int id);
        Task<IEnumerable<OUT01Entity>> OUT01List();
    }
}
