namespace ApiService.Entities;

public enum TaskPriority
{
    Low =1,
    Medium = 2,
    Hight =3
}

public enum TaskItemStatus
{
    Todo = 1,
    InProcess = 2,
    InReview = 3,
    Done = 4
}

public class TaskItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; } = TaskPriority.Medium;
    public TaskItemStatus Status { get; set; } = TaskItemStatus.Todo;
    public DateTime? DueDate { get; set; }
    public Guid ProjectId { get; set; }
    public Guid? AssigneeId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}