using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Arc
{
    public class AggroSettings
    {
        public double DownedMultiplier { get; set; } = 20.0;
        public double KnockedMultiplier { get; set; } = 45.0;
        public double FirstStrikeMultiplier { get; set; } = 30.0;
        public double RevivedMultiplier { get; set; } = -10.0;
        public double DmgInflictedMultiplier { get; set; } = 0.3;
        public double DmgReceivedMultiplier { get; set; } = -0.1;
        public double LootedMultiplier { get; set; } = 10.0;

        public static AggroSettings LoadFromFile()
        {
            string path = "settings.json";
            if (File.Exists(path))
            {
                string jsonString = File.ReadAllText(path);
                return JsonSerializer.Deserialize<AggroSettings>(jsonString);
            }
            return new AggroSettings();
        }
    }
}