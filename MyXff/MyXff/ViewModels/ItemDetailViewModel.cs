using System;
using System.Collections.Generic;
using MyXff.Models;

namespace MyXff.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {

        public Note note { get; set; }
        public IList<String> CourseList { get; set; }

        public String NoteHeading {
            get { return note.Heading; }
            set { note.Heading = value;
                OnPropertyChanged();
            }
        }










        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            InitializeCourseList();
            note = new Note { Heading = "heading note view model-3-4-2020" , Text= "Note text view model",
                Course=CourseList[0]
            };

        }





         void InitializeCourseList() {

            var dataStore = new List<String> { "Str 1", "Str 2", "str3" };
            CourseList = dataStore;
            

        }

    }
}
