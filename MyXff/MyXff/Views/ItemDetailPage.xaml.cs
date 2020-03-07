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
         
       



        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            this.viewModel = viewModel;
            BindingContext = this.viewModel;
            
        }

        

        public ItemDetailPage()
        {
            InitializeComponent();
       

            viewModel = new ItemDetailViewModel();
            
            BindingContext = viewModel;
            
        }

       
        private void Cancel_Clicked(object sender, EventArgs e)
        {

            viewModel.NoteHeading="xxxxx";
            DisplayAlert("Cancel option","Cancel was selected","Yes","No");

        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Save option", "Save was selected", "Yes", "No");
        }

      

        


    }
}