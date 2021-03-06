﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using APUCalendar.Models;

namespace APUCalendar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            //populate the new item page with these values
            Item = new Item
            {
                EventName = "New event name",
                StartDateTime = DateTime.Now.ToString("yyyy/MM/dd")
            };

            //bind the front-end conponents with this code
            BindingContext = this;
        }


        async void Save_Clicked(object sender, EventArgs e)
        {
            //this part is needed to get rid of the time and only show the date of the item
            //this will pass the value that is going to be displyed on the list
            Item.StartDateTime = startDateNew.Date.ToString("yyyy/MM/dd");

            //send this values to the subscriber; ItemsViewModel
            MessagingCenter.Send(this, "AddItem", Item);
            //dismiss the current page go back to the previous one
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            //dismiss the current page go back to the previous one
            await Navigation.PopModalAsync();
        }
    }
}