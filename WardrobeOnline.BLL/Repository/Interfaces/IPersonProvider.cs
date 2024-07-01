using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Repository.Interfaces
{
    public interface IPersonProvider
    {
        public Person Get(int id);
        public void Add(Person person);
        public void Remove(int id);
        public void Update(Person person);
    }
}
