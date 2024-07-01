using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Models.Interfaces
{
    public interface ISetProvider
    {
        public Set Get(int id);
        public void Add(Set set);
        public void Remove(int id);
        public void Update(Set set);
    }
}
