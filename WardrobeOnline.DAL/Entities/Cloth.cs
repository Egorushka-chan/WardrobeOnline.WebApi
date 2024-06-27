using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeOnline.DAL.Entities
{
    public partial class Cloth
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public int SelectedPhotoID { get; set; }
        public int Rating { get; set; }
        public string? Size { get; set; }

        public virtual ICollection<ClothHasMaterials> ClothHasMaterials { get; set; } = new List<ClothHasMaterials>();
        public virtual ICollection<Photo> Photos { get; set; } = new List<Photo>();
        public virtual ICollection<SetHasClothes> SetClothes { get; set; } = new List<SetHasClothes>();
    }
}
