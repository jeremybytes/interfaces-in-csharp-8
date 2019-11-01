using System;

namespace AccessModifiers.Private
{
    public class CalendarReminder : ICalendarItem
    {
        public int CalendarId { get; set; }
        public string Name { get; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }

        public CalendarItemType ItemType { get => CalendarItemType.Reminder; }
        public string ItemTypeDescription { get => "REMINDER!"; }

        public CalendarReminder(string name, TimeSpan fromNow)
        {
            Name = name;
            StartTime = DateTime.Now + fromNow;
        }
    }
}
