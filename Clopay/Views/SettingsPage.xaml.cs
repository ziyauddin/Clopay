using Clopay.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clopay.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();
            BindingContext = new ProductlistViewModel();
        }
	}
}