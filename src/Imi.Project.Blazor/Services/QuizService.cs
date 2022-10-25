using Imi.Project.Blazor.Models;

namespace Imi.Project.Blazor.Services
{
    public class QuizService : IQuizService<Quiz>
    {
        public Task<Quiz[]> GetQuestion()
        {
            throw new NotImplementedException();
        }
    }
}
