using CodeMill.VMFirstNav;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PageNavigationDemo.ViewModels
{
    public class SecondViewModel : ViewModelBase, IViewModel
    {
        public SecondViewModel() { }

        public SecondViewModel(Tuple<string,int, Color> navParams)
        {
            NavigationText = navParams.Item1;
            NavigationSize = navParams.Item2;
        }
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

        private double navigationSize;

        public double NavigationSize
        {
            get { return navigationSize; }
            set
            {
                navigationSize = value;
                RaisePropertyChanged();
            }
        }

        private Color textColour;

        public Color TextColour
        {
            get { return textColour; }
            set { textColour = value; }
        }

    }
}
