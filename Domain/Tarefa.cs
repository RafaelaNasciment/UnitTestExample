namespace Domain
{
    public class Tarefa
    {
        public Tarefa(
            string title,
            string description,
            DateTime expirationDate,
            int? priority,
            string[] labels)
        {
            Title = title;
            Description = description;
            ExpirationDate = expirationDate;
            Priority = priority;
            Labels = labels;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int? Priority { get; set; }
        public string[] Labels { get; set; }
    }
}