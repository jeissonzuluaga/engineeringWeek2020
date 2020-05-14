
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
    using ViewModels;
    public class RegistrationViewModel : BaseViewModel
    {
        #region Attributes
        private string name;
        private string lastName;
        private string identif;
        private string idUCC;
        private string email;
        private string cel;
        private bool isEnabled;
        #endregion

        #region Properties
        public string Name
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { SetValue(ref this.lastName, value); }
        }
        public string Identif
        {
            get { return this.identif; }
            set { SetValue(ref this.identif, value); }
        }
        public string IdUCC
        {
            get { return this.idUCC; }
            set { SetValue(ref this.idUCC, value); }
        }
        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        public string Cel
        {
            get { return this.cel; }
            set { SetValue(ref this.cel, value); }
        }
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Constructors
        public RegistrationViewModel()
        {
            //Aquí se le pueden dar valores iniciales a controles como un switch, un Entry o un Button
            this.IsEnabled = true;
        }
        #endregion

        #region Commands
        public ICommand SubmitRCommand
        {
            get
            {
                return new RelayCommand(SubmitR);
            }
        }
        private async void SubmitR()
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
            if (string.IsNullOrEmpty(this.Name))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Nombre no aceptado.",
                    "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.LastName))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Apellido no aceptado.",
                    "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.Identif))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Número de identificación no aceptado.",
                    "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.IdUCC))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Id institucional UCC no aceptado.",
                    "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email no aceptado.",
                    "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.Cel))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Número de teléfono no aceptado.",
                    "Aceptar");
                return;
            }

            await Application.Current.MainPage.DisplayAlert(
                "Notificación",
                "Registro Exitoso.",
                "Aceptar");

            this.Name = string.Empty;
            this.LastName = string.Empty;
            this.Identif = string.Empty;
            this.IdUCC = string.Empty;
            this.Email = string.Empty;
            this.Cel = string.Empty;

            return;

            #endregion

        }
    }
}
