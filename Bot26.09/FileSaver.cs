using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bot26._09
{
    public static class FileService
    {
        private static readonly string PATH = @"D:\Coding\Programs\Visual_Studio\C#\NT\asosiy_vazifa\26.09.23\Bot26.09\Bot26.09\entries.json";

        public static ApiInfo GetApiInfo()
        {
            string json;
            using (StreamReader sr = new StreamReader(PATH))
            {
                json = sr.ReadToEnd();
            }
            var objs = JsonConvert.DeserializeObject<ApiInfo>(json);
            return objs;
        }
    }
}
