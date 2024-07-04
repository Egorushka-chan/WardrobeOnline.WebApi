using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Repository.Interfaces;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class PhysiqueProvider : IEntityProvider<PhysiqueDTO>
    {
        // TODO: соединить провайдер комплекции с базой
        public void Add(PhysiqueDTO entity)
        {
            throw new NotImplementedException();
        }

        public PhysiqueDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<PhysiqueDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(PhysiqueDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PhysiqueDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
