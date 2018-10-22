using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamForms.Controls;
using Xamarin.Forms.Xaml;


namespace Timesheets.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
    {
        Calendar _calendar;
        //public string SelectedDate
        //{
        //    get;
        //    set;
        //}
        public CalendarPage()
        {
            InitializeComponent();
            //_calendar = new Calendar
            //{
            //    BorderColor = Color.Gray,
            //    BorderWidth = 3,
            //    BackgroundColor = Color.Gray,
            //    StartDay = DayOfWeek.Sunday,
            //    StartDate = DateTime.Now
            //};




        }

       
    }
}
