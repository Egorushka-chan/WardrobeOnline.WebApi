using Microsoft.EntityFrameworkCore;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.DAL.Interfaces
{
    public interface IWardrobeContext
    {
        // Вариант 1:
        //DbSet<T> DBSet<T>() where T : class, IEntity;

        //public IEntityWorker<Person> Persons { get; set; }
        //public IEntityWorker<Complection> ComplectionWorker { get; set; }
        //public IEntityWorker<Set> SetWorker { get; set; }
        //public IEntityWorker<Season> SeasonWorker { get; set; }
        //public IEntityWorker<SetHasClothes> SetHasClotherWorker { get; set; }
        //public IEntityWorker<Cloth> ClothWorker { get; set; }
        //public IEntityWorker<Material> MaterialWorker { get; set; }
        //public IEntityWorker<ClothHasMaterials> ClothHasMaterialsWorker { get; set; }
        //public IEntityWorker<Photo> Photos { get; set; }

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

        // Вариант 3
        DbSet<Cloth> Clothes { get; set; }
        DbSet<ClothHasMaterials> ClothHasMaterials { get; set; }
        DbSet<Complection> Complections { get; set; }
        DbSet<Material> Materials { get; set; }
        DbSet<Person> Persons { get; set; }
        DbSet<Photo> Photos { get; set; }
        DbSet<Season> Seasons { get; set; }
        DbSet<SetHasClothes> SetHasClothes { get; set; }
        DbSet<Set> Sets { get; set; }

        WardrobeContext Context();
        DbSet<T> DBSet<T>() where T : class, IEntity;
    }
}
