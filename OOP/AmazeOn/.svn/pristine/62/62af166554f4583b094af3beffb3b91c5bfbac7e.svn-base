using GalaSoft.MvvmLight;
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
    public class LoginViewModel : ViewModelBase
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(() => ExecuteLogin());
            goToStore = new RelayCommand(() => GoToStore());
            Register = new RelayCommand(() => register());
        }
        
        public RelayCommand LoginCommand
        {
            get;
            private set;
        }

        public RelayCommand Register
        {
            get;
            private set;
        }

        private void ExecuteLogin()
        {
            try
            {
                User currentUser = MainPageViewModel.magazin.FindUser(this.Username, this.Password);

                if (currentUser != null)
                {
                    MainPageViewModel.magazin.CurrentUser = currentUser;
                    if (!MainPageViewModel.magazin.CurrentUser.IsAdmin)
                    {
                        var msg = new GoToPageMessage() { PageName = "StoreView" };
                        Messenger.Default.Send<GoToPageMessage>(msg);
                    }
                    else
                    {
                        var msg = new GoToPageMessage() { PageName = "AdminLogView" };
                        Messenger.Default.Send<GoToPageMessage>(msg);
                    }

                }
            }
            catch (LoginException a)
            {
                
                System.Windows.MessageBox.Show(a.Message);
            }

            //System.Windows.MessageBox.Show("Navigate to Page 2!");            
        }

        public RelayCommand goToStore
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
            var msg = new GoToPageMessage() { PageName = "RegisterView" };
            Messenger.Default.Send<GoToPageMessage>(msg);
        }
    }    
}