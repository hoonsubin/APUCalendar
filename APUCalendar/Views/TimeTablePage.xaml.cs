using System;
using System.Collections.Generic;
using APUCalendar.ViewModels;

using Xamarin.Forms;

namespace APUCalendar.Views
{
    public partial class TimeTablePage : ContentPage
    {
        //initialize view model
        TimeTableViewModel viewModel;

        public TimeTablePage()
        {
            InitializeComponent();
            //set the binding context for the front-end part
            BindingContext = viewModel = new TimeTableViewModel();
        }
    }
}
