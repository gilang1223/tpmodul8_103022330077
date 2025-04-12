using System;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

public class CovidConfig
{
    public string config1 { get; set; }
    public int config2 { get; set; }
    public string config3 { get; set; }
    public string config4 { get; set; }

    private readonly string configFile = "covid_config.json";

    public CovidConfig()
    {
        config1 = "celcius";
        config2 = 14;
        config3 = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
        config4 = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
        LoadConfig();
    }

    public void LoadConfig()
    {
        if (File.Exists(configFile))
        {
            var json = File.ReadAllText(configFile);
            var config = JsonConvert.DeserializeObject<CovidConfig>(json);
            config1 = config.config1;
            config2 = config.config2;
            config3 = config.config3;
            config4 = config.config4;
        }
    }

    public void SaveConfig()
    {
        var json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText(configFile, json);
    }


    public void UbahSatuan()
    {
        if (config1 == "celcius")
        {
            config1 = "fahrenheit";
        }
        else
        {
            config1 = "celcius";
        }
        SaveConfig();
    }
}
