using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;

namespace ClassesSTP
{
    class Program
    {   


        static void Main(string[] args)
        {

            StudentGroup studentGroup = new StudentGroup();
            int MarksValueArrSize;
            int iterator;
            bool MarksValueArrSizeSuccess = false;
            do
            {
                Console.WriteLine("Введите колличество оцениваемых предметов ");            
                MarksValueArrSizeSuccess = int.TryParse(Console.ReadLine(), out MarksValueArrSize);
            } while (!MarksValueArrSizeSuccess);


            do
            {
                Console.WriteLine("ВЫБЕРИТЕ: \n1-Добавить студента \n2-Найти самого успешного \n3-Найти самого неуспешного \n4-Выйти");
                bool SwitchSuccess = int.TryParse(Console.ReadLine(), out iterator);
                if (SwitchSuccess)
                {
                    switch (iterator)
                    {
                        case 1:
                            var stud = new Student();

                            Console.WriteLine("Введите имя: ");
                            stud.Name = Console.ReadLine();

                            int[] StudMarksArr = new int[MarksValueArrSize];
                            for (int i = 0; i < MarksValueArrSize; i++)
                            {
                                Console.WriteLine("Введите оценку ");
                                bool StudMarksElemSuccess = int.TryParse(Console.ReadLine(),out int StudMarksElem);
                                if (StudMarksElemSuccess)
                                {
                                    StudMarksArr[i] = StudMarksElem;
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка");
                                    break;
                                }
                            }

                            stud.MarksAvg = StudMarksArr.Sum() / MarksValueArrSize;
                            studentGroup.Students.Add(stud);
                            break;
                        case 2:
                            if(!(studentGroup.Students.Count < 1))
                            {
                               var EffStudent = studentGroup.FindMostEfficientStudent();
                                Console.WriteLine("Имя студента с наибольшей успеваемостью " + EffStudent.Name + " \nЕго средний балл " + EffStudent.MarksAvg);
                            }
                            break;
                        case 3:
                            if (!(studentGroup.Students.Count < 1))
                            {
                                var EffStudent = studentGroup.FindMostUnefficientStudent();
                                Console.WriteLine("Имя студента с наименьшей успеваемостью " + EffStudent.Name + " \nЕго средний балл " + EffStudent.MarksAvg);
                            }
                            break;
                    }
                }
            } while (iterator != 4);
           

        }
    }
}
