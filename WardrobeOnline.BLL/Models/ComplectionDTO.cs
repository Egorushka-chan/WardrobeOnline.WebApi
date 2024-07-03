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
    public record ComplectionDTO(int iD, int growth, int weight, int personID) : IEntityDTO
    {
        public int ID { get; init; } = iD;
        public string? Description { get; init; }
        public int Growth { get; init; } = growth;
        public int Weight { get; init; } = weight;
        public int Force { get; init; }
        public int PersonID { get; init; } = personID;
        public IReadOnlyList<int>? SetIDs { get; init; }

        internal Complection TranslateToDB(ITranslator translator)
        {
            Complection complection = new Complection()
            {
                ID = ID,
                Description = Description,
                Growth = Growth,
                Weight = Weight,
                Force = Force,
                PersonID = PersonID
            };
            return complection;
        }
    }
}
