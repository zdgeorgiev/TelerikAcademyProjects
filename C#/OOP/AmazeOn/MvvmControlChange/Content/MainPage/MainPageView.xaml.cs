﻿using System.Windows;
using AmazeOn.ViewModel;
using GalaSoft.MvvmLight.Messaging;
using AmazeOn.Content;

namespace AmazeOn.Content
{
    /// <summary>
    /// Description for MainPageView.
    /// </summary>
    public partial class MainPageView : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainPageView class.
        /// </summary>
        public MainPageView()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();

            Messenger.Default.Register<GoToPageMessage>
                (
                    this,
                    (action) => ReceiveMessage(action)
                );
            this.contentControl1.Content = this.StoreView;
        }

        private CartView _CartView;
        private CartView CartView
        {
            get
            {
                if (_CartView == null)
                    _CartView = new CartView();
                return _CartView;
            }
        }

        private StoreView _StoreView;
        private StoreView StoreView
        {
            get
            {
                if (_StoreView == null)
                    _StoreView = new StoreView();
                return _StoreView;
            }
        }

        private LoginView _LoginView;
        private LoginView LoginView
        {
            get
            {
                if (_LoginView == null)
                    _LoginView = new LoginView();
                return _LoginView;
            }
        }

        private RegisterView _RegisterView;
        private RegisterView RegisterView
        {
            get
            {
                if (_RegisterView == null)
                    _RegisterView = new RegisterView();
                return _RegisterView;
            }
        }

        private AdminLogView _AdminLogView;
        private AdminLogView AdminLogView
        {
            get
            {
                if (_AdminLogView == null)
                    _AdminLogView = new AdminLogView();
                return _AdminLogView;
            }
        }

        private object ReceiveMessage(GoToPageMessage action)
        {
            //this.contentControl1.Content = this.LoginAsView;
            //this shows what pagename property is!!
            switch (action.PageName)
            {                
                case "CartView":
                    if (this.contentControl1.Content != this.CartView)
                        this.contentControl1.Content = this.CartView;
                    break;
                case "LoginView":
                    if (this.contentControl1.Content != this.LoginView)
                        this.contentControl1.Content = this.LoginView;
                    break;                
                case "StoreView":
                    if (this.contentControl1.Content != this.StoreView)
                        this.contentControl1.Content = this.StoreView;
                    break;
                case "RegisterView":
                    if (this.contentControl1.Content != this.RegisterView)
                        this.contentControl1.Content = this.RegisterView;
                    break;
                case "AdminLogView":
                    if (this.contentControl1.Content != this.AdminLogView)
                        this.contentControl1.Content = this.AdminLogView;
                    break;
                default:
                    break;
            }

//            string testII = action.PageName.ToString();
//           System.Windows.MessageBox.Show("You were successful switching to " + testII + ".");

            return null;
        }
    }
}