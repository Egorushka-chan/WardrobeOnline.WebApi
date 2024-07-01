using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.BLL.Repository.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class PersonPageProvider : IPageServiceProvider<Person>
    {
        public Person GetPagedQuantityOf(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
