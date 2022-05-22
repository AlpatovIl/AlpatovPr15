using AlpatovPr15.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AlpatovPr15.Views
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