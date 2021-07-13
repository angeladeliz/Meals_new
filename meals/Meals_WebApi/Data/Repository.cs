using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Meals_WebApi.Models;

namespace Meals_WebApi.Data
{
    public class Repository : IRepository
    {
         private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Meal[]> GetAllMealsAsync()
        {
            IQueryable<Meal> query = _context.Meals;

            query = query.AsNoTracking()
                         .OrderBy(meal => meal.Name);

            return await query.ToArrayAsync();
        }
        public async Task<Meal> GetMealAsyncByName(string name)
        {
            IQueryable<Meal> query = _context.Meals;

            query = query.AsNoTracking()
                         .OrderBy(meal => meal.Name)
                         .Where(meal => name.Contains(meal.Name));
            return await query.FirstOrDefaultAsync();
        }       
    }
}