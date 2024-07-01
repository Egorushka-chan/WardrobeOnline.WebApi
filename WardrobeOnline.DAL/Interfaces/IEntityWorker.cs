using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeOnline.DAL.Interfaces
{
    public interface IEntityWorker<TEntity> where TEntity : IEntity
    {
        public IEnumerable<TEntity> GetAll();
        public TEntity Get(int id);
        public void Add(TEntity entity);
        public void Remove(int id);
        public void Update(TEntity entity);
    }
}
