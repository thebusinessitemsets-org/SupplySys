using System;
using System.Collections.Generic;
using System.Text;
using DDNS.Entity.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Interface.DataCenter
{
    public interface IProd_Cate
    {
        Task<bool> AddPROD_Cate(PROD_CateEntity prod_CateEntity);
        Task<bool> AddPROD_Cates(List<PROD_CateEntity> prod_CateEntitys);
        Task<bool> DelPROD_Cate(int id);
        Task<bool> UpdatePROD_Cate(PROD_CateEntity prodDepEntity);
        Task<PROD_CateEntity> PROD_Cate(int id);
        Task<IEnumerable<PROD_CateEntity>> PROD_CateList();
    }
}
