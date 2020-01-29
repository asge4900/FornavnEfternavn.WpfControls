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
                    Title = new TextEntryViewModel { OriginalText = "Star Trek: Beyond" },
                    ReleaseDate = new DateEntryViewModel { OriginalDate = new DateTime (2016, 07, 22) },
                    Director =  new TextEntryViewModel { OriginalText ="Justin Lin" },
                    IsColor = true,
                    Format = new TextEntryViewModel { OriginalText = "2.35:1" },
                    Genre = new TextEntryViewModel { OriginalText = "Sci-Fi" },
                },
                new MovieListItemViewModel
                {
                    Id = 2,
                    Title = new TextEntryViewModel { OriginalText = "Star Wars: The Last Jedi"},
                    ReleaseDate = new DateEntryViewModel { OriginalDate = new DateTime(2017, 12, 15) },
                    Director = new TextEntryViewModel { OriginalText = "Ryan Johnson" },
                    IsColor = true,
                    Format = new TextEntryViewModel { OriginalText = "2.39:1" },
                    Genre = new TextEntryViewModel { OriginalText = "Epic Space Opera" },
                }
            };
        }

        #endregion
    }
}
