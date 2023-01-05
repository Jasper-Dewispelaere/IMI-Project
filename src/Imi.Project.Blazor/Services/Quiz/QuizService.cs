using Imi.Project.Blazor.Data.Seeding.QuizSeeding;
using Imi.Project.Blazor.Models.Quiz;

namespace Imi.Project.Blazor.Services.Quiz
{
    public class QuizService : IQuizService<QuizItem>
    {
        List<QuizItem> quizQuestions = QuestionSeeding.GetQuestions;
        Random random = new Random();

        public QuizItem GetQuestion()
        {
            var amountOfQuestions = quizQuestions.Count();
            var Numberquestion = random.Next(amountOfQuestions);
            var question = quizQuestions[Numberquestion];
            return question;
        }
    }
}
