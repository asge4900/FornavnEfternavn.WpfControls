using System.Windows.Controls;

namespace FornavnEfternavn.WpfControls.GUI
{
    /// <summary>
    /// Interaction logic for AllMoviesPage.xaml
    /// </summary>
    public partial class AllMoviesPage : BasePage<MovieListViewModel>
    {
        #region Constructor

        /// <summary>
        /// Default constuctor
        /// </summary>
        public AllMoviesPage() : base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor with specific view model
        /// </summary>
        /// <param name="specificViewModel">The specific view model to use for this page</param>
        public AllMoviesPage(MovieListViewModel specificViewModel) : base(specificViewModel)
        {
            InitializeComponent();
        } 

        #endregion
    }
}
