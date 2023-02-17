

namespace TestMySkills
{
    public class Project
    {
        public int Id { get; set; }
        public string? ProjectName { get; set; }
        public string? CustomerName { get; set; }
        public string? PerformingName { get; set; }
        public Person? Person { get; set; }
        public Person? leaderProject { get; set; }
        public Person? ExecutorsProject { get; set; }
        public DateTime ProjectStart { get; set; }
        public DateTime ProjectEnd { get; set; }
        public int Priority { get; set; }
    }
}
