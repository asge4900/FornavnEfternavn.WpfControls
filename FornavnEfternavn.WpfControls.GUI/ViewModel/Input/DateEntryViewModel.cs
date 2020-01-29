using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FornavnEfternavn.WpfControls.GUI
{
    /// <summary>
    /// The view model for a date entry to edit a string value
    /// <summary>
    public class DateEntryViewModel : BaseViewModel
    {
        #region Constructor 

        /// <summary>
        /// Default constructor
        /// </summary>
        public DateEntryViewModel()
        {
            // Create commands
            EditCommand = new RelayCommand(Edit);
            CancelCommand = new RelayCommand(Cancel);
            SaveCommand = new RelayCommand(Save);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// The label to identify what this value is for
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// The current saved value
        /// </summary>
        public DateTime OriginalDate { get; set; }

        /// <summary>
        /// The current non-commit edited text
        /// </summary>
        public DateTime EditedDate { get; set; }

        /// <summary>
        /// Indicates if the current text is in edit mode
        /// </summary>
        public bool Editing { get; set; }

        /// <summary>
        /// Indicates if the current control is pending an update (in progress)
        /// </summary>
        public bool Working { get; set; }

        /// <summary>
        /// The action to run when saving the text
        /// Returns true if the commit was succesful, or false otherwise
        /// </summary>
        public Func<Task<bool>> CommitAction { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// Puts the control into edit mode
        /// </summary>
        public ICommand EditCommand { get; set; }

        /// <summary>
        /// Cancels out of edit mode
        /// </summary>
        public ICommand CancelCommand { get; set; }

        /// <summary>
        /// Commits the edits and saves the value
        /// as well as goes back to non-edit mode
        /// </summary>
        public ICommand SaveCommand { get; set; }

        #endregion       

        #region Command Methods

        /// <summary>
        /// Puts the control into edit mode
        /// </summary>
        public void Edit()
        {
            // Set the edited text to the current value
            EditedDate = OriginalDate;

            // Go into edit mode
            Editing = true;
        }

        /// <summary>
        /// Cancels out of edit mode
        /// </summary>
        public void Cancel()
        {
            Editing = false;
        }

        /// <summary>
        /// Commits the content and exits out of edit mode
        /// </summary>
        public void Save()
        {
            // Store the result of a commit call
            var result = default(bool);

            // Saved currently saved value
            var currentSavedValue = OriginalDate;

            RunCommandAsync(() => Working, async () =>
            {
                // While working, come out of edit mode
                Editing = false;

                // Commit the changed text
                // So we can see it while it is working
                OriginalDate = EditedDate;

                // Try and do the work
                result = CommitAction == null ? true : await CommitAction();

            }).ContinueWith(t =>
            {
                // If we succeeded...
                // Nothing to do
                // If we fail...
                if (!result)
                {
                    // Restore original value
                    OriginalDate = currentSavedValue;

                    // Go back into edit mode
                    Editing = true;
                }

            });
        }

        #endregion
    }
}
