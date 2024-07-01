namespace WardrobeOnline.BLL.Repository.Interfaces
{
    public interface IPageServiceProvider<TEntity>
    {
        public TEntity GetPagedQuantityOf(int pageIndex, int pageSize);
    }
}
