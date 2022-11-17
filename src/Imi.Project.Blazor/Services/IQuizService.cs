namespace Imi.Project.Blazor.Services
{
    public interface IQuizService<T>
    {
        T GetQuestion();
    }
}
