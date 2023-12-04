using Library.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<Movie> moviesList { get; set; } = new ObservableCollection<Movie>();
        public Movie selectedMovie { get; set; }

        public String Title { get; set; }
        public String Description { get; set; }
        public String Author { get; set; }
        public int Rating { get; set; }

        public Command toAddPageCommand { get; }


        public MainViewModel() {
            FillProductList();
            toAddPageCommand = new Command(() =>
            {
                App.Current.MainPage = new NavigationPage(new AddPage());
            });

        }

        public void FillProductList()
        {
            Movie m1 = new Movie() { Title="Avengers Endgame", Description= "Tony Stark vaart stuurloos door de ruimte zonder eten of drinken. Terwijl zijn zuurstofvoorraad begint af te nemen, stuurt hij een bericht naar Pepper Potts.", Author="Lukas", Rating=5};
            Movie m2 = new Movie() { Title = "Avengers Endgame", Description = "Tony Stark vaart stuurloos door de ruimte zonder eten of drinken. Terwijl zijn zuurstofvoorraad begint af te nemen, stuurt hij een bericht naar Pepper Potts.", Author = "Lukas", Rating = 5 };
            Movie m3 = new Movie() { Title = "Avengers Endgame", Description = "Tony Stark vaart stuurloos door de ruimte zonder eten of drinken. Terwijl zijn zuurstofvoorraad begint af te nemen, stuurt hij een bericht naar Pepper Potts.", Author = "Lukas", Rating = 5 };
            Movie m4 = new Movie() { Title = "Avengers Endgame", Description = "Tony Stark vaart stuurloos door de ruimte zonder eten of drinken. Terwijl zijn zuurstofvoorraad begint af te nemen, stuurt hij een bericht naar Pepper Potts.", Author = "Lukas", Rating = 5 };
            Movie m5 = new Movie() { Title = "Avengers Endgame", Description = "Tony Stark vaart stuurloos door de ruimte zonder eten of drinken. Terwijl zijn zuurstofvoorraad begint af te nemen, stuurt hij een bericht naar Pepper Potts.", Author = "Lukas", Rating = 5 };
            Movie m6 = new Movie() { Title = "Avengers Endgame", Description = "Tony Stark vaart stuurloos door de ruimte zonder eten of drinken. Terwijl zijn zuurstofvoorraad begint af te nemen, stuurt hij een bericht naar Pepper Potts.", Author = "Lukas", Rating = 5 };

            moviesList.Add(m1);
            moviesList.Add(m2);
            moviesList.Add(m3);
            moviesList.Add(m4);
            moviesList.Add(m5);
            moviesList.Add(m6);
        }


    }
}
