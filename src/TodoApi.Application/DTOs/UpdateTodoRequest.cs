namespace TodoApi.Application.DTOs;

public class UpdateTodoRequest
{
    public string? Title { get; set; }
    public bool? IsDone { get; set; }
}
