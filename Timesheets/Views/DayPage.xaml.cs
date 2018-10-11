using System;
using System.Collections.Generic;
using Timesheets.Models;
using Timesheets.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Timesheets.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DayPage : ContentPage
    {
        DayViewModel viewModel;

        public DayPage(DayViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }

        public DayPage()
        {
            var day = new Day
            {
                Date = DateTime.Now,
                Description = "New Day"
                
            }; 
            viewModel = new DayViewModel(day);
            BindingContext = viewModel;
        }
    }
}
