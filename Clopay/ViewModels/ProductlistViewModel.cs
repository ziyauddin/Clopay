using Clopay.DataService;
using Clopay.Model;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Clopay.ViewModels
{
    public class ProductlistViewModel : ViewModelBase 
    {
        /// <summary>
        /// The items
        /// </summary>
        private List<ProductDetails> items;

        /// <summary>
        /// Gets and Sets Items
        /// </summary>
        /// <value>
        /// The menuItem
        /// </value>
        public List<ProductDetails> Items
        {
            get { return items; }
            set
            {
                items = value;
                OnPropertyChanged(nameof(Items));
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductlistViewModel" /> class.
        /// </summary>
        public ProductlistViewModel()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                 Items = await DataSource.GetProductList();
            });
        }
    }
}
