using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeOnline.DAL.Entities
{
    public partial class Complection
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        public int Growth { get; set; }
        public int Force { get;  set;}
        [Required]
        public int PersonID { get; set; }
        public virtual Person? Person { get; set; }
    }
}
