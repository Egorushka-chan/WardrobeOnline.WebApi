﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using WardrobeOnline.DAL.Interfaces;

namespace WardrobeOnline.DAL.Entities
{
    public partial class Photo : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string HashCode { get; set; }
        public bool IsDBStored { get; set; } // False по дефолту
        public byte[]? Value { get; set; }  // Может быть пригодится
        [Required, ForeignKey("ClothForeignKey")]
        public int ClothID { get; set; }
        public virtual Cloth? Cloth { get; set; }
    }
}
