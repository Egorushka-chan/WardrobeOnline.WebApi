using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeOnline.DAL.Entities
{
    public partial class ClothHasMaterials
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID {get; set;}
        [Required, ForeignKey("ClothForeignKey")]
        public int ClothID { get; set;}
        [Required, ForeignKey("MaterialForeignKey")]
        public int MaterialID { get; set;}
        public virtual Cloth? Cloth { get; set;}
        public virtual Material? Material { get; set;}
    }
}
