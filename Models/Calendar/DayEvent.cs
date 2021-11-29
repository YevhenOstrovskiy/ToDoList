using ToDoList.Models;
namespace ToDoList.Data.Calendar
{
    public class DayEvent
    {


        public int Id { get; set; }
        public DateTime EventDate { get; set; } = new DateTime(1900, 1, 1);
        public DateTime FromDate { get; set; } = DateTime.Today;
        public DateTime ToDate { get; set; } = new DateTime(1900, 1, 1);
        public string? DateValue { get; set; } = new string ("");
        public string Note { get; set; }
        public string DayName { get; set; } = new string ("");
        

        
    }
}
