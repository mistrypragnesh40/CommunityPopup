using CommunityToolkit.Maui.Views;

namespace CommunityPopup;

public partial class PopupPage : Popup
{
	public PopupPage()
	{
		InitializeComponent();
	}

	private void btnYes_Clicked(object sender, EventArgs e)
	{
		this.Close(true);
    }

	private void btnNo_Clicked(object sender, EventArgs e)
	{
		var obj = new { userID = 1 };
        this.Close(obj);
    }
}