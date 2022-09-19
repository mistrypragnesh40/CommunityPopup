using CommunityToolkit.Maui.Views;

namespace CommunityPopup;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = new MainPageViewModel();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		//if (count == 1)
		//	CounterBtn.Text = $"Clicked {count} time";
		//else
		//	CounterBtn.Text = $"Clicked {count} times";

		//SemanticScreenReader.Announce(CounterBtn.Text);

		//this.ShowPopup(new PopupPage());

		var result = await this.ShowPopupAsync(new PopupPage());


	}
}

