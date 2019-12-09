using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentLibrary;

namespace ClassesSTP_WF
{
    public partial class Form1 : Form
    {

        StudentGroup studentGroup = new StudentGroup();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {

            var stud = new Student();
            char[] delim = new char[] { ' ', ',' };
            bool ErrorCatch = false;
            string[] textMarksBuff = MarksBox.Text.Split(delim);
            int[] StudMarksArr = new int[textMarksBuff.Length];
            for (int i = 0; i < textMarksBuff.Length; i++)
            {
                int result;
                if (!int.TryParse(textMarksBuff[i], out result))
                {
                    ErrorCatch = true;
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Ошибка");
                    break;
                }
                else
                {

                    StudMarksArr[i] = result;
                }

            }
            if (!ErrorCatch)
            {
                stud.Name = NameBox.Text;
                stud.MarksAvg = StudMarksArr.Sum() / StudMarksArr.Length;
                studentGroup.Students.Add(stud);
            }

        }

        private void ShowMostEffStud_Click(object sender, EventArgs e)
        {
            if (studentGroup.Students.Count != 0)
            {
                var EffStudent = studentGroup.FindMostEfficientStudent();
                MaxAvgResultShowBox.Text = EffStudent.Name + " " + EffStudent.MarksAvg;
            }
        }

        private void ShowLessEffStud_Click(object sender, EventArgs e)
        {
            if (studentGroup.Students.Count != 0)
            {
                var UnEffStudent = studentGroup.FindMostUnefficientStudent();
                MinAvgResultShowBox.Text = UnEffStudent.Name + " " + UnEffStudent.MarksAvg;
            }

        }
    }
}
