using AspNetCoreTodo.Models;
namespace AspNetCoreTodo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Work with Something",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };

            var item2 = new TodoItem
            {
                Title = "Create Something",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };

            return Task.FromResult<TodoItem[]>(new[] {item1, item2});
        }
    }
}
