using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DanielSchiffer.HCS.Logic.Configuartion;

internal class ConfigurationManager
{

    public IConfigurationRoot Configuration { get; }

    public ConfigurationManager(string filePath)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile(filePath, optional: false, reloadOnChange: true);

        Configuration = builder.Build();
    }

    public T GetSection<T>(string key) where T : new()
    {
        T settings = new T();
        Configuration.GetSection(key).Bind(settings);
        return settings;
    }
}

