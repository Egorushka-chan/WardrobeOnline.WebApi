using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeOnline.BLL.Models
{
    public record SetDTO(int iD, string name, string description, string season, int complectionID, IReadOnlyList<int> clothIDs)
    {
        public int ID { get; init; } = iD;
        public string Name { get; init; } = name;
        public string Description { get; init; } = description;
        public string Season { get; init; } = season;
        public int ComplectionID { get; init; } = complectionID;
        public IReadOnlyList<int> ClothIDs { get; init; } = clothIDs;
    }
}
