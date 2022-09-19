using CommunityToolkit.Maui.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommunityPopup
{
    public class MainPageViewModel
    {


        public ICommand ShowPopupCommand => new Command(async() =>
        {
            var result = await App.Current.MainPage.ShowPopupAsync(new PopupPage());


        });

        public ICommand ShowPopup1Command => new Command(async () =>
        {
            var result = await App.Current.MainPage.ShowPopupAsync(new PopupPageWithCollectionView());

        });
    }
}
