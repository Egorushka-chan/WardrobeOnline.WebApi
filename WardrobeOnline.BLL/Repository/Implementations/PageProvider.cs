using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.BLL.Repository.Interfaces;
using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Interfaces;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class PageProvider<TEntity> : IPageServiceProvider<TEntity>
        where TEntity : class, IEntity
    {
        public IReadOnlyList<TEntity> GetPagedQuantityOf(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
