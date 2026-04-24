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
        public double DownedMultiplier { get; set; } = 50.0;
        public double KnockedMultiplier { get; set; } = 50.0;
        public double RevivedMultiplier { get; set; } = -10.0;
        public double DmgInflictedMultiplier { get; set; } = 0.1;
        public double LootedMultiplier { get; set; } = 15.0;
        public int RollingAverageCount { get; set; } = 10;
        public double ZeroDamage { get; set; } = -20.0;
        public double SkillKOsMultiplier { get; set; } = 50.0;
        public double SkillEfficiencyMultiplier { get; set; } = 10.0;
        public double SkillExtractBonus { get; set; } = 100.0;
        public double SkillExtractPenalty { get; set; } = -50.0;
        public void SaveToFile(string filePath)
        {
            // ->WriteIndented makes JSON easily readable with notepad++
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(this, options);
            File.WriteAllText(filePath, jsonString);
        }

        public static AggroSettings LoadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                // -> ?? --> fall back to default if JSON file is empty
                return JsonSerializer.Deserialize<AggroSettings>(jsonString) ?? new AggroSettings();
            }

            // else -> if no file found return default settings
            return new AggroSettings();
        }
    }
}