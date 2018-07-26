using Clopay.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clopay.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DashBoardPage : MasterDetailPage
    {
		public DashBoardPage ()
		{
			InitializeComponent ();
            BindingContext = new DashBoardViewModel();
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ProductslistPage)));
        }
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; // ensures we ignore this handler when the selection is just being cleared
            }
            var item = (MenuItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}