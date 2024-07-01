using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeOnline.BLL.Models
{
    public record PersonDTO(int iD, string name, string type, IReadOnlyList<int> complectionsID)
    {
        public int ID { get; init; } = iD;
        public string Name { get; init; } = name;
        public string Type { get; init; } = type;
        public IReadOnlyList<int> ComplectionIDs { get; init; } = complectionsID;
    }
}
