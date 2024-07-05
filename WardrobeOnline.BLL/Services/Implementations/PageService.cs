using WardrobeOnline.BLL.Services.Interfaces;
using WardrobeOnline.DAL.Interfaces;

namespace WardrobeOnline.BLL.Services.Implementations
{
    public class PageService<TEntity> : IPaginationService<TEntity>
        where TEntity : class, IEntity
    {
        public IReadOnlyList<TEntity> GetPagedQuantityOf(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
