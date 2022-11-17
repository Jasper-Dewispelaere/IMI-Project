using Imi.Project.Blazor.Data.Seeding.QuizSeeding;
using Imi.Project.Blazor.Models.Quiz;

namespace Imi.Project.Blazor.Services
{
    public class QuizService : IQuizService<QuizItem>
    {
        List<QuizItem> quizQuestions = QuestionSeeding.GetQuestions;

        public Task<QuizItem[]> GetQuestion()
        {
            throw new NotImplementedException();
        }
    }
}
