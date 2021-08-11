using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using SASS.Models;

namespace SASS.ViewModels
{
   public class BaseViewModel : INotifyPropertyChanged
    {

        private string path = "Server=tcp:authenticationsassa.database.windows.net,1433;Initial Catalog=Sassa;Persist Security Info=False;User ID=sassalogin;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public string DBPath { get => path; }

        private User currentUser;
        public User CurrentUser
        {
            get => currentUser;
            set
            {
                SetProperty(ref currentUser, value);
            }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
           [CallerMemberName] string propertyName = "",
           Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


    }
}
