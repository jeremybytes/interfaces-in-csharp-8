using AccessModifiers.Private;
using AccessModifiers.Protected;
using AccessModifiers.Public;
using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Private Members
            ICalendarItem calendarEvent = new CalendarEvent("Dwayne's Graduation", DateTime.Today.AddMonths(1));
            DisplayCalendarItem(calendarEvent);

            ICalendarItem reminder = new CalendarReminder("Send birthday card to Penny", new TimeSpan(5, 30, 0));
            DisplayCalendarItem(reminder);


            // Protected Members
            IInventoryController controller = new FakeInventoryController();
            var item = new InventoryItem(7);
            controller.PushInventoryItem(item);
            // Protected members cannot be accessed through
            // through the implementation.
            // Protected members may only be useful in interfaces
            // heirarchies since they cannot be accessed through
            // implementers.
            // controller.PullInventoryItem(7);


            // Public Members
            // Public members are accessible through implementers
            ICustomerReader reader = new FakeCustomerReader();
            var customerList = reader.GetCustomers();
            DisplayCustomerList(customerList);

        }

        private static void DisplayCustomerList(System.Collections.Generic.IReadOnlyCollection<Customer> customerList)
        {
            Console.WriteLine("=======================");
            int count = 1;
            foreach (var customer in customerList)
            {
                Console.WriteLine($"Item #{count}");
                Console.WriteLine($"Customer Id: {customer.Id}");
                Console.WriteLine($"Given Name: {customer.GivenName}");
                Console.WriteLine($"Family Name: {customer.FamilyName}");
                Console.WriteLine("---");
                count++;
            }
            Console.WriteLine("=======================");
        }

        private static void DisplayCalendarItem(ICalendarItem calendarEvent)
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Calendar Item");
            Console.WriteLine($"Name: {calendarEvent.Name}");
            Console.WriteLine($"Start Time: {calendarEvent.StartTime:s}");
            Console.WriteLine($"Type: {calendarEvent.ItemType}");
            Console.WriteLine($"Type: {calendarEvent.ItemTypeDescription}");
            Console.WriteLine("=======================");
        }
    }
}
