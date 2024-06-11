using Cz.Project.EFInfraStructure;
using CZ.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Repository
{
    public class BaseRepository<T> where T : BaseEntity
    {
        public CZDBContext dbContext;

        public BaseRepository()
        {
            dbContext = new CZDBContext();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public virtual async Task<T?> GetById(int id)
        {
            return await dbContext.Set<T>().Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public virtual async Task Add(T entity)
        {
            await dbContext.AddAsync(entity);
        }
    }
}
