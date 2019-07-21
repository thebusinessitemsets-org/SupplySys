using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.PurchaseCenter
{
    public interface IOUT_BACK01
    {
        Task<bool> AddOUT_BACK01s(List<OUT_BACK01Entity> OUT_BACK01Entities);
        Task<bool> DelOUT_BACK01(int id);
        Task<bool> UpdateOUT_BACK01(OUT_BACK01Entity OUT_BACK01Entity);
        Task<OUT_BACK01Entity> OUT_BACK01(int id);
        Task<IEnumerable<OUT_BACK01Entity>> OUT_BACK01List();
    }
}
