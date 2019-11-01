using System;

namespace AccessModifiers.Private
{
    public class CalendarEvent : ICalendarItem
    {
        public int CalendarId { get; set; }
        public string Name { get; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }

        // Implementing class cannot access private interface members
        // ICalendarItem.DefaultType = CalendarItemType.Event;

        public CalendarItemType ItemType { get => CalendarItemType.Event; }

        public CalendarEvent(string name, DateTime date)
        {
            Name = name;
            StartTime = date.Date + DateTime.Now.TimeOfDay;
        }
    }
}
