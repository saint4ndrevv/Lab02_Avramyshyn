using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02_Avramyshyn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strP = textBox_P.Text;
            int intP = Convert.ToInt32(strP, 2);
            string strKey = textBox_Key.Text;
            int intKey = Convert.ToInt32(strKey, 2);
            int intC = intP ^ intKey;
            string strC = Convert.ToString(intC, 2);
            textBox_C.Text = strC;

            int int2code = intP ^ intKey;
            string str2code = Convert.ToString(int2code, 2);
            textBox_2code.Text = str2code;

            int int10code = intP ^ intKey;
            string str10code = Convert.ToString(int10code, 10);
            textBox_10code.Text = str10code;

            int int16code = intP ^ intKey;
            string str16code = Convert.ToString(int16code, 16);
            textBox_16code.Text = str16code;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_Key.Text = "";
            textBox_C.Text = "";
            textBox_2code.Text = "";
            textBox_10code.Text = "";
            textBox_16code.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_Key.Text = "";
            textBox_C.Text = "";
            textBox_2code.Text = "";
            textBox_10code.Text = "";
            textBox_16code.Text = "";
        }
    }
}
