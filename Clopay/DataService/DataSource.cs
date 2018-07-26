using Clopay.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clopay.DataService
{
    public class DataSource
    {
        /// <summary>
        /// GetProductList
        /// </summary>
        /// <returns>The Productlist</returns>
        public static async Task<List<ProductDetails>> GetProductList()
        {
            await Task.Delay(1000);
            var productlist = new List<ProductDetails>
            {
               new ProductDetails() {ProductImage = "product1.png",Play = "playenable.png", Expand ="expandenable.png", Information="infoenable.png",Select ="selectenable.png" },
               new ProductDetails() {ProductImage = "product2.png",Play = "playdisable.png", Expand ="expanddisable.png", Information="infodisable.png",Select ="selectdisable.png" },
               new ProductDetails() {ProductImage = "product3.png",Play = "playdisable.png", Expand ="expanddisable.png", Information="infodisable.png",Select ="selectdisable.png" }
            };
            return productlist;
        }
    }
}
