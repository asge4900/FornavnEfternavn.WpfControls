using System;

namespace FornavnEfternavn.WpfControls.GUI
{
    /// <summary>
    /// The design-time data for a <see cref="MovieListItemViewModel"/>
    /// </summary>
    public class MovieListItemDesignModel : MovieListItemViewModel
    {
        #region Singleton

        public static MovieListItemDesignModel Instance => new MovieListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MovieListItemDesignModel()
        {
            Id = 1;
            Title = new TextEntryViewModel { OriginalText = "Star Trek: Beyond" };
            ReleaseDate = new DateEntryViewModel { OriginalDate = new DateTime (2016, 07, 22) };
            Director = new TextEntryViewModel { OriginalText = "Justin Lin" };
            IsColor = true;
            Format = new TextEntryViewModel { OriginalText = "2.35:1" };
            Genre = new TextEntryViewModel { OriginalText = "Sci-Fi" };
        }

        #endregion
    }
}
