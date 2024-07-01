using WardrobeOnline.BLL.Repository.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class ClothPageProvider : IPageServiceProvider<Cloth>
    {
        public Cloth GetPagedQuantityOf(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
