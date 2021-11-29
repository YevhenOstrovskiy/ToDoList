using ToDoList.Data.Calendar;

namespace ToDoList.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime EventDate { get; set; } = DateTime.MinValue;
        




    }
}
