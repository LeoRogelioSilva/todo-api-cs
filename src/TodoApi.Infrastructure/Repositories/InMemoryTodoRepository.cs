using TodoApi.Application.Interfaces;
using TodoApi.Domain.Entities;

namespace TodoApi.Infrastructure.Repositories;

public class InMemoryTodoRepository : ITodoRepository
{
    private static readonly List<TodoItem> _items = new();

    public Task<List<TodoItem>> GetAllAsync()
    {
        return Task.FromResult(_items.ToList());
    }

    public Task<TodoItem?> GetByIdAsync(Guid id)
    {
        var item = _items.FirstOrDefault(x => x.Id == id);
        return Task.FromResult(item);
    }

    public Task AddAsync(TodoItem todo)
    {
        _items.Add(todo);
        return Task.CompletedTask;
    }
}