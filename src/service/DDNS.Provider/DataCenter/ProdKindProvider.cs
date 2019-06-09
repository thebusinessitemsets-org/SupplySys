using System;
using System.Collections.Generic;
using System.Text;
using DDNS.DataModel.DataCenter;
using DDNS.Entity.DataCenter;
using DDNS.Interface.DataCenter;
using System.Threading.Tasks;

namespace DDNS.Provider.DataCenter
{
    public class ProdKindProvider:IProdKind
    {
        public readonly ProdKindDataModel _data;
        public ProdKindProvider(ProdKindDataModel data)
        {
            _data = data;
        }

        public Task<bool> AddProdKind(ProdKindEntity prodKindEntity)
        {
            return _data.AddProdKind(prodKindEntity);
        }

        public Task<bool> AddProdKinds(List<ProdKindEntity> prodKindEntitys)
        {
            return _data.AddProdKinds(prodKindEntitys);
        }

        public Task<bool> DelProdKind(int ID)
        {
            return _data.DelProdKind(ID);
        }

        public Task<bool> UpdateProdKind(ProdKindEntity prodKindEntity)
        {
            return _data.UpdateProdKind(prodKindEntity);
        }

        public Task<ProdKindEntity> ProdKind(int id)
        {
            return _data.ProdKind(id);
        }

        public Task<IEnumerable<ProdKindEntity>> ProdKindList()
        {
            return _data.ProdKindList();
        }
    }
}
