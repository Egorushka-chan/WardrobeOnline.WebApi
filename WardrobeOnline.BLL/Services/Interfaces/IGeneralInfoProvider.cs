namespace WardrobeOnline.BLL.Services.Interfaces
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
