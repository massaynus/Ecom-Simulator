using Ecom_Simulator.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Ecom_Simulator.Views
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