using System;
using System.Collections.Generic;
using System.Text;
using SASS.Models;
using Xamarin.Forms;

namespace SASS.ViewModels.MainVM
{
   public class MainViewModel : BaseViewModel
    {

        public List<Faculty> Faculties { get; set; }

        public List<Genre> Genres { get; set; }

        public Command<Faculty> FacultiyClick { get; }
        public Command<Genre> GentreClick { get; }


        
        public MainViewModel()
        {
            getData(CurrentUser);

        }

        void getData(User user)
        {
            Faculties = user.Faculties;
            Genres = user.Genres;
        }














    }
}
