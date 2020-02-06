using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using System;
using FornavnEfternavn.WpfControls.Core;

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

        public MovieListViewModel()
        {
            //CreateMovieCommand = new RelayCommand();
        }

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
            //var values = new Dictionary<string, string>
            //{
            //{ "thing1", "hello" },
            //{ "thing2", "world" }
            //};           

            //var content = new FormUrlEncodedContent(values);

            //var response = client.PostAsync("http://localhost:54292/api/Movies", content);

            //var responseString = await response.Result.Content.ReadAsStringAsync();

            var movie = new MovieApiModel
            {
                Title = "Untitled title",
                Director = "Director",
                IsColor = true,
                Format = "4.16",
                Genre = "Action"
            };            

            client.BaseAddress = new Uri("http://localhost:54292/");

            var response = await client.PostAsJsonAsync(
                "api/Movies", movie);

            response.EnsureSuccessStatusCode();

            var responseString =  await response.Content.ReadAsStringAsync();
        }

        private async Task PutMovieAsync()
        {
            var values = new Dictionary<string, string>
            {
            { "thing1", "hello" },
            { "thing2", "world" }
            };

            var content = new FormUrlEncodedContent(values);

            var response = client.PutAsync("http://localhost:54292/api/Movies", content);

            var responseString = await response.Result.Content.ReadAsStringAsync();
        }
    }
}
