using SortUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortWF
{
    public partial class Form1 : Form
    {

        List<string> BuffStringList = new List<string>();
        List<int> BuffIntList = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }



        private void QuickSortDelegatedBtn_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            string[] stringArray = new string[BuffStringList.Count - 1];
            for (int i = 0; i < BuffStringList.Count - 1; i++)
            {
                stringArray[i] = BuffStringList[i];
            }
            List<string> buff = new List<string>();
            var QuickSortWithDelegate = stringArray.QuickSortWithDelegate((string item1, string item2) => string.Compare(item1, item2));
            foreach (var item in QuickSortWithDelegate)
            {
                buff.Add(item);
            }
            dataGridView1.RowCount = buff.Count;
            for (int i = 0; i < buff.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = buff[i];
            }
        }

        private void IntQuickSortBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            BuffIntList.Clear();
            List<int> buff = new List<int>();
            foreach (string i in BuffStringList)
            {
                if (int.TryParse(i, out int value))
                {
                    BuffIntList.Add(value);
                }
                else
                {
                    MessageBox.Show("не, не пашет ");
                }
            }
            int[] arrayToSort = new int[BuffIntList.Count - 1];
            for (int i = 0; i < BuffIntList.Count - 1; i++)
            {
                arrayToSort[i] = BuffIntList[i];
            }
            var sortQuickDelegate = arrayToSort.QuickSortWithDelegate((int item1, int item2) => TypeComparators.IntComparatorAscending(item1, item2));
            foreach (var item in sortQuickDelegate)
            {
                buff.Add(item);
            }
            dataGridView1.RowCount = buff.Count;
            for (int i = 0; i < buff.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = buff[i];
            }

        }

        private void SaveFileBtn_Click(object sender, EventArgs e)
        {

            List<string> ShowList = new List<string>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                ShowList.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;


            File.WriteAllLines(filename, ShowList.ToArray());

        }

        private void GetDataFromFileBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;

            string fileText = File.ReadAllText(filename);
            string[] Array = fileText.Split(' ', '\n');
            foreach (var item in Array)
            {
                BuffStringList.Add(item);
            }
            dataGridView1.RowCount = BuffStringList.Count;
            for (int i = 0; i < BuffStringList.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = BuffStringList[i];
            }
        }
    }
}
