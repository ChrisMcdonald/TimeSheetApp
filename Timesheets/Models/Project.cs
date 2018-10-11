using System;
using Realms;

namespace Timesheets.Models
{
    public class Project : RealmObject
    {
        [PrimaryKey]
        public int AppId { get; set; }
        public string Name { get; set; }
         
    }
}
