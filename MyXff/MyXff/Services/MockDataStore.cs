using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyXff.Models;

namespace MyXff.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;
        private static readonly List<String> mockCourses;
        private static readonly List<Note> mockNotes;


        static MockDataStore() {
            mockCourses = new List<string> { "Introduction to Xamarin", "First App", " Android App Data SQLite" };
            mockNotes = new List<Note> {
                new Note{ Id="0", Heading="Heading 1: UI code", Text="Xamarin Forms", Course="Course1:Xamarin Course"},
                  new Note{ Id="1", Heading="Heading 2: UI code", Text="Xamarin Forms", Course="Course2:Xamarin Course"},
                  new Note{ Id="2", Heading="Heading 3: UI code", Text="Xamarin Forms", Course="Course3 :Xamarin Course"}
            };
        }




        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }

            



        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

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