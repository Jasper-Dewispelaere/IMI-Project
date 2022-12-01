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
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "1981", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "1984", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "1980", IsRightAnswer = true },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "1979", IsRightAnswer = false }
                    }
            },
            new QuizItem()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                 Question = "Who directed Titanic?",
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "Todd Philips", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "Steven Spielberg", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "James Cameron", IsRightAnswer = true },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "Robert Zemeckis", IsRightAnswer = false }
                    }
            },
            new QuizItem()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                 Question = "Which one of these films is not a comedy?",
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "The Imitation Game", IsRightAnswer = true },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "The Hangover", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "The Grand Budapest Hotel", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "Home Alone", IsRightAnswer = false }
                    }
            },
            new QuizItem()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                 Question = "Which film was directed by Andrew Adamson?",
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "Up", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "Back to the future", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "Cast Away", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "Shrek", IsRightAnswer = true }
                    }
            },
            new QuizItem()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                 Question = "In what year did Harry Potter and the Philosopher’s Stone release?",
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "2000", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "2001", IsRightAnswer = true },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "2002", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "2003", IsRightAnswer = false }
                    }
            },
            new QuizItem()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                 Question = "Who directed A Clockwork Orange?",
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "Pete Docter", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "Morten Tyldum", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "Stanley Kubrick", IsRightAnswer = true },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "James Cameron", IsRightAnswer = false }
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
