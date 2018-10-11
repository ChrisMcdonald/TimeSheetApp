using System;
using Timesheets.Models;

namespace Timesheets.ViewModels
{
    public class DayViewModel : BaseViewModel
    {
        public DayViewModel(Day day = null)
        {
            Title = day?.Date.ToString();
            Day = day;
        }
        public Day Day{ get; set;}
    }
}
