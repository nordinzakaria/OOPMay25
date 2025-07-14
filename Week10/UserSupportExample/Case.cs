using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSupport
{
    internal class Case
    {
        public static int CurrIdNum;
        public string Title { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public Priority Priority { get; set; }
        public DateTime Received {  get; set; }
        public DateTime Resolved { get; set; }
        public DateTime Canceled { get; set; }
        public Status Status { get; set; }

        public Customer Customer { get; set; }
        public Staff Staff { get; set; }


        public Case() 
        {
            Id = "CASE" + CurrIdNum;
            CurrIdNum++;
        }
        public Case(string title, string description, Priority priority)
        {
            Title = title; Description = description;
            Priority = priority;
        }

        public string GetText()
        {
            return Title + "\n" + Description;
        }

        public string GetHTML()
        {
            return "<html>" + Title + "\n" + Description;
        }
    }
}
