namespace CodeFormating
{
    using System;
    using System.Text;

    internal static class Messages
    {
        private static StringBuilder result = new StringBuilder();

        public static void EventAdded()
        {
            result.Append("Event added\n");
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                result.AppendFormat("{0} events deleted\n", x);
            }
        }

        public static void NoEventsFound()
        {
            result.Append("No events found\n");
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                result.Append(eventToPrint + "\n");
            }
        }
    }
}
