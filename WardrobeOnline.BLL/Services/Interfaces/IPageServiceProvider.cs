using WardrobeOnline.DAL.Interfaces;

namespace WardrobeOnline.BLL.Services.Interfaces
{
    public interface IPageServiceProvider<TEntity>
        where TEntity : class, IEntity
    {
        public IReadOnlyList<TEntity> GetPagedQuantityOf(int pageIndex, int pageSize);
    }
}
