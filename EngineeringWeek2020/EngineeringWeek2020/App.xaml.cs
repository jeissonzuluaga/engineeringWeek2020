namespace EngineeringWeek2020
{
    using Views;
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    public partial class App : Application
    {
        #region Constructor
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new IndexPage());
        }
        #endregion

        #region Methods
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        #endregion
    }
}
