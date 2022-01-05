using System;

namespace PGLib
{
    public class Bard : PG
    {
        public Bard()
            : base() {}

        public Bard(int[] charss)
            : base(charss)
        {}

        protected override PG Generate()
        {
            // Generation of some new chars.
            // Maybe add a static function in the PG class just for this?
            Random rnd = new Random();
            int[] charss = new int[7];

            for(int i = 0; i < charss.Length; i++)
                charss[i] = rnd.Next(8, 18);
            
            Bard b = new Bard(charss);
            // Access with indexers to chars to add some random mods to them
            b[Chars.Charisma]++;
            b[Chars.Strength]--;

            // Boxing a Bard into a PG instance since PG it's the return type
            return b;
        }
    }
}
