using Clopay.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clopay.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductslistPage : ContentPage
	{
		public ProductslistPage ()
		{
			InitializeComponent ();
            BindingContext = new ProductlistViewModel();
        }
	}
}