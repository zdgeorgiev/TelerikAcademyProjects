﻿namespace CodeFormating
{
    using System;
    using System.Text;

    internal class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date
        {
            get { return this.date; }
            private set { this.date = value; }
        }

        public string Title
        {
            get { return this.title; }
            private set { this.title = value; }
        }

        public string Location
        {
            get { return this.location; }
            private set { this.location = value; }
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int date = this.Date.CompareTo(other.date);
            int title = this.Title.CompareTo(other.title);
            int location = this.Location.CompareTo(other.location);

            if (date == 0)
            {
                if (title == 0)
                {
                    return location;
                }
                else
                {
                    return title;
                }
            }
            else
            {
                return date;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Date.ToString("yyyy-MM-ddTHH:mm:ss"));
            result.Append(" | " + this.Title);

            if (this.Location != null && this.Location != string.Empty)
            {
                result.Append(" | " + this.Location);
            }

            return result.ToString();
        }
    }
}
