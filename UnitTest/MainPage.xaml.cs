using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UnitTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MainPageViewModel mainPageViewModel;
        public MainPage()
        {
            InitializeComponent();
            mainPageViewModel = new MainPageViewModel();
            this.BindingContext = mainPageViewModel;
        }
    }
}
