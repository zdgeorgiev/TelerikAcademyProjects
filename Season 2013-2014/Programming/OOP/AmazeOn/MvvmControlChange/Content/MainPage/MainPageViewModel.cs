﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using AmazeOn.Models;

namespace AmazeOn.Content
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainPageViewModel : ViewModelBase
    {
        public static AmazeOn.Models.Store magazin = AmazeOn.Models.Store.InitializeStore();
        
        public MainPageViewModel()
        {
        }
    }
}