using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsConsole
{
    public class StringAnalyticsConsole
    {

        private char[] delimArr = new char[] { ' ', ',', '.', ':' };

        private string Text { get; set; }

        private string[] Words { get; set; }

        string Path { get; set; }


        public StringAnalyticsConsole(string Path)
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

            StreamReader();
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
            StreamReader();
            int specialWordCounter = 0;

            foreach (string i in Words)
            {
                i.Trim(delimArr);
                if ((i.Length > 1) && (i.Substring(0, 1).ToLower() == i.Substring(i.Length - 1, 1).ToLower()))
                {
                    specialWordCounter++;
                }

            }
            return specialWordCounter;
        }

        public List<string> SpecialWordShow()
        {
            StreamReader();
            var list = new List<string>();

            foreach (string i in Words)
            {
                i.Trim(delimArr);
                if ((i.Length > 1) && (i.Substring(0, 1).ToLower() == i.Substring(i.Length - 1, 1).ToLower()))
                {
                    list.Add(i);
                }

            }
            return list;
        }
    }
}
