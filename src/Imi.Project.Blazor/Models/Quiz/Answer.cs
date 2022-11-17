namespace Imi.Project.Blazor.Models.Quiz
{
    public class Answer
    {
        public Guid Id { get; set; }
        public string PossibleAnswer { get; set; }
        public bool IsRightAnswer { get; set; }
    }
}
