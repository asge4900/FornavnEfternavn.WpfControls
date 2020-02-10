using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using System;
using FornavnEfternavn.WpfControls.Core;
using System.Net.Http.Headers;

namespace FornavnEfternavn.WpfControls.GUI
{
    /// <summary>
    /// 
    /// </summary>
    public class MovieListViewModel : BaseViewModel
    {
        #region Fields

        private static readonly HttpClient client = new HttpClient();

        #endregion

        #region Constructor

        public MovieListViewModel()
        {
            CreateMovieCommand = new RelayCommand(async () => await CreateMovieAsync());
        }
        
        #endregion

        #region Properties

        /// <summary>
        /// The movie list item for the list
        /// </summary>
        public List<MovieListItemViewModel> Items { get; set; }

        #endregion

        #region Command Properties

        public ICommand CreateMovieCommand { get; set; }
        
        #endregion


        private async Task CreateMovieAsync()
        {
            var movie = new MovieApiModel
            {
                Title = "Untitled title",
                Director = "Director",
                IsColor = true,
                Format = "4.16",
                Genre = "Action"
            };            

            client.BaseAddress = new Uri("http://localhost:54292/");

            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.PostAsJsonAsync(
                "api/Movies", movie);

            response.EnsureSuccessStatusCode();

            //var responseString =  await response.Content.ReadAsStringAsync();
        }

        private async Task GetMovieAsync ()
        {
            client.BaseAddress = new Uri("http://localhost:54292/");

            string path = "";

            var response = await client.GetAsync(path);            
        }

        private async Task UpdateMovieAsync()
        {
            client.BaseAddress = new Uri("http://localhost:54292/");

            int id = 2;

            var movie = new MovieApiModel
            {
                Title = "Hope this work",
                ReleaseDate = DateTime.Now,
                Director = "Hansi Gertrud",
                IsColor = false,
                Format = "54",
                Genre = "Action"
            };

            var response = await client.PutAsJsonAsync($"api/Movies{id}", movie);

            response.EnsureSuccessStatusCode();
        }
    }
}
