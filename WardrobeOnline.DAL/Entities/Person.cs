using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.DAL.Interfaces;

namespace WardrobeOnline.DAL.Entities
{
    public partial class Person : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Type {get; set; } // Не только люди могут одеваться
        public virtual ICollection<Complection> Complections { get; set; } = new List<Complection>();
        
    }
}
