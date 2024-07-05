using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Models
{
    public record PersonDTO : IEntityDTO
    {
        // Пришлось сделать такой конструктор, потому что конструктор в объявлении записи сразу и поля создаёт
        public PersonDTO(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
        public int ID { get; init; }
        public string Name { get; init; }
        public string? Type { get; init; }
        public IReadOnlyList<int>? PhysiqueIDs { get; init; }

        // Приведения прикольны(в структурах), но тут к сожалению не применимы (даже не наследуешь нормально). Мне в проекте требуется сложное приведение
        // Надо делать особые запросы в базу. Но даже хелпер сюда не засунешь, а в запись саму передавать - порнография

        //public static explicit operator Person(PersonDTO self)
        //{
        //    Person person = new()
        //    {
        //        ID = self.ID, 
        //        Name = self.Name,
        //        Type = self.Type,
        //    };
        //    return person;
        //}

        //internal Person TranslateToDB(ITranslator translator)
        //{

        //}
    }
}
