using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings
{
    public partial class Form1 : Form
    {
        StringAnalytics stringAnalytics = new StringAnalytics(@"C:\Users\User\Desktop\text.txt");



        public Form1()
        {
            InitializeComponent();
        }


        private void ReadFile_Click(object sender, EventArgs e)
        {

            try
            {
                richTextBox.Text = stringAnalytics.ShowText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }

        }

        private void ButtonForCount_Click(object sender, EventArgs e)
        {
            try
            {
                stringAnalytics.StreamReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }

             TextBoxResult.Text = stringAnalytics.SpecialWordCounter().ToString();
        }

    }
}
