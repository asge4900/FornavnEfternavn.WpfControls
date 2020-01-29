using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornavnEfternavn.WpfControls.GUI
{
    /// <summary>
    /// The design-time data for a <see cref="TextEntryViewModel"/>
    /// </summary>
    public class DateEntryDesignModel : DateEntryViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static DateEntryDesignModel Instance => new DateEntryDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public DateEntryDesignModel()
        {            
            OriginalDate = new DateTime (2017, 12, 15);
            EditedDate = DateTime.Now;
        }

        #endregion
    }
}
