using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TravelAgency.Storage
{
    public class JsonStorage
    {
        private readonly string _dataFolder;

        public JsonStorage()
        {
            _dataFolder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "TravelAgency"
            );

            if (!Directory.Exists(_dataFolder))
                Directory.CreateDirectory(_dataFolder);
        }

        public void Save<T>(string fileName, List<T> data)
        {
            string path = Path.Combine(_dataFolder, fileName);
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public List<T> Load<T>(string fileName)
        {
            try
            {
                string path = Path.Combine(_dataFolder, fileName);

                if (!File.Exists(path))
                    return new List<T>();

                string json = File.ReadAllText(path);

                if (string.IsNullOrWhiteSpace(json))
                    return new List<T>();

                var result = JsonConvert.DeserializeObject<List<T>>(json);
                return result ?? new List<T>();
            }
            catch
            {
                return new List<T>();
            }
        }
    }
}