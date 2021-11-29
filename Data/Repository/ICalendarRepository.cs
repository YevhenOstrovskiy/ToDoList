using ToDoList.Data.Calendar;

namespace ToDoList.Data.Repository
{
    public interface ICalendarRepository
    {
        IEnumerable<DayEvent> GetAllEvents();
        void SaveOrUpdate (DateTime dayEvent);
        DayEvent GetEvent (DateTime eventDate);
        void Delete (int id);
        List<DayEvent> GetEvents(DateTime fromDate, DateTime toDate);
    }
}
