using System.Collections.Generic;

namespace FornavnEfternavn.WpfControls.GUI
{
    /// <summary>
    /// 
    /// </summary>
    public class MovieListViewModel : BaseViewModel
    {
        /// <summary>
        /// The movie list item for the list
        /// </summary>
        public List<MovieListItemViewModel> Items { get; set; }
    }
}
