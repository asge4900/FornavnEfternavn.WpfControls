using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornavnEfternavn.WpfControls.GUI
{
    /// <summary>
    /// The design-time data for a <see cref="MovieListViewModel"/>
    /// </summary>
    public class MovieListDesignModel : MovieListViewModel
    {
        #region Singleton

        public static MovieListDesignModel Instance => new MovieListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MovieListDesignModel()
        {
            Items = new List<MovieListItemViewModel>
            {
                new MovieListItemViewModel
                {
                    Id = 1,
                    Title = "Star Trek: Beyond",
                    ReleaseDate = new DateTime(2016, 07, 22),
                    Director = "Justin Lin",
                    IsColor = true,
                    Format = "2.35:1",
                    Genre = "Sci-Fi",
                },
                new MovieListItemViewModel
                {
                    Id = 2,
                    Title = "Star Wars: The Last Jedi",
                    ReleaseDate = new DateTime(2017, 12, 15),
                    Director = "Ryan Johnson",
                    IsColor = true,
                    Format = "2.39:1",
                    Genre = "Epic Space Opera",
                }
            };
        }

        #endregion
    }
}
