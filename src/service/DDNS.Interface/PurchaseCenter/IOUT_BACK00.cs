using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.PurchaseCenter
{
    public interface IOUT_BACK00
    {
        Task<bool> AddOUT_BACK00s(List<OUT_BACK00Entity> oUT_BACK00Entities);
        Task<bool> DelOUT_BACK00(int id);
        Task<bool> UpdateOUT_BACK00(OUT_BACK00Entity oUT_BACK00Entity);
        Task<OUT_BACK00Entity> OUT_BACK00(int id);
        Task<IEnumerable<OUT_BACK00Entity>> OUT_BACK00List();
    }
}
