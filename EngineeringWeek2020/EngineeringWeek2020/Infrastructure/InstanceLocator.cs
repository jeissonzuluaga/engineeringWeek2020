
namespace EngineeringWeek2020.Infrastructure
{
    using ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region constructor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
