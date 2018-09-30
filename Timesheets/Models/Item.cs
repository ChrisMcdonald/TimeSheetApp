using System;
using Realms;
namespace Timesheets.Models
{
    public class Item : RealmObject
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
}