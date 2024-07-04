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
