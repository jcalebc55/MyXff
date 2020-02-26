using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using MyXff.Models;
using MyXff.ViewModels;
using System.Collections.Generic;
using MyXff.Services;
using System.Threading.Tasks;

namespace MyXff.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
         
        public IList<String> CourseList { get; set; } 



        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            initializeData();


            BindingContext = viewModel;
            noteCourse.BindingContext = this;
        }

        

        public ItemDetailPage()
        {
            InitializeComponent();
            initializeData();

            viewModel = new ItemDetailViewModel();
            
            BindingContext = viewModel;
            noteCourse.BindingContext = this;
        }

        private void initializeData()

        {
         
            var dataStore = new List<String> {"Str 1" ,"Str 2","str3" } ;
            CourseList = dataStore;
        }
        private void Cancel_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Cancel option","Cancel was selected","Yes","No");

        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Save option", "Save was selected", "Yes", "No");
        }

      

        


    }
}