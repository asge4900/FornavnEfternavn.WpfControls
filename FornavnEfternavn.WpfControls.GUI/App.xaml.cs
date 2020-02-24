using Dna;
using System.Threading.Tasks;
using System.Windows;
using static Dna.FrameworkDI;
using static FornavnEfternavn.WpfControls.Core.CoreDI;

namespace FornavnEfternavn.WpfControls.GUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Custom startup so we load our IoC immediately before anything else
        /// </summary>
        /// <param name="e"></param>
        protected override async void OnStartup(StartupEventArgs e)
        {
            //Let the base application do what it needs
            base.OnStartup(e);

            //Setup the main application
            await ApplicationSetupAsync();

            //Log it
            Logger.LogInformationSource("Application starting...");

            //Show the main window
            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();
        }

        /// <summary>
        /// Configures our application ready for use
        /// </summary>
        private async Task ApplicationSetupAsync()
        {
            // Setup the Dna Framework
            Framework.Construct<DefaultFrameworkConstruction>()
                .AddFileLogger()
                .AddFornavnEfternavnWpfControlsGUIViewModels()                
                .Build();            
        }
    }
}
