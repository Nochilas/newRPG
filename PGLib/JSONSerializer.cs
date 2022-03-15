using System;
using System.Text.Json;
using System.IO;
using PGLib.Models;

namespace PGLib;
public static class JSONSerializer
{
    public static string Serialize(CharacterClass pg)
    {
        string jsonString = JsonSerializer.Serialize<CharacterClass>(pg);
        string path = $"./data/{pg.Name}.json";

        StreamWriter sw = new StreamWriter(path);
        sw.WriteLine(jsonString);
        sw.Close();
        return path;
    }

    public static CharacterClass Deserialize(string path)
    {
        StreamReader sr = new StreamReader(path);
        string jsonString = sr.ReadLine();
        sr.Close();
        
        CharacterClass pg = JsonSerializer.Deserialize<CharacterClass>(jsonString);
        return pg;
    }
}