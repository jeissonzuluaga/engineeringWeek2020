
namespace EngineeringWeek2020.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class MainViewModel
    {
        #region ViewModels
        public IndexViewModel Index
        {
            get;
            set;
        }

        public SignUpViewModel SignUp
        {
            get;
            set;
        }

        public RegistrationViewModel Registration
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Index = new IndexViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
