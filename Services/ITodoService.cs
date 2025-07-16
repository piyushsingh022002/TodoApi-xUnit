using TodoApi.Models;
using System.Collections.Generic;

namespace TodoApi.Services;
public interface ITodoService
{
    List<TodoItem> GetAll();
    TodoItem GetById(int id);
    void Add(TodoItem item);
    bool Delete(int id);
}
