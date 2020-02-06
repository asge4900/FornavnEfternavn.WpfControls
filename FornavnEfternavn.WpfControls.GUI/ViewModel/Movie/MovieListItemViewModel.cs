using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FornavnEfternavn.WpfControls.GUI
{
    /// <summary>
    /// 
    /// </summary>
    public class MovieListItemViewModel : BaseViewModel
    { 
        public int Id { get; set; }

        public TextEntryViewModel Title { get; set; }

        public DateEntryViewModel ReleaseDate { get; set; }

        public TextEntryViewModel Director { get; set; }

        public bool IsColor { get; set; }

        public TextEntryViewModel Format { get; set; }

        public TextEntryViewModel Genre { get; set; }             
    }
}
