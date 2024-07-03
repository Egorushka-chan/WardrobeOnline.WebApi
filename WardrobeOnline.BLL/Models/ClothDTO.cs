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

        internal Cloth TranslateToDB(ITranslator translator)
        {
            Cloth cloth = new Cloth()
            {
                ID = iD,
                Name = Name,
                Description = Description,
                Rating = Rating,
                Size = Size,
            };
            return cloth;
        }
    }
}
