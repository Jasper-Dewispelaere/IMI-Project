namespace Imi.Project.Blazor.Models.Quiz
{
    public class QuizItem
    {
        public Guid Id { get; set; }
        public string Question { get; set; }
        public virtual List<Answer> Answers { get; set; }
    }
}
