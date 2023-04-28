using ComunidadSegura.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ComunidadSegura.Views
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