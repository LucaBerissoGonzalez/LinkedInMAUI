﻿using LinkedIn.Views;
namespace LinkedIn
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginView());
        }
    }
}
