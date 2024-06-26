using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeOnline.DAL.Entities
{
    public partial class Photo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public byte[]? Value { get; set; }
        [Required]
        public int ClothID { get; set; }
        public virtual Cloth? Cloth { get; set; }
    }
}
