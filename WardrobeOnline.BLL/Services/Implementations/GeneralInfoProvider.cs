using WardrobeOnline.BLL.Services.Interfaces;

namespace WardrobeOnline.BLL.Services.Implementations
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
