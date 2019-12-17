using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{


    public struct Student
    {
        public string Name { get; set; }
        public double MarksAvg { get; set; }

    }
    public class StudentGroup
    {


        public List<Student> Students { get; set; }



        public StudentGroup()
        {
            Students = new List<Student>();
        }
        public void AddStudent(Student stud)
        {
            Students.Add(stud);
        }



        public Student FindMostEfficientStudent()
        {
            var EffStudent = Students[0];

            for (int i = 0; i < Students.Count; i++)
            {
                if (EffStudent.MarksAvg < Students[i].MarksAvg)
                {
                    EffStudent = Students[i];
                }

            }
            return EffStudent;
        }

        public Student FindMostUnefficientStudent()
        {
            var UneffStudent = Students[0];

            for (int i = 0; i < Students.Count; i++)
            {
                if (UneffStudent.MarksAvg > Students[i].MarksAvg)
                {
                    UneffStudent = Students[i];
                }

            }
            return UneffStudent;
        }

    }
}
