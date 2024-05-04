using Microsoft.Extensions.DependencyInjection;
using DanielSchiffer.Contracts.FlugplanungContract;
using System.CodeDom.Compiler;
using DanielSchiffer.HCS.Contracts.CockpitContract;
using CockpitEnhancerClassic;
using DanielSchiffer.HCS.UI.HCS_Winforms.ViewModels;
using DanielSchiffer.HCS.Logic.WindowsIo;
using System.Configuration;
using DanielSchiffer.HCS.Logic.Setting;
using DanielSchiffer.HCS.Logic.NavdataUpdater;
namespace DanielSchiffer.HCS.UI.HCS_Winforms;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // Die Anwendungskonfiguration anpassen, z.B. DPI-Einstellungen oder Standardschriftart festlegen
        // siehe auch https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();


        //Servicecollection
        var serviceCollection = new ServiceCollection();


        ConfigureServices(serviceCollection);

        var serviceProvider = serviceCollection.BuildServiceProvider();

        // Execute the Starter class if it is available in the service provider
        if (serviceProvider.GetService<Starter>() is Starter starter)
        {
            starter.Execute();
        }

    }

    private static void ConfigureServices(ServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<Starter, Starter>();
        serviceCollection.AddScoped<IFlightSimInterface, Flightsim>();
        serviceCollection.AddScoped<CycleInfoInterpreter>();
        serviceCollection.AddScoped<MainModel>();
        serviceCollection.AddScoped<NavdataUpdateModel>();
        serviceCollection.AddScoped<NavDataIo>();
        serviceCollection.AddScoped<SettingsModel>();
        serviceCollection.AddScoped<SettingsManager>();
        serviceCollection.AddScoped<Updater>();
    }

    public class Starter
    {
        private readonly IFlightSimInterface _Flightsim;
        private readonly MainModel _Model_frmMain;
        /// <summary>
        /// Initialisiert eine neue Instanz der Starter-Klasse.
        /// </summary>
        /// <param name="textSchreiber">Der Textschreiber, der verwendet werden soll.</param>
        public Starter(IFlightSimInterface flightsim, MainModel model_frmMain)
        {
            _Flightsim = flightsim;
            _Model_frmMain = model_frmMain;
        }

        /// <summary>
        /// Führt die Anwendung aus.
        /// </summary>
        public void Execute()
        {
            _Model_frmMain.Show();
            Application.Run();
        }
    }
}
