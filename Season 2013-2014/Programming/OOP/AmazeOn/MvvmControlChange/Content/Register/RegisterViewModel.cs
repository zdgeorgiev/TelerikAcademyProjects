﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using AmazeOn.Models;
using AmazeOn.Content;
using System.Windows.Controls;
using System.Windows;

namespace AmazeOn.Content
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class RegisterViewModel : ViewModelBase
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public RegisterViewModel()
        {
            goToStore = new RelayCommand(() => GoToStore());
            Register = new RelayCommand(() => register());
        }

        public RelayCommand goToStore
        {
            get;
            private set;
        }

        public RelayCommand Register
        {
            get;
            private set;
        }

        private void GoToStore()
        {
            var msg = new GoToPageMessage() { PageName = "StoreView" };
            Messenger.Default.Send<GoToPageMessage>(msg);
        }

        private void register()
        {
            try
            {
                User toRegister = MainPageViewModel.magazin.RegisterUser(Username, Password, Address);

                if (toRegister != null)
                {
                    MainPageViewModel.magazin.CurrentUser = toRegister;
                    System.Windows.MessageBox.Show(string.Format("{0} successfully registered!", Username));
                    var msg = new GoToPageMessage() { PageName = "StoreView" };
                    Messenger.Default.Send<GoToPageMessage>(msg);
                }
                else
                {
                    throw new RegisterException("An error occured while trying to register the user");
                }
            }
            catch (RegisterException a)
            {
                System.Windows.MessageBox.Show(a.Message);
            }
        }
    }
}