using Microsoft.Extensions.DependencyInjection;
using DanielSchiffer.Contracts.FlugplanungContract;
using DanielSchiffer.HCS.Domain.SimBriefEnhancer;
using System.CodeDom.Compiler;
using DanielSchiffer.HCS.Contracts.CockpitContract;
using CockpitEnhancerClassic;
namespace DanielSchiffer.HCS.UI.HCS_Winforms;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

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
        serviceCollection.AddSingleton<Starter,Starter>();
        serviceCollection.AddScoped<IFlightSimInterface, Flightsim>();
    }

    public class Starter
    {
        private readonly IFlightSimInterface _Flightsim;

        /// <summary>
        /// Initialisiert eine neue Instanz der Starter-Klasse.
        /// </summary>
        /// <param name="textSchreiber">Der Textschreiber, der verwendet werden soll.</param>
        public Starter(IFlightSimInterface flightsim)
        {
            _Flightsim = flightsim;
        }

        /// <summary>
        /// Führt die Anwendung aus.
        /// </summary>
        public void Execute()
        {
            // Die Anwendungskonfiguration anpassen, z.B. DPI-Einstellungen oder Standardschriftart festlegen
            // siehe auch https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main(_Flightsim));
        }
    }
}