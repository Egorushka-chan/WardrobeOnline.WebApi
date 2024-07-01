using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.DAL.Interfaces
{
    public interface IWardrobeContext 
    {
        // Вариант 1:

        public IEntityWorker<Person> PersonWorker { get; set; }
        public IEntityWorker<Complection> ComplectionWorker { get; set; }
        public IEntityWorker<Set> SetWorker { get; set; }
        public IEntityWorker<Season> SeasonWorker { get; set; }
        public IEntityWorker<SetHasClothes> SetHasClotherWorker { get; set; }
        public IEntityWorker<Cloth> ClothWorker { get; set; }
        public IEntityWorker<Material> MaterialWorker { get; set; }
        public IEntityWorker<ClothHasMaterials> ClothHasMaterialsWorker { get; set; }
        public IEntityWorker<Photo> Photos { get; set; }

        // Вариант 2:
        // а как тогда с подключениями работать?

        //public DbSet<Person> Persons { get; set; }
        //public DbSet<Complection> Complections { get; set; }
        //public DbSet<Set> Sets { get; set; }
        //public DbSet<Season> Seasons { get; set; }
        //public DbSet<SetHasClothes> SetHasClothes { get; set; }
        //public DbSet<Cloth> Clothes { get; set; }
        //public DbSet<Material> Materials { get; set; }
        //public DbSet<ClothHasMaterials> ClothHasMaterials { get; set; }
        //public DbSet<Photo> Photos { get; set; }
    }
}
