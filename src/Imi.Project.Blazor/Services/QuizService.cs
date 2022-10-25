using Imi.Project.Blazor.Data;

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
