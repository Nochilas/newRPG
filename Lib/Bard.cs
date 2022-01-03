using System;

namespace PGLib
{
    class Bard : PG
    {
        public Bard(int str, int dex) : base(str, dex)
        {
            Strength = str;
            Dexterity = dex;
        }
    }
}
