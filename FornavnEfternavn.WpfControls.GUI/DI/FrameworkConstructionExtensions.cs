using Dna;
using Microsoft.Extensions.DependencyInjection;

namespace FornavnEfternavn.WpfControls.GUI
{
    /// <summary>
    /// Extension methods for the <see cref="FrameworkConstruction"/>
    /// </summary>
    public static class FrameworkConstructionExtensions
    {
        /// <summary>
        /// Injects the view models needed for Fasetto Word application
        /// </summary>
        /// <param name="construction"></param>
        /// <returns></returns>
        public static FrameworkConstruction AddFornavnEfternavnWpfControlsGUIViewModels(this FrameworkConstruction construction)
        {
            // Bind to a single instance of Application view model
            construction.Services.AddSingleton<ApplicationViewModel>();
            

            // Return the construction for chaining
            return construction;
        }
    }
}
