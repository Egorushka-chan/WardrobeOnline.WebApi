using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.BLL.Repository.Interfaces;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class GeneralInfoProvider(ICache cache) : IGeneralInfoProvider // не факт что понадобится
    {
        private ICache _cache = cache;
        public int GetPersonClothCount()
        {
            throw new NotImplementedException();
        }

        public int GetPersonSetCount()
        {
            throw new NotImplementedException();
        }

        public int GetSetClothCount()
        {
            throw new NotImplementedException();
        }

        public int GetTotalPersonCount()
        {
            throw new NotImplementedException();
        }

        public int GetTotalSetCount()
        {
            throw new NotImplementedException();
        }
    }
}
