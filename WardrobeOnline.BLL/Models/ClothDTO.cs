using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.BLL.Repository.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Models
{
    public record ClothDTO(int iD, string name) : IEntityDTO
    {
        public int ID { get; init; } = iD;
        public string Name { get; init; } = name;
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
