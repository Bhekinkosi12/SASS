using System;
using System.Collections.Generic;
using System.Text;
using SASS.Models;
using Xamarin.Forms;
using System.Linq;
using SASS.Views.Main;

namespace SASS.ViewModels.MainVM
{
   public class MainViewModel : BaseViewModel
    {

        public List<Faculty> Faculties { get; set; }

        public List<Genre> Genres { get; set; }

        public Command<Faculty> FacultiyClick { get; set; }
        public Command<Genre> GentreClick { get; set; }


        
        public MainViewModel()
        {
            // getData(CurrentUser);
            GetData();
            FacultiyClick = new Command<Faculty>(OnFaculty);

        }

        void getData(User user)
        {
            Faculties = user.Faculties;
            Genres = user.Genres;
        }



        void GetData()
        {

            Faculties = new List<Faculty>()
            {
                new Faculty
                {
                    F_Id = "1",
                    F_Name = "Early Childhood Grouth",
                    F_Image = "Early_Child.jpg",
                    F_Document = "Early_Childhood.pdf"
                },
                new Faculty
                {
                    F_Id = "2",
                    F_Name = "Information Technology",
                    F_Image = "information.jpg",
                    F_Document = "informationTech.pdf"
                },
                new Faculty
                {
                    F_Id = "3",
                    F_Name = "Intro To South African Law",
                    F_Document = "introToLaw.pdf",
                    F_Image = "Law.jpg"
                },
                new Faculty
                {
                    F_Id = "4",
                    F_Name = "Public Health",
                    F_Image = "public_health.jpg",
                    F_Document = "publicHealth.pdf"
                },
                new Faculty
                {
                    F_Id = "5",
                    F_Name = "Stay Where You Are",
                    F_Document = "Stay_Where_You_Are.pdf",
                    F_Image ="Stay_Where_You_Are.jpg"
                },
                new Faculty
                {
                    F_Id = "6",
                    F_Name = "Think and grow",
                    F_Document = "ThinkAndGrow.pdf",
                    F_Image = "Think_and_Grow.jpg"
                }

            };




        }






        public Faculty GetFaculty(string id)
        {
            return Faculties.FirstOrDefault(x => x.F_Id == id);
        }







        async void OnFaculty(Faculty faculty)
        {




            //   await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");



            await Shell.Current.GoToAsync($"{nameof(BookPage)}?{nameof(BookViewModel.ItemId)}={faculty.F_Id}");
        }






    }
}
