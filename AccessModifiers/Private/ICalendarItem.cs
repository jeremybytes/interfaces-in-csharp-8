using System;

namespace AccessModifiers.Private
{
    public enum CalendarItemType
    {
        Unspecified,
        Event,
        Meeting,
        Reminder,
    }

    public interface ICalendarItem
    {
        public int CalendarId { get; }
        public string Name { get; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }

        // Private abstract members not allowed
        // private CalendarItemType DefaultType { get; }

        // Private members must have default implementation
        private CalendarItemType DefaultType { get => CalendarItemType.Unspecified; }

        // Private members cannot be accessed outside
        // of the interface, so they are useful only for
        // default implementations inside the interface.
        public CalendarItemType ItemType { get => DefaultType; }

        public string ItemTypeDescription
        {
            get
            {
                switch (ItemType)
                {
                    case CalendarItemType.Unspecified:
                        return ItemType.ToString();
                    default:
                        return $"Calendar {ItemType.ToString()}";
                }
            }
        }
    }
}
