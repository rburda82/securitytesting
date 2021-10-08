using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = JsonConvert.DeserializeObject<object>(args[1], new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });


            Console.WriteLine(value.ToString());
        }
    }
}
