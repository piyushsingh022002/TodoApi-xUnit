using TodoApi.Models;

namespace TodoApi.Services;
public class TodoService : ITodoService
{
    private readonly List<TodoItem> _items = new();

    public List<TodoItem> GetAll() => _items;

    public TodoItem GetById(int id) => _items.FirstOrDefault(i => i.Id == id);

    public void Add(TodoItem item) => _items.Add(item);

    public bool Delete(int id)
    {
        var item = GetById(id);
        if (item == null) return false;
        _items.Remove(item);
        return true;
    }
}
