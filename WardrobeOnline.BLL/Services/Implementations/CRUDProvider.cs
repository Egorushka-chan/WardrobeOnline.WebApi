using System.Collections.Immutable;
using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.BLL.Services.Extensions;
using WardrobeOnline.BLL.Services.Interfaces;
using WardrobeOnline.DAL.Interfaces;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.BLL.Services.Implementations
{
    public class CRUDProvider<TEntityDTO, TEntityDB> 
        : ICRUDProvider<TEntityDTO>
        where TEntityDTO : class, IEntityDTO
        where TEntityDB : class, IEntity
    {
        public CRUDProvider(IWardrobeContext context, ICastHelper castHelper, IPaginationService<TEntityDB> paginationService)
        {
            _castHelper = castHelper;
            _context = context;
            _pagination = paginationService;
        }

        private IWardrobeContext _context;
        private ICastHelper _castHelper;
        private IPaginationService<TEntityDB> _pagination;

        private int _changes = 0;

        public IReadOnlyCollection<TEntityDTO> GetPagedQuantity(int pageIndex, int pageSize)
        {
            var list = _pagination.GetPagedQuantityOf(pageIndex, pageSize);
            return TranslateToDTO(list);
        }

        public async Task<TEntityDTO?> TryAdd(TEntityDTO entity)
        {
            TEntityDB entityDB = TranslateToDB(entity);
            var result = await _context.DBSet<TEntityDB>().AddAsync(entityDB);
            _changes++;
            return TranslateToDTO(entityDB);
        }

        public async Task<TEntityDTO?> TryGetAsync(int id)
        {
            TEntityDB? entityDB = await _context.DBSet<TEntityDB>().FindAsync(id);
            if (entityDB is null)
                return null;
            return TranslateToDTO(entityDB);
        }

        public Task<bool> TryRemove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntityDTO?> TryUpdate(TEntityDTO entity)
        {
            throw new NotImplementedException();
        }

        protected IReadOnlyCollection<TEntityDTO> TranslateToDTO(IEnumerable<TEntityDB> entityDBs)
        {
            List<TEntityDTO> returnList = [];
            foreach (var entityDB in entityDBs)
            {
                returnList.Add(TranslateToDTO(entityDB));
            }
            return returnList.ToImmutableArray();
        }

        protected IReadOnlyCollection<TEntityDB> TranslateToDB(IEnumerable<TEntityDTO> entityDTOs)
        {
            List<TEntityDB> returnList = [];
            foreach (var entityDTO in entityDTOs)
            {
                returnList.Add(TranslateToDB(entityDTO));
            }
            return returnList.ToImmutableArray();
        }

        /// <summary>
        /// Метод можно переопределить для изменения стандартного приведения классов DTO к DB
        /// </summary>
        /// <param name="entityDTO">Элемент, реализующий интерфейс <see cref="IEntityDTO"/></param>
        /// <exception cref="NotImplementedException"></exception>
        protected virtual TEntityDB TranslateToDB(TEntityDTO entityDTO)
        {
            entityDTO.TranslateToDB(out TEntityDB? resultDB, _castHelper);
            if (resultDB is null)
            {
                throw new NotImplementedException("Стандартный переводчик классов не работает");
            }
            return resultDB;
        }

        /// <summary>
        /// Метод можно переопределить для изменения стандартного приведения классов DB к DTO
        /// </summary>
        /// <param name="entityDB">Элемент, реализующий интерфейс <see cref="IEntity"/></param>
        /// <exception cref="NotImplementedException"></exception>
        protected virtual TEntityDTO TranslateToDTO(TEntityDB entityDB)
        {
            entityDB.TranslateToDTO(out TEntityDTO? resultDTO, _castHelper);
            if(resultDTO is null)
            {
                throw new NotImplementedException("Стандартный переводчик классов не работает");
            }
            return resultDTO;
        }
    }
}
