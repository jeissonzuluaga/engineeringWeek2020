
namespace EngineeringWeek2020.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Text;
    
    // Esta clase nos permite refrescar un objeto cuando sus valores son modificados en tiempo de ejecución
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged; 
        #endregion
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetValue<T>(ref T backingField, T value, [CallerMemberName] string propertyName = null)
        {
            if(EqualityComparer<T>.Default.Equals(backingField, value))
            {
                return;
            }

            backingField = value;
            OnPropertyChanged(propertyName);
        }
    }
}
