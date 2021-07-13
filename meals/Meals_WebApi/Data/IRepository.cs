using System.Threading.Tasks;
using Meals_WebApi.Models;

namespace Meals_WebApi.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //ALUNO
        Task<Meal[]> GetAllMealsAsync();        
        Task<Meal> GetMealAsyncByName(string name);
    }
}