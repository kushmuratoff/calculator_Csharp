using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        calculator ob=new calculator();
        public void text_boxga()
        {
            ob.text_b(textBox1,textBox2);
        }
        private void button29_Click(object sender, EventArgs e)
        {
            //bir button
            ob.sonlar("1");
            text_boxga();

        }

        private void button28_Click(object sender, EventArgs e)
        {
            //ikki button
            ob.sonlar("2");
            text_boxga();

        }

        private void button27_Click(object sender, EventArgs e)
        {
            //uch button
            ob.sonlar("3");
            text_boxga();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //to'rt button
            ob.sonlar("4");
            text_boxga();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //besh button
            ob.sonlar("5");
            text_boxga();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //olti button
            ob.sonlar("6");
            text_boxga();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //yetti button
            ob.sonlar("7");
            text_boxga();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //sakkiz button
            ob.sonlar("8");
            text_boxga();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //to'qqiz button
            ob.sonlar("9");
            text_boxga();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            //vergul button
            ob.sonlar(",");
            text_boxga();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            //qushish button
            ob.amal_q();
            text_boxga();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //ayrish button
            ob.amal_a();
            text_boxga();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kupaytrish button
            ob.amal_k();
            text_boxga();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //bo'lish button
            ob.amal_b();
            text_boxga();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            // natija = button
            ob.natija_teng();
            text_boxga();


        }

        private void button13_Click(object sender, EventArgs e)
        {
            //ortga button
            ob.ortga();
            text_boxga();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //CE button
            ob.ce_btn();
            text_boxga();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //C button
            ob.c_btn();
            text_boxga();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //ishora button
            ob.ishora_btn();
            text_boxga();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //1/x button
            ob.butun_btn();
            text_boxga();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //ildiz button
            ob.ildiz_btn();
            text_boxga();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //faktorial button
            ob.fak_btn();
            text_boxga();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //sin button
            ob.sin_btn();
            text_boxga();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //cos button
            ob.cos_btn();
            text_boxga();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //tan button
            ob.tan_btn();
            text_boxga();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //tenpow button
            ob.ten_btn();
            text_boxga();
        }


        
    }
}
