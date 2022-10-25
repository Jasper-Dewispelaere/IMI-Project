namespace Imi.Project.Blazor.Models
{
    public class Quiz
    {
        public Guid Id { get; set; }
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public virtual List<Answer> FalseAnswers { get; set; }
    }
}
