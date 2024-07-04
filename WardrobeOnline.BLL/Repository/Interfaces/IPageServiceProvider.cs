using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.DAL.Interfaces;

namespace WardrobeOnline.BLL.Repository.Interfaces
{
    public interface IPageServiceProvider<TEntity>
        where TEntity : class, IEntity
    {
        public IReadOnlyList<TEntity> GetPagedQuantityOf(int pageIndex, int pageSize);
    }
}
