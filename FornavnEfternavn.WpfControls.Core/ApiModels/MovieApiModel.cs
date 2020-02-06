using System;
using System.Collections.Generic;
using System.Text;

namespace FornavnEfternavn.WpfControls.Core
{
    public class MovieApiModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Director { get; set; }
        public bool IsColor { get; set; }
        public string Format { get; set; }
        public string Genre { get; set; }
    }
}
