using Prism.Navigation;
using System.Collections.ObjectModel;

namespace FaceFinderPrism.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        private readonly IBeerService _beerService;
        public HomePageViewModel(INavigationService navigationService, IBeerService beerService) : base(navigationService)
        {
            Title = "Lista de cerveza";
            _beerService = beerService;
            BeersList = new ObservableCollection<Beer>();
            GetListBeer();
        }


        private ObservableCollection<Beer> beerList;
        public ObservableCollection<Beer> BeersList
        {
            get { return beerList; }
            set { SetProperty(ref beerList, value); }
        }

        //private Beer beerSelected;
        //public Beer BeerSelected
        //{
        //    get { return beerSelected; }
        //    set
        //    {
        //        SetProperty(ref beerSelected, value);
        //        if (value != null)
        //        {

        //        }
        //    }
        //}

        async void GetListBeer()
        {

            var getAll = await _beerService.GetAllTheBeersAsync();
            foreach (var item in getAll)
            {
                BeersList.Add(item);
            }


        }
    }
}
