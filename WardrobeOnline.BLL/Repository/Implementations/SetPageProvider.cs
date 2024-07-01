using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.BLL.Repository.Interfaces;
using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Interfaces;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class SetPageProvider: IPageServiceProvider<Set>
    {
        public Set GetPagedQuantityOf(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
