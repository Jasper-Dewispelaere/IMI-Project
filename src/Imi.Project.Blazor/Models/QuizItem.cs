namespace Imi.Project.Blazor.Models
{
    public class QuizItem
    {
        public Guid Id { get; set; }
        public string Question { get; set; }
        public virtual List<Answer> FalseAnswers { get; set; }
    }
}
