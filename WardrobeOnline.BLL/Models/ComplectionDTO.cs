using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeOnline.BLL.Models
{
    public record ComplectionDTO(int iD, string description, int growth, int weight, int force, int personID, IReadOnlyList<int> setIDs)
    {
        public int ID { get; init; } = iD;
        public string Description { get; init; } = description;
        public int Growth { get; init; } = growth;
        public int Weight { get; init; } = weight;
        public int Force { get; init; } = force;
        public int PersonID { get; init; } = personID;
        public IReadOnlyList<int> SetIDs { get; init; } = setIDs;
    }
}
