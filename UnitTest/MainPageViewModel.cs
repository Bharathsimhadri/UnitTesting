using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnitTest.Services;

namespace UnitTest
{
    public class MainPageViewModel: INotifyPropertyChanged
    {
        ISampleApiCall sampleApiCall;

        string _email;
        public string Email { get { return _email; } set { _email = value;NotifyPropertyChanged(nameof(Email)); } }
      
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            sampleApiCall = new SampleApiCall();
        }

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool IsEmailValid()
        {
            if (!string.IsNullOrEmpty(Email))
            {
                return !Regex.IsMatch(Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$") ? false : true;
            }
            return false;
        }

        public async Task<object> GetUsers()
        {
            return await sampleApiCall.GetPostDetails("https://randomuser.me/api/?gender=male&results=20https://randomuser.me/api/?gender=male&results=20");
        }

    }
}
