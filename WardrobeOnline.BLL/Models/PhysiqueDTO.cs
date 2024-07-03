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
    public record PhysiqueDTO(int iD, int growth, int weight, int personID) : IEntityDTO
    {
        public int ID { get; init; } = iD;
        public string? Description { get; init; }
        public int Growth { get; init; } = growth;
        public int Weight { get; init; } = weight;
        public int Force { get; init; }
        public int PersonID { get; init; } = personID;
        public IReadOnlyList<int>? SetIDs { get; init; }

        public static explicit operator Physique(PhysiqueDTO self)
        {
            Physique physique = new Physique()
            {
                ID = self.ID,
                Description = self.Description,
                Growth = self.Growth,
                Weight = self.Weight,
                Force = self.Force,
                PersonID = self.PersonID
            };
            return physique;
        }

        //internal Complection TranslateToDB(ITranslator translator)
        //{
            
        //}
    }
}
