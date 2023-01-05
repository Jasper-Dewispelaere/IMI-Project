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
                 Question = "In what year did 'The Shining' release?", 
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
                 Question = "Who directed 'Titanic'?",
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
                 Question = "In what year did 'Harry Potter and the Philosopher’s Stone' release?",
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
                 Question = "Who directed 'A Clockwork Orange'?",
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "Pete Docter", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "Morten Tyldum", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "Stanley Kubrick", IsRightAnswer = true },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "James Cameron", IsRightAnswer = false }
                    }
            },
            new QuizItem()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                 Question = "In what year did 'Home Alone' Release?",
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "1990", IsRightAnswer = true },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "1992", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "1995", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "2000", IsRightAnswer = false }
                    }
            },
            new QuizItem()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                 Question = "Which actor played Joker in the film 'Joker'?",
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "Jack Nicholson", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "Joaquin Phoenix", IsRightAnswer = true },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "Heath Ledger", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "Jared Leto", IsRightAnswer = false }
                    }
            },
            new QuizItem()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                 Question = "Which Marvel Superhero did Benedict Cumberbatch play?",
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "Iron Man", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "Captian America", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "Ant Man", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "Doctor Strange", IsRightAnswer = true }
                    }
            },
            new QuizItem()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                 Question = "How is the sequel to 'Her' called?",
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "Her doesn't have a sequel", IsRightAnswer = true },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "Him", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "They", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "It", IsRightAnswer = false }
                    }
            },
            new QuizItem()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                 Question = "Which film was NOT directed by James Cameron",
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "Titanic", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "Jurassic Park", IsRightAnswer = true },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "Avatar", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "The Terminator", IsRightAnswer = false }
                    }
            },
            new QuizItem()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                 Question = "Where does 'The Shining' take place?",
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "Amusement Park", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "Haunted House", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "Hotel", IsRightAnswer = true },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "Boat", IsRightAnswer = false }
                    }
            },
            new QuizItem()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                 Question = "Which of these actors DIDN'T appear in 'The French Dispatch'",
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "Adrien Brody", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "Bill Murray", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "Owen Wilson", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "Jack Black", IsRightAnswer = true }
                    }
            },
            new QuizItem()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                 Question = "In what year did '1917' release?",
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "2019", IsRightAnswer = true },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "2020", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "1917", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "2021", IsRightAnswer = false }
                    }
            },
            new QuizItem()
            {
                 Id = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                 Question = "Which of these film ISN'T based on a true story?",
                 Answers = new List<Answer>
                    {
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), PossibleAnswer = "1917", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), PossibleAnswer = "The Grand Budapest Hotel", IsRightAnswer = true },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), PossibleAnswer = "The Imitation Game", IsRightAnswer = false },
                        new Answer() { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), PossibleAnswer = "Titanic", IsRightAnswer = false }
                    }
            },
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
