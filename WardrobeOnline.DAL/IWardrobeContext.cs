using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.DAL
{
    public interface IWardrobeContext // а как тогда с подключениями работать? Делать фасад над контекстами?
    {
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
