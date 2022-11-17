using Imi.Project.Blazor.Models.Quiz;

namespace Imi.Project.Blazor.Data.Seeding.QuizSeeding
{
    public class QuestionSeeding
    {
        public static List<QuizItem> questions = new List<QuizItem>
        {
             new QuizItem() 
             { 
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), 
                 Question = "In what year did The Shining release?", 
                 FalseAnswers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "1981", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "1984", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "1980", IsRightAnswer = true },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "1979", IsRightAnswer = false },
                    }
            },
            new QuizItem()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                 Question = "Who directed Titanic?",
                 FalseAnswers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "Todd Philips", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "Steven Spielberg", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "James Cameron", IsRightAnswer = true },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "Robert Zemeckis", IsRightAnswer = false }
                    }
            },
            //TODO: STILL NEED TO ADD MORE
        };

        public static List<QuizItem> GetQuestions
        {
            get
            {
                return questions;
            }
        }
    }
}
