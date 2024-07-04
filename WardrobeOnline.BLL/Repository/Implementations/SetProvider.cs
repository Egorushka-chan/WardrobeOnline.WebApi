using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Repository.Interfaces;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class SetProvider : ICRUDProvider<SetDTO>
    {
        // TODO: соединить провайдер комплектов с базой
        public void TryAdd(SetDTO entity)
        {
            throw new NotImplementedException();
        }

        public SetDTO TryGet(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<SetDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void TryRemove(int id)
        {
            throw new NotImplementedException();
        }

        public void TryRemove(SetDTO entity)
        {
            throw new NotImplementedException();
        }

        public void TryUpdate(SetDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
