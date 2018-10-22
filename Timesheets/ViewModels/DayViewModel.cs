using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Realms;
using Timesheets.Models;
using Xamarin.Forms;

namespace Timesheets.ViewModels
{
    public class DayViewModel : BaseViewModel
    {
        private Day _currentDay;
        private Hours _newHours ;


        public Command SaveDayCommand { get; set; }

        public DayViewModel(string date)
        {
            SaveDayCommand = new Command(viewModel => SaveDay());
            Title = date.ToString();
            CurrentDay = _dataBase.All<Day>().Where(d => d.Date == date).FirstOrDefault();
            if (CurrentDay == null)
            {
                CurrentDay = new Day
                {
                    Date = date
                };
            }
            NewHours  = new Hours();
        }

        private void SaveDay()
        {
            Day day = CurrentDay;
            Hours hours = NewHours;

            _dataBase.Write(() => {
                day.Hours.Add(hours);

                _dataBase.Add(day); 
            });
            CurrentDay = _dataBase.All<Day>().Where(d => d.Date == day.Date).FirstOrDefault();
            NewHours = new Hours();

        }

        public  Day CurrentDay
        {
            get{
                return _currentDay;
            }
            set{
                _currentDay = value;
                OnPropertyChanged("CurrentDay");
            }
        }
        public Hours NewHours
        {
            get{
                return _newHours;
                }
            set {
                _newHours = value;
                OnPropertyChanged("NewHours");
            }
        }

    

    }
}
