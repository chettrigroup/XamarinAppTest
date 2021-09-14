using System.ComponentModel;
using Xamarin.Forms;
using XamTestApp.ViewModels;

namespace XamTestApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}