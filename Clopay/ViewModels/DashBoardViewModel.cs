using Clopay.Views;
using System.Collections.Generic;

namespace Clopay.ViewModels
{
    public class DashBoardViewModel : ViewModelBase
    {
        /// <summary>
        /// The menuItem
        /// </summary>
        private List<MenuItem> _menuItem;

        /// <summary>
        /// Gets and Sets MenuItems
        /// </summary>
        /// <value>
        /// The menuItem
        /// </value>
        public List<MenuItem> MenuItems
        {
            get { return _menuItem; }
            set
            {
                if (_menuItem != value)
                {
                    _menuItem = value;
                    OnPropertyChanged(nameof(MenuItems));
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashBoardViewModel" /> class.
        /// </summary>
        public DashBoardViewModel()
        {
            _menuItem = new List<MenuItem>
            {
                new MenuItem {IconSource = "home.png", TargetType = typeof(ProductslistPage)},
                new MenuItem {IconSource = "qrcode.png", TargetType = typeof(QrCodePage)},
                new MenuItem {IconSource = "password.png", TargetType = typeof(SettingsPage)},
                new MenuItem {IconSource = "law.png", TargetType = typeof(ProductslistPage)},
                new MenuItem {IconSource = "phone.png", TargetType = typeof(CallHistoryPage)},
                new MenuItem {IconSource = "contacts.png", TargetType = typeof(ContactsPage)},
                new MenuItem {IconSource = "email.png", TargetType = typeof(ProductslistPage)},
                new MenuItem {IconSource = "clock.png", TargetType = typeof(SettingsPage)},
                new MenuItem {IconSource = "fillcolor.png", TargetType = typeof(ThemesPage)},
                 new MenuItem {IconSource = "textleft.png", TargetType = typeof(NotePadPage)},
                new MenuItem {IconSource = "closedwindow.png", TargetType = typeof(SettingsPage)},
                new MenuItem {IconSource = "personathome.png", TargetType = typeof(ProductslistPage)},             
                new MenuItem {IconSource = "calendar.png", TargetType = typeof(SettingsPage)},
                new MenuItem {IconSource = "about.png", TargetType = typeof(ProductslistPage)},
                new MenuItem {IconSource = "settings.png", TargetType = typeof(SettingsPage)}
            };
        }
    }
}
