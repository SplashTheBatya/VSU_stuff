using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortUtils
{
    public static class Randomizer
    {
        public static List<string> GenRandomStringList(string Alphabet, int WordLength,int ListSize)
        {
            var List = new List<string>();
            for(int i = 0;i<ListSize - 1;i++)
            {
                Random rnd = new Random();

                StringBuilder sb = new StringBuilder(WordLength - 1);

                int Position = 0;
                for (int iter = 0; iter < WordLength; iter++)
                {
                    Position = rnd.Next(0, Alphabet.Length - 1);
                    sb.Append(Alphabet[Position]);
                }
                List.Add(sb.ToString());

            }
            //Random rnd = new Random();

            //StringBuilder sb = new StringBuilder(WordLength - 1);

            //int Position = 0;
            //for (int i = 0; i < WordLength; i++)
            //{
            //    Position = rnd.Next(0, Alphabet.Length - 1);
            //    sb.Append(Alphabet[Position]);
            //}
            return List;
        }

    }
}
