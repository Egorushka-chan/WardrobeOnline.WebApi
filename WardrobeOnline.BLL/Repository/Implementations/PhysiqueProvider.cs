using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Repository.Interfaces;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class PhysiqueProvider : ICRUDProvider<PhysiqueDTO>
    {
        // TODO: соединить провайдер комплекции с базой
        public void TryAdd(PhysiqueDTO entity)
        {
            throw new NotImplementedException();
        }

        public PhysiqueDTO TryGet(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<PhysiqueDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void TryRemove(int id)
        {
            throw new NotImplementedException();
        }

        public void TryRemove(PhysiqueDTO entity)
        {
            throw new NotImplementedException();
        }

        public void TryUpdate(PhysiqueDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
