using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tickcross
{
    public partial class Form1 : Form
    {
        int[] s = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked){
                button1.BackgroundImage = Properties.Resources.Untitled23;                
                radioButton2.Checked = true;
                s[1] =1;

            } else if(radioButton2.Checked ){

                button1.BackgroundImage = Properties.Resources.Untitled24;                
                radioButton1.Checked = true;
                s[1] = 2;
            }

            button1.Enabled = false; func();
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button2.BackgroundImage = Properties.Resources.Untitled23;
                radioButton2.Checked = true;
                s[2] = 1;

            }
            else if (radioButton2.Checked)
            {

                button2.BackgroundImage = Properties.Resources.Untitled24;
                radioButton1.Checked = true;
                s[2] = 2;
            }

            button2.Enabled = false; func();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button3.BackgroundImage = Properties.Resources.Untitled23;
                radioButton2.Checked = true;
                s[3] = 1;
            }
            else if (radioButton2.Checked)
            {

                button3.BackgroundImage = Properties.Resources.Untitled24;
                radioButton1.Checked = true;
                s[3] = 2;
            }

            button3.Enabled = false; func();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button6.BackgroundImage = Properties.Resources.Untitled23;
                radioButton2.Checked = true;
                s[6] = 1;
            }
            else if (radioButton2.Checked)
            {

                button6.BackgroundImage = Properties.Resources.Untitled24;
                radioButton1.Checked = true;
                s[6] = 2;
            }

            button6.Enabled = false; func();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button5.BackgroundImage = Properties.Resources.Untitled23;
                radioButton2.Checked = true;
                s[5] = 1;
            }
            else if (radioButton2.Checked)
            {

                button5.BackgroundImage = Properties.Resources.Untitled24;
                radioButton1.Checked = true;
                s[5] = 2;
            }

            button5.Enabled = false; func();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button4.BackgroundImage = Properties.Resources.Untitled23;
                radioButton2.Checked = true;
                s[4] = 1;
            }
            else if (radioButton2.Checked)
            {

                button4.BackgroundImage = Properties.Resources.Untitled24;
                radioButton1.Checked = true;
                s[4] = 2;
            }

            button4.Enabled = false; func();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button9.BackgroundImage = Properties.Resources.Untitled23;
                radioButton2.Checked = true;
                s[9] = 1;
            }
            else if (radioButton2.Checked)
            {

                button9.BackgroundImage = Properties.Resources.Untitled24;
                radioButton1.Checked = true;
                s[9] = 2;
            }

            button9.Enabled = false; func();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button8.BackgroundImage = Properties.Resources.Untitled23;
                radioButton2.Checked = true;
                s[8] = 1;
            }
            else if (radioButton2.Checked)
            {

                button8.BackgroundImage = Properties.Resources.Untitled24;
                radioButton1.Checked = true;
                s[8] = 2;
            }

            button8.Enabled = false; func();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button7.BackgroundImage = Properties.Resources.Untitled23;
                radioButton2.Checked = true;
                s[7] = 1;
            }
            else if (radioButton2.Checked)
            {

                button7.BackgroundImage = Properties.Resources.Untitled24;
                radioButton1.Checked = true;
                s[7] = 2;
            }

            button7.Enabled = false;
            func();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackgroundImage = null;


            button2.Enabled = true;
            button2.BackgroundImage = null;


            button3.Enabled = true;
            button3.BackgroundImage = null;


            button4.Enabled = true;
            button4.BackgroundImage = null;


            button5.Enabled = true;
            button5.BackgroundImage = null;


            button6.Enabled = true;
            button6.BackgroundImage = null;


            button7.Enabled = true;
            button7.BackgroundImage = null;


            button8.Enabled = true;
            button8.BackgroundImage = null;


            button9.Enabled = true;
            button9.BackgroundImage = null;                        
        for(int i=0;i<10;i++){
            s[i] = 0;
        }
        }

        int p1 = 0, p2 = 0;

        void func() { 

            if(
                s[1] == 1 && s[2] == 1 && s[3] == 1 ||
                s[4] == 1 && s[5] == 1 && s[6] == 1 ||
                s[7] == 1 && s[8] == 1 && s[9] == 1 ||

                s[1] == 1 && s[4] == 1 && s[7] == 1 ||
                s[2] == 1 && s[5] == 1 && s[8] == 1 ||
                s[3] == 1 && s[6] == 1 && s[9] == 1 ||

                s[1] == 1 && s[5] == 1 && s[9] == 1 ||
                s[3] == 1 && s[5] == 1 && s[7] == 1    ){
                
                p1++;
                p1Score.Text = p1.ToString();
                disableAll();

            }else  if(
                s[1] == 2 && s[2] == 2 && s[3] == 2 ||
                s[4] == 2 && s[5] == 2 && s[6] == 2 ||
                s[7] == 2 && s[8] == 2 && s[9] == 2 ||

                s[1] == 2 && s[4] == 2 && s[7] == 2 ||
                s[2] == 2 && s[5] == 2 && s[8] == 2 ||
                s[3] == 2 && s[6] == 2 && s[9] == 2 ||

                s[1] == 2 && s[5] == 2 && s[9] == 2 ||
                s[3] == 2 && s[5] == 2 && s[7] == 2)
            {

                p2++;
                p2Score.Text = p2.ToString();
                disableAll();           
            }
            
        }// func end here

        void disableAll() {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




    }


}
