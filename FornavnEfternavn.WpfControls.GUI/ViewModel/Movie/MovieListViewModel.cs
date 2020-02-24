using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using System;
using FornavnEfternavn.WpfControls.Core;
using System.Net.Http.Headers;
using System.Web.Http;

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
            UpdateMovieCommand = new RelayCommand(async () => await UpdateMovieAsync());
            DeleteMovieCommand = new RelayCommand(async () => await DeleteMovieAsync());
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

        public ICommand UpdateMovieCommand { get; set; }

        public ICommand DeleteMovieCommand { get; set; }

        #endregion


        private async Task CreateMovieAsync()
        {
            var movie = new MovieApiModel
            {
                Title = "hjhsdkjhsksjd",
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
                ApiRoutes.Movies, movie);


            //response.EnsureSuccessStatusCode();

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {

                var errorMessage = e.Message;
            }

            //if (!response.IsSuccessStatusCode)
            //{
            //    var error = response.ReasonPhrase;
            //}

            //var responseString =  await response.Content.ReadAsStringAsync();
        }

        public async Task GetMovieAsync ()
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

        private async Task DeleteMovieAsync()
        {
            client.BaseAddress = new Uri("http://localhost:54292/");

            int id = 5;
            
            var response = await client.DeleteAsync($"api/Movies{id}");           
        }
    }
}
