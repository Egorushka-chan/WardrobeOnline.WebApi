using Microsoft.EntityFrameworkCore;
using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Interfaces;

namespace WardrobeOnline.DAL
{

    public class WardrobeContext : DbContext, IWardrobeContext
    {
        //private string _connection = "Host=localhost;Port=5432;Database=wardrobe;Username=postgres;Password=root";

        //public WardrobeContext(string connection) : base()
        //{
        //    _connection = connection;
        //}

        //public WardrobeContext(){}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder
        //        .UseNpgsql(_connection);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Photo>()
                .Property(e => e.IsDBStored)
                .HasDefaultValue(false);
        }

        public DbSet<T> DBSet<T>() where T : class, IEntity
        {
            return this.Set<T>();
        }

        public WardrobeContext Context() => this;

        public DbSet<Person> Persons { get; set; }
        public DbSet<Complection> Complections { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<SetHasClothes> SetHasClothes { get; set; }
        public DbSet<Cloth> Clothes { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<ClothHasMaterials> ClothHasMaterials { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}
