using CodeMill.VMFirstNav;
using PageNavigationDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageNavigationDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage, IViewFor<SecondViewModel>
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        SecondViewModel vm;
        public SecondViewModel ViewModel
        {
            get => vm;
            set
            {
                vm = value;
                BindingContext = vm;
            }
        }
    }
}