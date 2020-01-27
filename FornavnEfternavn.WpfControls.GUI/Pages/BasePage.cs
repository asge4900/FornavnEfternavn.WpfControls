using System.Windows.Controls;
using System.Windows;
using System.Threading.Tasks;
using Dna;

namespace FornavnEfternavn.WpfControls.GUI
{
    /// <summary>
    /// The base page for all pages to gain functionality
    /// </summary>
    public class BasePage : Page
    {
        #region Fields

        /// <summary>
        /// The animation that play when the page is first loaded
        /// </summary>
        private object viewModel;

        #endregion

        #region Constructor

        public BasePage()
        { 
            //Listen out for the page loading
            //Loaded += BasePage_Loaded;
        }

        #endregion

        #region Properties        

        /// <summary>
        /// The View Model associated with this page
        /// </summary>
        public object ViewModelObject
        {
            get => viewModel;
            set
            {
                //If nothning has changes, return
                if (viewModel == value)
                {
                    return;
                }

                //Update the value
                viewModel = value;

                // Fire the view model changed method
                OnViewModelChanged();

                //Set the data context for this page
                DataContext = viewModel;
            }
        }

        #endregion

        /// <summary>
        /// Fired when the view model changes 
        /// </summary>
        protected virtual void OnViewModelChanged()
        {

        }
    }

    /// <summary>
    /// A base page with added ViewModel support
    /// </summary>
    public class BasePage<VM> : BasePage
        where VM : BaseViewModel, new()
    {
        #region Constuctor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BasePage() : base()
        {
            //Create a default view model
            ViewModelObject = Framework.Service<VM>() ?? new VM();
        }

        /// <summary>
        /// Constructor with specific with model
        /// </summary>
        /// <param name="specificViewModel">The specific view model to use, if any</param>
        public BasePage(VM specificViewModel = null) : base()
        {
            //Set specific view model
            if (specificViewModel != null)
            {
                ViewModelObject = specificViewModel;
            }
            else
            {
                //Create a default view model
                ViewModelObject = Framework.Service<VM>() ?? new VM();
            }
        }


        #endregion

        #region Properties 

        /// <summary>
        /// The view model associated with this page
        /// </summary>
        public VM ViewModel
        {
            get => (VM)ViewModelObject;
            set => ViewModelObject = value;
        }

        #endregion      
    }
}
