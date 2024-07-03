using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Repository.Interfaces;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class SetProvider : IEntityProvider<SetDTO>
    {
        public void Add(SetDTO entity)
        {
            throw new NotImplementedException();
        }

        public SetDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<SetDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(SetDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Update(SetDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
