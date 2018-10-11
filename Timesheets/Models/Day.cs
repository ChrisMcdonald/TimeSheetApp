using System;
using Realms;

namespace Timesheets.Models
{
    public class Day : RealmObject
    {
        [PrimaryKey]
        public int AppId { get; set; } 
        public DateTimeOffset Date { get; set; }
        public double Hours { get; set; }
        public string Description { get; set; }
        public int Project_id { get; set; }
        public int Invoice_id { get; set; }

        public string DateString()
        {
            //return Date.ToString("MMMM dd, yyyy");
            return Date.ToString("MMMM dd, yyyy");
        }
    }

   
}
