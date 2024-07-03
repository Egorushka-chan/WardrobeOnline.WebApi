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
    public record PersonDTO(int iD, string name) : IEntityDTO
    {
        public int ID { get; init; } = iD;
        public string Name { get; init; } = name;
        public string? Type { get; init; }
        public IReadOnlyList<int>? ComplectionIDs { get; init; }

        internal Person TranslateToDB(ITranslator translator)
        {
            Person person = new()
            {
                ID = ID,
                Name = Name,
                Type = Type,
            };
            return person;
        }
    }
}
