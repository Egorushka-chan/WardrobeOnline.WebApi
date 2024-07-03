using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Repository.Interfaces;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class PersonProvider : IEntityProvider<PersonDTO>
    {
        public void Add(PersonDTO entity)
        {
            throw new NotImplementedException();
        }

        public PersonDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<PersonDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(PersonDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PersonDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
