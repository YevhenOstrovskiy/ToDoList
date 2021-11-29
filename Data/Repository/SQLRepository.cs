using ToDoList.Models;

namespace ToDoList.Data.Repository
{
    public class SQLRepository : IRepository
    {
        private readonly DB _context;

        public SQLRepository(DB context)
        {
           _context = context;
        }

        public void AddTodo(string todoName)
        {
            TodoItem newItem = new TodoItem()
            {
                Title = todoName,
                IsDone = false
            };
            _context.TodoItems.Add(newItem);
            _context.SaveChanges();
            
        }

        public void DeleteItem(int id)
        {
            var deletedItem = _context.TodoItems.Find(id);
            if (deletedItem != null)
            {
                _context.TodoItems.Remove(deletedItem);
                _context.SaveChanges();
            }
        }

        public IEnumerable<TodoItem> GetAllItems()
        {
            return _context.TodoItems;
        }

        public void ValueChanged(TodoItem changedItem)
        {
            var item = _context.TodoItems.Attach(changedItem);
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void SaveOrUpdate(TodoItem newEvent)
        {
            var item = _context.TodoItems.Attach(newEvent);
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }


        //public void SaveOrUpdate(DateTime dayEvent)
        //{
        //    //var dateItem = _context.TodoItems.Find(dayEvent);
        //    TodoItem newItem = new TodoItem()
        //    {
        //        EventDate = dayEvent
        //    };
        //    _context.TodoItems.Add(newItem);
        //    _context.SaveChanges();
        //}
    }
}
