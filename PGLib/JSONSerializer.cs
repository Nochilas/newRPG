using System;
using System.Text.Json;
using System.IO;
using PGLib.Models;

namespace PGLib;
public static class JSONSerializer
{
    public static void Serialize(PG pg)
    {
        string jsonString = JsonSerializer.Serialize<PG>(pg);

        StreamWriter sw = new StreamWriter($"./data/{pg.Name}.json");
        sw.WriteLine(jsonString);
        sw.Close();
    }

    public static PG Deserialize(string name)
    {
        string path = $"./data/{name}.json";
        StreamReader sr = new StreamReader(path);
        string jsonString = sr.ReadLine();
        sr.Close();
        
        PG pg = JsonSerializer.Deserialize<PG>(jsonString);
        return pg;
    }
}