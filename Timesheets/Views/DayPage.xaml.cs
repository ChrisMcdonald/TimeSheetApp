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
            string date = DateTime.Now.ToString("MM/dd/yyyy"); 
            viewModel = new DayViewModel(date);
            BindingContext = viewModel;
        }
    }
}
