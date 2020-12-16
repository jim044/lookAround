using LookAround.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LookAround.Views
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