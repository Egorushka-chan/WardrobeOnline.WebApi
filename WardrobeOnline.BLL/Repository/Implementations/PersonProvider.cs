using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Repository.Interfaces;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class PersonProvider : ICRUDProvider<PersonDTO>
    {
        // TODO: соединить провайдер персон с базой
        public void TryAdd(PersonDTO entity)
        {
            throw new NotImplementedException();
        }

        public PersonDTO TryGet(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<PersonDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void TryRemove(int id)
        {
            throw new NotImplementedException();
        }

        public void TryRemove(PersonDTO entity)
        {
            throw new NotImplementedException();
        }

        public void TryUpdate(PersonDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
