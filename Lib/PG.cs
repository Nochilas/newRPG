using System;

namespace PGLib
{
    public class PG
    {
        #region Fields

        public int[] Characteristics { get; protected set; } = new int[7];

        #endregion

        #region Methods
        
        //Strenght, dexterity, constitution, size, intelligence, power, charisma
        public PG(int[] charss)
        {
            for(int i = 0; i < Characteristics.Length; i++)
                Characteristics[i] = charss[i];
        }

        public static PG GeneratePG()
        {
            Random rnd = new Random();
            int[] charss = new int[7];

            for(int i = 0; i < charss.Length; i++)
                charss[i] = rnd.Next(8, 18);

            return new PG(charss);
        }

        #endregion
    }
}
