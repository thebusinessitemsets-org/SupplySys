using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.PurchaseCenter
{
    public interface IIN01
    {
        Task<bool> AddIN01s(List<IN01Entity> iN01Entities);
        Task<bool> DelIN01(int id);
        Task<bool> UpdateIN01(IN01Entity iN01Entity);
        Task<IN01Entity> IN01(int id);
        Task<IEnumerable<IN01Entity>> IN01List();
    }
}
