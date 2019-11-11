using System;
using System.IO;

namespace Strings
{
    public class StringAnalytics
    {

        private  char[] delimArr = new char[] { ' ', ',', '.', ':' };

        private string Text { get; set; }

        private string[] Words { get; set; }

        string Path { get; set; }


        public StringAnalytics(string Path)
        {
            this.Path = Path;
        }



        public void StreamReader()
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

            foreach (string i in Words)
            {
                i.Trim(delimArr);
                if ((i.Length > 0) && (i.Substring(0, 1).ToLower() == i.Substring(i.Length - 1, 1).ToLower()))
                {
                    specialWordCounter++;

                }

            }
            return specialWordCounter;
        }

    }
}
