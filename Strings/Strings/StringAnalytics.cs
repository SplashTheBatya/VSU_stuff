using System;
using System.IO;

namespace Strings
{
    public class StringAnalytics
    {
        private string Text { get; set; }

        private string[] Words { get; set; }

        string Path { get; set; }


        public StringAnalytics(string Path)
        {
            this.Path = Path;
        }



        public void StreamReader()
        {
            char[] delimArr = new char[] { ' ', ',', '.', ':' };
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    Text = sr.ReadToEnd().ToString();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            if (Text.Length != 0)
            {
                Words = Text.Split(delimArr);
            }
        }

        public string ShowText()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    Text = sr.ReadToEnd().ToString();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return Text;
        }


        public int SpecialWordCounter()
        {
            int specialWordCounter = 0;
            var buffer = new char[0];
            foreach (string i in Words)
            {
                buffer = i.ToCharArray();
                if (i[0] == i[buffer.Length - 1])
                {
                    specialWordCounter++;
                }

            }
            return specialWordCounter;
        }

    }
}
