﻿using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Timesheets.Models;
using Timesheets.Views;
using Xamarin.Forms;

namespace Timesheets.ViewModels
{
    public class CalendarViewModel : BaseViewModel
    {

        private DateTime? _date;
        public DateTime? Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }

        private ObservableCollection<XamForms.Controls.SpecialDate> attendances;
        public ObservableCollection<XamForms.Controls.SpecialDate> Attendances
        {
            get { return attendances; }
            set { attendances = value; OnPropertyChanged(nameof(Attendances)); }
        }

        public ICommand DateChosen
        {
            get
            {
                return new Command((obj) => {
                    string Date = obj.ToString();
                    if (Date == null)
                        return;

                    Application.Current.MainPage.Navigation.PushAsync(new DayPage(new  DayViewModel(Date)));

                    //Application.Current.MainPage.Navigation.PushAsync(new ItemsPage());
                });
            }
        }

    
}
}
