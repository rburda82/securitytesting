using Newtonsoft.Json;
using System;

namespace ConsoleApp11
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
