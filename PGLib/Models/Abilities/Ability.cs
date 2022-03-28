using System;

namespace PGLib.Models;

public class Ability
{
    public int Id { get; set; }
    
    public string Name { get; set; }

    public Chars firstChar { get; set; }

    public Chars secondChar { get; set; }
}