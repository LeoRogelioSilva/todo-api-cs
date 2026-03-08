using TodoApi.Application.DTOs;
using TodoApi.Application.Interfaces;
using TodoApi.Domain.Entities;

namespace TodoApi.Application.Services;

public class TodoService : ITodoService
{
    private readonly ITodoRepository _todoRepository;

    public TodoService(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public async Task<List<TodoResponse>> GetAllAsync()
    {
        var items = await _todoRepository.GetAllAsync();

        return items.Select(MapToResponse).ToList();
    }

    public async Task<TodoResponse?> GetByIdAsync(Guid id)
    {
        var item = await _todoRepository.GetByIdAsync(id);

        return item is null ? null : MapToResponse(item);
    }

    public async Task<TodoResponse> CreateAsync(CreateTodoRequest request)
    {
        var todo = new TodoItem(request.Title);

        await _todoRepository.AddAsync(todo);

        return MapToResponse(todo);
    }

    private static TodoResponse MapToResponse(TodoItem item)
    {
        return new TodoResponse
        {
            Id = item.Id,
            Title = item.Title,
            IsDone = item.IsDone,
            CreatedAt = item.CreatedAt
        };
    }
}