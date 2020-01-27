using System;

namespace FornavnEfternavn.WpfControls.GUI
{
    /// <summary>
    /// 
    /// </summary>
    public class MovieListItemViewModel : BaseViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Director { get; set; }

        public bool IsColor { get; set; }

        public string Format { get; set; }

        public string Genre { get; set; }
    }
}
