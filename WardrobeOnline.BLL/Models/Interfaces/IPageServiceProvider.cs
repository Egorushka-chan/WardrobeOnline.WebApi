using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WardrobeOnline.DAL.Interfaces;

namespace WardrobeOnline.BLL.Models.Interfaces
{
    public interface IPageServiceProvider<TEntity>
    {
        public TEntity GetPagedQuantityOf(int pageIndex, int pageSize);
    }
}
