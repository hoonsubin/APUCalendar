﻿using System;
using System.IO;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using APUCalendar.Views;
using APUCalendar.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace APUCalendar
{
    public partial class App : Application
    {

        static DataStore database;

        public App()
        {
            InitializeComponent();

            //the first page the app will enter in ius MainPage.xaml
            MainPage = new MainPage();
        }

        public static DataStore Database
        {
            get
            {
                if (database == null)
                {
                    database = new DataStore(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
