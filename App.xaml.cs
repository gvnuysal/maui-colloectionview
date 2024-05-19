using maui_collection_view.MVVM.Views;

namespace maui_collection_view
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DataView();
        }
    }
}
