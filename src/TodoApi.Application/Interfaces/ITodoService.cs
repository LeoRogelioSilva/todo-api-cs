using TodoApi.Application.DTOs;

namespace TodoApi.Application.Interfaces;

public interface ITodoService
{
    Task<List<TodoResponse>> GetAllAsync();
    Task<TodoResponse?> GetByIdAsync(Guid id);
    Task<TodoResponse> CreateAsync(CreateTodoRequest request);
    Task<TodoResponse?> UpdateAsync(Guid id, UpdateTodoRequest request);
}