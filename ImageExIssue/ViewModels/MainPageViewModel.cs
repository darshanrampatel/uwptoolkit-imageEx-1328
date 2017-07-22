using System.Collections.Generic;
using System.Threading.Tasks;
using Template10.Mvvm;
using Windows.UI.Xaml.Navigation;

namespace ImageExIssue.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public void LoadItems()
        {
            var list = new List<Picture>();
            for (int i = 0; i < 200; i++)
            {
                var newItem = new Picture(i);
                list.Add(newItem);
            }
            Pictures = list;
        }

        private List<Picture> _Pictures = new List<Picture>();
        public List<Picture> Pictures
        {
            get => _Pictures;
            set
            {
                Set(ref _Pictures, value);
            }
        }
    }

    public class Picture
    {
        public Picture(int i)
        {
            ID = i + 1;
            URL = $"https://unsplash.it/128?image={i}";
        }

        public int ID { get; set; }
        public string URL { get; set; }
    }
}