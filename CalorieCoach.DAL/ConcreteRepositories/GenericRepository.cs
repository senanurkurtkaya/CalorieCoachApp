using CalorieCoach.DAL.AbstractRepositories;
using CalorieCoach.DAL.Data;
using CalorieCoach.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCoach.DAL.ConcreteRepositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly CalorieCoachDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(CalorieCoachDbContext  dbContext)
        {
            _context = dbContext;
            _dbSet = _context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

      

        public void Delete(TEntity entity)
        {
           
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
            
        }

        public void Update(TEntity entity)
        {
        
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
