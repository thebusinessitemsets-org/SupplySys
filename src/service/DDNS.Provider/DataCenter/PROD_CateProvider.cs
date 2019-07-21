using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.DataCenter;
using DDNS.Entity.DataCenter;
using DDNS.Interface.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.DataCenter
{
    public class PROD_CateProvider:IProd_Cate
    {
        public readonly PROD_CateDataModel _data;
        public PROD_CateProvider(PROD_CateDataModel data)
        {
            _data = data;
        }

        public Task<bool> AddPROD_Cate(PROD_CateEntity pROD_CateEntity)
        {
            return _data.AddPROD_Cate(pROD_CateEntity);
        }

        public Task<bool> AddPROD_Cates(List<PROD_CateEntity> pROD_CateEntities)
        {
            return _data.AddPROD_Cates(pROD_CateEntities);
        }

        public Task<bool> DelPROD_Cate(int ID)
        {
            return _data.DelPROD_Cate(ID);
        }

        public Task<bool> UpdatePROD_Cate(PROD_CateEntity pROD_CateEntity)
        {
            return _data.UpdatePROD_Cate(pROD_CateEntity);
        }

        public Task<PROD_CateEntity> PROD_Cate(int id)
        {
            return _data.PROD_Cate(id);
        }

        public Task<IEnumerable<PROD_CateEntity>> PROD_CateList()
        {
            return _data.PROD_CateList();
        }
    }
}
