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
            string path = Path.Combine(_dataFolder, fileName);

            if (!File.Exists(path))
                return new List<T>();

            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
        }
    }
}