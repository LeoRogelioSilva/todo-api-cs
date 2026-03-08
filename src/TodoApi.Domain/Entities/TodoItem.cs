namespace TodoApi.Domain.Entities;

public class TodoItem
{
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public bool IsDone { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public TodoItem(string title)
    {
        Id = Guid.NewGuid();
        Title = title;
        IsDone = false;
        CreatedAt = DateTime.UtcNow;
    }

    public void MarkAsDone()
    {
        IsDone = true;
    }
}