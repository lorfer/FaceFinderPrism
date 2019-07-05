using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaceFinderPrism.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        private bool isRunning = false;
        private bool isNotRunning = true;

        public bool IsRunning
        {
            get
            {
                return isRunning;
            }
            set
            {
                //This is for reference to the Prop
                SetProperty(ref isRunning, value);
                IsNotRunning = !value;
            }
        }

        public bool IsNotRunning
        {
            get
            {
                return isNotRunning;
            }
            set
            {
                SetProperty(ref isNotRunning, value);
            }
        }
        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }
    }
}
