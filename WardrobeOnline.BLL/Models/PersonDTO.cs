using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Models
{
    public record PersonDTO : IEntityDTO
    {
        // Пришлось сделать такой конструктор, потому конструктор в обьявлении записи сразу и поля создаёт
        public PersonDTO(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
        public int ID { get; init; }
        public string Name { get; init; }
        public string? Type { get; init; }
        public IReadOnlyList<int>? PhysiqueIDs { get; init; }

        public static explicit operator Person(PersonDTO self)
        {
            Person person = new()
            {
                ID = self.ID, 
                Name = self.Name,
                Type = self.Type,
            };
            return person;
        }

        //internal Person TranslateToDB(ITranslator translator)
        //{
            
        //}
    }
}
