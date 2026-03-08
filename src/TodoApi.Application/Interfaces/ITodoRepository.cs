using TodoApi.Domain.Entities;

namespace TodoApi.Application.Interfaces;

public interface ITodoRepository
{
    Task<List<TodoItem>> GetAllAsync();
    Task<TodoItem?> GetByIdAsync(Guid id);
    Task AddAsync(TodoItem todo);
    Task<bool> UpdateAsync(TodoItem todo);
}