using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.PurchaseCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.PurchaseCenter
{
    public interface ITAKEIN10
    {
        Task<bool> AddTAKEIN10s(List<TAKEIN10Entity> tAKEIN10Entities);
        Task<bool> DelTAKEIN10(int id);
        Task<bool> UpdateTAKEIN10(TAKEIN10Entity tAKEIN10Entity);
        Task<TAKEIN10Entity> TAKEIN10(int id);
        Task<IEnumerable<TAKEIN10Entity>> TAKEIN10List();
    }
}
