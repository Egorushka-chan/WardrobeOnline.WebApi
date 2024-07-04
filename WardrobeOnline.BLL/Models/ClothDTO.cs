using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Models
{
    public record ClothDTO: IEntityDTO
    {
        // Пришлось сделать такой конструктор, потому конструктор в обьявлении записи сразу и поля создаёт
        public ClothDTO(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
        public int ID { get; init; }
        public string Name { get; init; }
        public string? Description { get; init; }
        public int Rating { get; init; }
        public string? Size { get; init; }
        public IReadOnlyList<string>? Materials { get; init; }
        public IReadOnlyList<string>? PhotoPaths { get; init; }

        public static explicit operator Cloth(ClothDTO self)
        {
            Cloth cloth = new Cloth()
            {
                ID = self.ID,
                Name = self.Name,
                Description = self.Description,
                Rating = self.Rating,
                Size = self.Size,
            };
            return cloth;
        }

        //internal Cloth TranslateToDB(ITranslator translator)
        //{
        //Cloth cloth = new Cloth()
        //{
        //    ID = self.iD,
        //    Name = self.Name,
        //    Description = self.Description,
        //    Rating = self.Rating,
        //    Size = self.Size,
        //};
        // return cloth;
        //}
    }
}
