using maui_collection_view.MVVM.ViewModels;

namespace maui_collection_view.MVVM.Views;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();
	}
}