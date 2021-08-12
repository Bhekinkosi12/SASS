using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace SASS.ViewModels.MainVM
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class BookViewModel : BaseViewModel
    {

        private string itemId;
        private Stream pdfDocument;

        public string ItemId
        {
            get => itemId;
            set
            {
                SetProperty(ref itemId, value);
                LoadItemId(value);
                OnPropertyChanged(nameof(ItemId));
            }
        }

        public Stream PdfDocument
        {
            get => pdfDocument;
            set
            {
                SetProperty(ref pdfDocument, value);
                OnPropertyChanged(nameof(PdfDocument));
            }
        }










        public void LoadItemId(string itemId)
        {
            try
            {

                MainViewModel mainView = new MainViewModel();

                var item = mainView.GetFaculty(itemId);

                PdfDocument = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream($"SASS.Documents.{item.F_Document}");



            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }






    }
}
