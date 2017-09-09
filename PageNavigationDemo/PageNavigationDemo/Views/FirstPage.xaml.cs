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
    public partial class FirstPage : ContentPage , IViewFor<FirstViewModel>
    {
        FirstViewModel vm;
        public FirstViewModel ViewModel
        {
            get => vm;
            set
            {
                vm = value;
                BindingContext = vm;
            }
        }
        public FirstPage()
        {
            InitializeComponent();
            var x = vm;

        }
    }
}