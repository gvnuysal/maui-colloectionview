using maui_collection_view.MVVM.Models;
using System.Collections.ObjectModel;

namespace maui_collection_view.MVVM.ViewModels
{
    public class DataViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
        public DataViewModel()
        {
            Products = new ObservableCollection<Product>
            {
                    new Product
                    {
                        HasOffer = true,
                        Price=60.0m,
                        Image="yogurt.png",
                        Name="Yogurt",
                        OfferPrice=78,
                        Stock=95
                    },
                     new Product
                    {
                        HasOffer = true,
                        Price=10.0m,
                        Image="watermelon.png",
                        Name="WaterMelon",
                        OfferPrice=78,
                        Stock=95
                    }
            };
        }
    }
}
