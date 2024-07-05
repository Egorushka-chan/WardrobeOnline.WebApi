using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Models
{
    public record PhysiqueDTO : IEntityDTO
    {
        // Пришлось сделать такой конструктор, потому конструктор в обьявлении записи сразу и поля создаёт
        public PhysiqueDTO(int iD, int growth, int weight, int personID)
        {
            ID = iD;
            Growth = growth;
            Weight = weight;
            PersonID = personID;
        }

        public int ID { get; init; }
        public string? Description { get; init; }
        public int Growth { get; init; }
        public int Weight { get; init; }
        public int Force { get; init; }
        public int PersonID { get; init; }
        public IReadOnlyList<int>? SetIDs { get; init; }

        // Приведения прикольны(в структурах), но тут к сожалению не применимы (даже не наследуешь нормально). Мне в проекте требуется сложное приведение
        // Надо делать особые запросы в базу. Но даже хелпер сюда не засунешь, а в запись саму передавать - порнография

        //public static explicit operator Physique(PhysiqueDTO self)
        //{
        //    Physique physique = new Physique()
        //    {
        //        ID = self.ID,
        //        Description = self.Description,
        //        Growth = self.Growth,
        //        Weight = self.Weight,
        //        Force = self.Force,
        //        PersonID = self.PersonID
        //    };
        //    return physique;
        //}

        //internal Complection TranslateToDB(ITranslator translator)
        //{

        //}
    }
}
