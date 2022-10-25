namespace Imi.Project.Blazor.Services
{
    public interface IQuizService<T>
    {
        Task<T[]> GetQuestion();
    }
}
