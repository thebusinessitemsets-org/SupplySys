using DDNS.Entity.SupplyCenter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Interface.SupplyCenter
{
    public interface IColOrder02
    {
        Task<bool> AddColOrder02(ColOrder02Entity colorder01Entity);
        //Task<bool> DelColOrder01(int id);
        Task<bool> UpdateColOrder02(ColOrder02Entity colorder01Entity);
        Task<ColOrder02Entity> ColOrder02(int id);
        Task<IEnumerable<ColOrder02Entity>> ColOrder02List(int id);
    }
}
