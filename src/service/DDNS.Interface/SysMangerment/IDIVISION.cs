using DDNS.Entity.SysMangerment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DDNS.Interface.SysMangerment
{
    public interface IDIVISION
    {
        Task<bool> Add(DIVISIONEntity dIVISIONEntity);
        Task<bool> Del(int id);
        Task<bool> Update(DIVISIONEntity menuInfoEntity);
        Task<DIVISIONEntity> Get(int id);
        Task<IEnumerable<DIVISIONEntity>> Get(string divName);
    }
}
