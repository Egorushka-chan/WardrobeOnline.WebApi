using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeOnline.BLL.Models.Interfaces
{
    public interface IGeneralInfoProvider
    {
        public int GetTotalSetCount();
        public int GetPersonSetCount();
        public int GetTotalPersonCount();
        public int GetPersonClothCount();
        public int GetSetClothCount();
    }
}
