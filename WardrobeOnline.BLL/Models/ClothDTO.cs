using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeOnline.BLL.Models
{
    public record ClothDTO(int iD, string name, string description, int rating, string size, IReadOnlyList<string> materials, IReadOnlyList<string> photoPaths)
    {
        public int ID { get; init; } = iD;
        public string Name { get; init; } = name;
        public string Description { get; init; } = description;
        public int Rating { get; init; } = rating;
        public string Size { get; init; } = size;
        public IReadOnlyList<string> Materials { get; init; } = materials;
        public IReadOnlyList<string> PhotoPaths { get; init; } = photoPaths;
    }
}
