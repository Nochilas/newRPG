using System;
using System.Text.Json;
using System.IO;
using PGLib.Models;

namespace PGLib;
public static class JSONSerializer
{
    public static string Serialize<T>(T parameter, string path)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize<T>(parameter, new JsonSerializerOptions()
            {
                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase
            });
            // string path = $"./data/{pg.Name}.json";

            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(jsonString);
            }
            
            return jsonString;
        }
        catch(NotSupportedException e)
        {
            Console.WriteLine($"NotSupportedException: {e.Message}");
        }
        catch(Exception e)
        {
            Console.WriteLine($"{e.GetType}: {e.Message}");
        }

        return String.Empty;
    }

    public static T Deserialize<T>(string path) where T:new()
    {
        try
        {
            string jsonString = String.Empty;

            using(StreamReader sr = new StreamReader(path))
            {
                jsonString = sr.ReadLine();
            }

            if(jsonString == String.Empty)
                return new T();
            else
            {
                T deserialized = JsonSerializer.Deserialize<T>(jsonString, new JsonSerializerOptions()
                {
                    AllowTrailingCommas = true,
                    PropertyNameCaseInsensitive = true
                });

                return deserialized;
            }
        }
        catch(Exception e)
        {
            Console.WriteLine($"{e.GetType}: {e.Message}");
        }

        return new T();
    }

    public static string Serialize(PG pg)
    {
        string jsonString = JsonSerializer.Serialize<PG>(pg);
        string path = $"./data/{pg.Name}.json";

        StreamWriter sw = new StreamWriter(path);
        sw.WriteLine(jsonString);
        sw.Close();
        return path;
    }

    public static PG Deserialize(string path)
    {
        StreamReader sr = new StreamReader(path);
        string jsonString = sr.ReadLine();
        sr.Close();
        
        PG pg = JsonSerializer.Deserialize<PG>(jsonString);
        return pg;
    }
}