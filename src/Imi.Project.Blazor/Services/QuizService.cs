using Imi.Project.Blazor.Data.Seeding.QuizSeeding;
using Imi.Project.Blazor.Models;

namespace Imi.Project.Blazor.Services
{
    public class QuizService : IQuizService<Quiz>
    {
        List<Quiz> quizQuestions = QuestionSeeding.GetQuestions;

        public Task<Quiz[]> GetQuestion()
        {
            throw new NotImplementedException();
        }
    }
}
