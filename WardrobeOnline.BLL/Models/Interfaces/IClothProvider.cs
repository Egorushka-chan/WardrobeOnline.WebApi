using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Models.Interfaces
{
    public interface IClothProvider
    {
        public Cloth Get(int id);
        public void Add(Cloth cloth);
        public void Remove(int id);
        public void Update(Cloth cloth);
    }
}
