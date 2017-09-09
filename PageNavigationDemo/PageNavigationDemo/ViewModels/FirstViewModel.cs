using CodeMill.VMFirstNav;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PageNavigationDemo.ViewModels
{
    public class FirstViewModel : ViewModelBase, IViewModel
    {
        private string navigationText;

        public string NavigationText
        {
            get { return navigationText; }
            set
            {
                navigationText = value;
                RaisePropertyChanged();
            }
        }
        private int sliderValue = 20;

        public int SliderValue
        {
            get { return sliderValue; }
            set
            {
                sliderValue = value;
                RaisePropertyChanged();
            }
        }
        private int red = 0;

        public int Red
        {
            get { return red; }
            set
            {
                red = value;
                SetColour();
                RaisePropertyChanged();
            }
        }

        private int blue = 0;

        public int Blue
        {
            get { return blue; }
            set
            {
                blue = value;
                SetColour();
                RaisePropertyChanged();
            }
        }

        private int green = 0;

        public int Green
        {
            get { return green; }
            set
            {
                green = value;
                SetColour();
                RaisePropertyChanged();
            }
        }

        private Color textColour;

        public Color TextColour
        {
            get { return textColour; }
            set
            {
                textColour = value;
                RaisePropertyChanged();
            }
        }

        public ICommand SecondPageCommand { get; private set; }
        public FirstViewModel()
        {
            SecondPageCommand = new Command(() =>
            {
                NavigationService.Instance.PushAsync(new SecondViewModel(new Tuple<string, int, Color>(NavigationText, SliderValue, TextColour)));
            });
        }

        public void SetColour()
        {
            TextColour = Color.FromRgb(Red, Green, Blue);
        }
    }
}
