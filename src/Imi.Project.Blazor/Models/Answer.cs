namespace Imi.Project.Blazor.Models
{
    public class Answer
    {
        public Guid Id { get; set; }
        public string PossibleAnswer { get; set; }
        public bool IsRightAnswer { get; set; }
    }
}
