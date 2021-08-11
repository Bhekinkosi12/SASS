using System;
using System.Collections.Generic;
using System.Text;

namespace SASS.Models
{
   public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Institute { get; set; }
        public string StudentNumber { get; set; }
        public string Password { get; set; }
        public List<Note> Notes { get; set; }
        public List<Order> Orders { get; set; }
        public List<Subscribe> Subscribes { get; set; }
        public List<Faculty> Faculties { get; set; }
        public List<Genre> Genres { get; set; }
        

    }
}
