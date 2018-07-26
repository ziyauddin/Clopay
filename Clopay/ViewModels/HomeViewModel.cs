using Clopay.Views;
using Xamarin.Forms;

namespace Clopay.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the  Login Command
        /// </summary>
        public Command GoCommand { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeViewModel" /> class.
        /// </summary>
        public HomeViewModel() => GoCommand = new Command(() =>
                                {
                                    DashBoardPage dashboard = new DashBoardPage();
                                    Application.Current.MainPage = dashboard;
                                });
    }
}
