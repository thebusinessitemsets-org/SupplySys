using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.DataCenter
{
    public interface ICOMPONENT01
    {
        Task<bool> AddCOMPONENT01s(List<COMPONENT01Entity> cOMPONENT01Entities);
        Task<bool> DelCOMPONENT01(int id);
        Task<bool> UpdateCOMPONENT01(COMPONENT01Entity cOMPONENT01Entity);
        Task<COMPONENT01Entity> COMPONENT01(int id);
        Task<IEnumerable<COMPONENT01Entity>> COMPONENT01List();
    }
}
