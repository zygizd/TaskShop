using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using taskNortal.Models;

namespace taskNortal.Shared
{
    public class SeedSqlFromJson
    {
        public List<Phone> GetDeserializedJsonFile()
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Files\products.json");
            var jsonText = System.IO.File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Models.Phone>>(jsonText);
        }
    }
}