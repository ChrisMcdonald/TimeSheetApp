using System;
using System.Collections.Generic;
using Realms;

namespace Timesheets.Models
{
    public class Day : RealmObject
    {
        [PrimaryKey]
        public string AppId { get; set; } = Guid.NewGuid().ToString();
        public string Date { get; set; }     
        public int Project_id { get; set; }
        public int Invoice_id { get; set; }
        public IList<Hours> Hours { get; }
       
    }

   
}
