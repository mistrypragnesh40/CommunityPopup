using CommunityToolkit.Maui.Views;

namespace CommunityPopup;

public partial class PopupPageWithCollectionView : Popup
{
	public PopupPageWithCollectionView()
	{
		InitializeComponent();
		this.BindingContext = new PopupPageWithCollectionViewModel();

    }
}