using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySTP_task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var array = new List<double>();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   

            double result;
            string str = TEXTBOXFORTEXTBLYAT.Text;
            if (!double.TryParse(str, out result))
            {
                MessageBox.Show("НУ СЯДЬТЕ ПОСМОТРИТЕ,ПОТОМ ПОДОЙДЁТЕ ");
                return;
            }
            else
            {
                dataGridView1.Rows.Add(double.Parse(str));
            }
            
            

            
        }
    }
}
