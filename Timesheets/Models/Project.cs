using System;
using Realms;

namespace Timesheets.Models
{
    public class Project : RealmObject
    {
        [PrimaryKey]
        public string AppId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
         
    }
}
