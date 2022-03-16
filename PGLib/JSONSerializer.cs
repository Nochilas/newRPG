using System;
using System.Text.Json;
using System.IO;
using PGLib.Models;

namespace PGLib;
public static class JSONSerializer
{
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