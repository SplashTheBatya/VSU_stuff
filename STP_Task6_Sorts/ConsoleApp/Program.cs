using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortUtils;
namespace ConsoleApp
{
    
    class Program
    {


        static void Main(string[] args)
        {
            #region intSort
            List<int> buffList = new List<int>();
            using (StreamReader fs = new StreamReader("IntData.txt")) 
            {
                string data = fs.ReadToEnd();

                string[] Line = data.Split(' ');

                foreach (string i in Line)
                {   
                    if(int.TryParse(i,out int value))
                    {
                        buffList.Add(value);
                    }
                    else
                    {
                        throw new FileLoadException();
                    }
                }
            }
            
            int[] arrayToSort = new int[buffList.Count-1];
            for(int i=0; i< buffList.Count-1;i++)
            {
                arrayToSort[i] = buffList[i];
            }


            int[] originalArr = arrayToSort;
            //foreach (int iter in arrayToSort)
            //{
            //    arrayToSort[iter] = buffList[iter];
            //}

            Console.WriteLine("Пузырёк по возрастанию с делегатом");



            var sortBubleDelegate = Sorts.BubbleSortWithDelegate(arrayToSort, (int item1, int item2) => TypeComparators.IntComparatorAscending(item1, item2));

            foreach (var item in sortBubleDelegate)
            {
                Console.WriteLine(item);
            }


            arrayToSort = originalArr;

            
            Console.WriteLine("\nПузырёк");
            var sortBubble = arrayToSort.BubbleSort();
            foreach (var item in sortBubble)
            {
                Console.WriteLine(item);
            }


            arrayToSort = originalArr;


            Console.WriteLine("\nКвиксорт с делегатом ");

            var sortQuickDelegate = arrayToSort.QuickSortWithDelegate((int item1, int item2) => TypeComparators.IntComparatorAscending(item1, item2));

            foreach (var item in sortQuickDelegate)
            {
                Console.WriteLine(item);
            }


            arrayToSort = originalArr;

            Console.WriteLine("\nКвиксорт");


            var sortQuick = arrayToSort.BubbleSort();
            foreach (var item in sortQuick)
            {
                Console.WriteLine(item);
            }

            arrayToSort = originalArr;


            Console.WriteLine("\nСортировка выбором с делегатом");

            var sortSelectionDelegate = arrayToSort.SelectionSortWithDelegate((int item1, int item2) => TypeComparators.IntComparatorAscending(item1, item2));

            foreach (var item in sortSelectionDelegate)
            {
                Console.WriteLine(item);
            }

            arrayToSort = originalArr;

            Console.WriteLine("\nСортировка выбором");
            var sortSelection = arrayToSort.SelectionSort();

            foreach (var item in sortSelection)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            #endregion

            #region stringSort
            List<string> BuffStringList = new List<string>();
            //using (StreamWriter sw = new StreamWriter("StringData.txt"))
            //{
            //    Random rnd = new Random();
            //    int wordsValue = rnd.Next(5, 10);
            //    List<string> Text = Randomizer.GenRandomStringList("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 5,5);
            //    foreach(string iter in Text)
            //    {
            //        sw.WriteLine(iter);
            //    }
                
                
            //}


            using (StreamReader sr = new StreamReader("StringData.txt"))
            {
                string data = sr.ReadToEnd();

                string[] Line = data.Split(' ', '\n');

                foreach (var item in Line)
                {
                    BuffStringList.Add(item);
                }
            }

            string[] stringArray = new string[BuffStringList.Count-1];
            for (int i = 0; i < BuffStringList.Count - 1; i++)
            {
                stringArray[i] = BuffStringList[i];
            }


            string[] originalArray = stringArray;
            Console.WriteLine("\nСортировка строк методом быстрой сортировки с делегатом");
            var QuickSortWithDelegate = stringArray.QuickSortWithDelegate((string item1, string item2) => string.Compare(item1, item2));
            foreach (var item in QuickSortWithDelegate)
            {
                Console.WriteLine(item);
            }


            stringArray = originalArray;

            Console.WriteLine("\nСортировка строк методом быстрой сортировки");
            var QuickSort = stringArray.QuickSort();
            foreach (var item in QuickSort)
            {
                Console.WriteLine(item);
            }


            stringArray = originalArray;


            Console.WriteLine("\nСортировка строк пузырьком");
            var BubleSort = stringArray.BubbleSort();
            foreach (var item in BubleSort)
            {
                Console.WriteLine(item);
            }

            stringArray = originalArray;

            Console.WriteLine("\nСортировка строк пузырьком с делегатом ");
            var BubleSortDelegate = stringArray.BubbleSortWithDelegate((string item1, string item2) => string.Compare(item1, item2));
            foreach (var item in BubleSortDelegate)
            {
                Console.WriteLine(item);
            }

            stringArray = originalArray;



            Console.WriteLine("\nСортировка строк выбором ");
            var SelectionalSort = stringArray.SelectionSort();
            foreach (var item in SelectionalSort)
            {
                Console.WriteLine(item);
            }

            stringArray = originalArray;

            Console.WriteLine("\nСортировка строк выбором с делегатом");
            var SelectionalSortDelegate = stringArray.SelectionSortWithDelegate((string item1, string item2) => string.Compare(item1, item2));
            foreach (var item in SelectionalSortDelegate)
            {
                Console.WriteLine(item);
            }
            #endregion
            Console.ReadLine();

        }
    }
}
