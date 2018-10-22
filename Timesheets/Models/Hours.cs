using System;
using Realms;

namespace Timesheets.Models
{
    public class Hours : RealmObject
    {
        [PrimaryKey]
        public string AppId { get; set; } = Guid.NewGuid().ToString();
        public double Hour { get; set; }
        public string Description { get; set; }
    }
  
}
