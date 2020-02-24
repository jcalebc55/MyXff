using System;

using MyXff.Models;

namespace MyXff.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
#pragma warning disable IDE1006 // Naming Styles
        public Note note { get; set; }
#pragma warning restore IDE1006 // Naming Styles
        public ItemDetailViewModel(Item item = null)
        {
            Title = note?.Text;
            note = new Note { Heading = "heading note view model" , Text= "Note text view model"};
        }
    }
}
