using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SASS.Models;
using SASS.Services.AuthenticationSevices;

namespace SASS.ViewModels.AuthenticationVM
{
   public class SigninViewModel : BaseViewModel
    {
        private string fullname;
        private string email;
        private string number;
        private string password;
        private string confirmpassword;
        
       

        public Command SignIn { get; }


        public SigninViewModel()
        {
            SignIn = new Command(OnSignin);
        }


        public string FullName
        {
            get => fullname;
            set
            {
                SetProperty(ref fullname, value);
            }
        }
        public string Email
        {
            get => email;
            set
            {
                SetProperty(ref email, value);
                OnPropertyChanged(nameof(Email));
            }
        }

        public string Number
        {
            get => number;
            set
            {
                SetProperty(ref number, value);
                OnPropertyChanged(nameof(Number));
            }
        }
        
        public string Password
        {
            get => password;
            set
            {
                SetProperty(ref password, value);
                OnPropertyChanged(nameof(Password));
            }
        }
        public string ConfirmPassword
        {
            get => password;
            set
            {
                SetProperty(ref confirmpassword, value);
                OnPropertyChanged(ConfirmPassword);
            }
        }

        


       async void OnSignin()
        {
            bool IsCorrectName = false;
            bool IsCorrectPass = false;
            bool IsCorrectNumber = false;
            UserData data = new UserData(DBPath);

            if (CheckSpaceBetween(FullName))
            {
                IsCorrectName = true;

            }



            var user = new User()
            {
                Email = Email,
                StudentNumber = Number,
                Password = Password,
                UserName = Email
            };



           bool process = await data.AddUser(user);
            CurrentUser = user;





            await Shell.Current.GoToAsync("BookPage");
            
            
           



        }




        bool PassIsConfirmed(string passOne, string passTwo)
        {
            return passOne == passTwo;
        }

     




        bool CheckSpaceBetween(string name)
        {

            return name.IndexOf(' ') != -1;

        }

        private bool Contails(string target, string list)
        {

            return target.IndexOfAny(list.ToCharArray()) != -1;
        }

        private void verifyPasswordLevels(string password)
        {
            bool length;


            List<int> numbers = new List<int>()
            {
               1,2,3,4,5,6,7,8,9,0
            };
            List<string> characters = new List<string>()
            {
                "!","@","#","$","%","^","&","*","+","=","-","`"
            };

            string charList = "!@#$%^&*()_+=-`.";
            string numberList = "1234567890";

            if (password.Length >= 8)
            {
                length = true;
            }
            else
            {
                length = false;
            }


        }






    }
}
