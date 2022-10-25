using Imi.Project.Blazor.Models;

namespace Imi.Project.Blazor.Data.Seeding.QuizSeeding
{
    public class QuestionSeeding
    {
        public static List<Quiz> questions = new List<Quiz>
        {
             new Quiz() 
             { 
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), 
                 Question = "In what year did The Shining release?", 
                 CorrectAnswer = "1980", 
                 FalseAnswers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "1981" },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "1984" },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "1979" }
                    }
            },
            new Quiz()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                 Question = "Who directed Titanic?",
                 CorrectAnswer = "James Cameron",
                 FalseAnswers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "Todd Philips" },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "Steven Spielberg" },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "Robert Zemeckis" }
                    }
            },
            //TODO: STILL NEED TO ADD MORE
        };

        public static List<Quiz> GetQuestions
        {
            get
            {
                return questions;
            }
        }
    }
}
