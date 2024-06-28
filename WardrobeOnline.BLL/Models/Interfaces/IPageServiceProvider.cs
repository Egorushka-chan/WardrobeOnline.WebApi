using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WardrobeOnline.DAL.Interfaces;

namespace WardrobeOnline.BLL.Models.Interfaces
{
    public interface IPageServiceProvider
    {
        public T GetPagedQuantityOf<T>(int pageIndex, int pageSize) where T : IEntity;
    }
}
