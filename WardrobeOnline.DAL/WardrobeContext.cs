using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.DAL
{
    public class WardrobeContext : DbContext
    {
        private string _connection = "Host=localhost;Port=5432;Database=wardrobe;Username=User2024;Password=root";
        //public WardrobeContext(string connection)
        //{
        //    _connection = connection;
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql(_connection);
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Complection> Complections { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<SetHasClothes> SetHasClothes { get; set; }
        public DbSet<Cloth> Clothes {  get; set; }
        public DbSet<Material> Materials {  get; set; }
        public DbSet<ClothHasMaterials> ClothHasMaterials {  get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}
