using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortWF
{
    public partial class Form1 : Form
    {

        List<string> BuffStringList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;

            string fileText = System.IO.File.ReadAllText(filename);
            string[] Array = fileText.Split(' ', '\n');
            foreach (var item in Array)
            {
                BuffStringList.Add(item);
            }
            for (int i = 0; i < BuffStringList.Count-1; i++)
            {
                dataGridView1[0,i].Value = BuffStringList[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
