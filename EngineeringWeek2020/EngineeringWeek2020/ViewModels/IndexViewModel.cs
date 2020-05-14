
namespace EngineeringWeek2020.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Forms;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;
    using System.ComponentModel;
    using Views;

    public class IndexViewModel : BaseViewModel
    {
        #region Attributes
        private bool isEnabled;
        #endregion

        #region Properties
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Constructors
        public IndexViewModel()
        {
            //Aquí se le pueden dar valores iniciales a controles como un switch o un Entry
            this.IsEnabled = true;
        }
        #endregion

        #region Commands
        public ICommand SignUpCommand
        {
            get
            {
                return new RelayCommand(SignUp);
            }
        }
        private async void SignUp()
        {
            //A través de este método se pueden validar datos de ingreso o validar que el usuario realice
            //una acción obligatoria. Por ejm:
            //if (string .IsNullOrEmpty(this.Email))
            //{
            //    await Application.Current.MainPage.DisplayAlert(
            //        "Título del mensaje - ERROR",
            //        ";Mensaje - Debe digitar un correo electrónico",
            //        "Como se va a llamar el botón - Aceptar");
            //    return;
            //}

            MainViewModel.GetInstance().SignUp = new SignUpViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }

        public ICommand RegistrationCommand
        {
            get
            {
                return new RelayCommand(Registration);
            }
        }


        private async void Registration()
        {
            MainViewModel.GetInstance().Registration = new RegistrationViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new RegistrationPage());
        }
        #endregion
    }
}
