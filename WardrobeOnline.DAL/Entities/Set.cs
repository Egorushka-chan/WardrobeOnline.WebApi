using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeOnline.DAL.Entities
{
    public partial class Set
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public int ComplectionID { get;set; }
        [Required]
        public int SeasonID { get; set; }
        public virtual ICollection<SetHasClothes>? SetHasClothes { get; set; }
        public virtual Complection? Complection { get; set; }
        public virtual Season? Season { get; set; }
    }
}
