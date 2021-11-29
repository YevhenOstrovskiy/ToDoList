using ToDoList.Data.Calendar;
using ToDoList.Data.Repository;

namespace ToDoList.Data.Repository
{
    public class SQLCalendarRepository : ICalendarRepository
    {
        private readonly DB _context;

        public SQLCalendarRepository(DB context)
        {
            _context = context;
        }


        public void Delete(int id)
        {
            var deletedEvent = _context.DayEvents.Find(id);
            if (deletedEvent != null)
            {
                _context.DayEvents.Remove(deletedEvent);
                _context.SaveChanges();
            }
        }

        public IEnumerable<DayEvent> GetAllEvents()
        {
            return _context.DayEvents;
        }

        public DayEvent GetEvent(DateTime eventDate)
        {
             
            throw new NotImplementedException();
            //GetEvent
        }

        public List<DayEvent> GetEvents(DateTime fromDate, DateTime toDate)
        {
            // string SQL = string Format fromDate and ToDate
            List<DayEvent> dayEvents = new List<DayEvent>();
            return dayEvents;
        }

        public void SaveOrUpdate(DateTime dayEvent)
        {
            DayEvent newEvent = new DayEvent()
            {
                EventDate = dayEvent
            };
            _context.DayEvents.Add(newEvent);
            _context.SaveChanges();
        }
    }
}
