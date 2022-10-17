namespace Imi.Project.Blazor.Services
{
    public interface ICRUDService<T> where T : class
    {
        Task<IQueryable<T>> GetAll(); 
        Task<T> Get(int id); 
        Task Create(T item); 
        Task Update(T item); 
        Task Delete(int id);
    }
}
