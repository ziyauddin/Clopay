using Clopay.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clopay.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            BindingContext = new HomeViewModel();
		}
	}
}