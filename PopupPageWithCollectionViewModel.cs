using CommunityPopup.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityPopup
{
    public class PopupPageWithCollectionViewModel
    {
        public ObservableCollection<Student> Students { get; set; } = new ObservableCollection<Student>();
        public PopupPageWithCollectionViewModel()
        {
            for (int i = 1; i <= 20; i++)
            {
                Students.Add(new Student { FullName = $"User {i}" });
            }
        }
    }
}
