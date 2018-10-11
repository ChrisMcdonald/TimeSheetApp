using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Models;
using Realms;

namespace Timesheets.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        protected Realm RealmInstance;

        List<Item> items;

        public MockDataStore()
        {
            this.RealmInstance = Realm.GetInstance();
            items = new List<Item>();

//            int month = DateTime.Now.Month;
//            int year = DateTime.Now.Year;
//            int days = DateTime.DaysInMonth(year,month);
//           
//            for (int day = 1; day < days + 1 ; day++)
//            {
//                DateTime dateTime = new DateTime(year, month, day);
//                Item item = new Item { Id = Guid.NewGuid().ToString(), Text = dateTime.ToLongDateString(), Description = "This is an item description." };
//                //    new Item      { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." },
//
//                items.Add(item);
//            }
            //var mockItems = new List<Item>
            //{
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
            //    new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." },
            //};

            //foreach (var item in mockItems)
            //{
            //    items.Add(item);
            //}
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            //items.Add(item);
            RealmInstance.Write(() =>
            {
                RealmInstance.Add(item);
            });
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            RealmInstance.Write(() =>
            {
                RealmInstance.Add(item, update: true);
            });

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}