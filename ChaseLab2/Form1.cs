using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaseLab2
/*Brayden Chase
 September 30th 2022
 This program is about my cat Mini. It shows you a picture of her and can also do multiplication*/
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This closes the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //This will show the picture
        private void btnPicture_Click(object sender, EventArgs e)
        {
            picCat.Show();
            lblDescription.Visible = false; 
        }
        //This will hide Picture and Description
        private void btnHide_Click(object sender, EventArgs e)
        {
            picCat.Visible = false;
            lblDescription.Visible = false;
        }
        //This will clear Number box, Multiplier box, and Answer box
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMultiplier.Text = "";
            txtNumber.Text = "";
            lblAnswer.Text = "";
            //this will return curson to number box
            txtNumber.Focus();
        }
        //This will show you a description of my cat Mini
        private void btnData_Click(object sender, EventArgs e)
        {
            
            picCat.Visible = false;
            lblDescription.Visible = true;
            lblDescription.Text = "My topic is " + lblTopic.Text + "\n\n\nMini is a great cat. She is very fluffy and loves to cuddle. She just turned 10 this fall.  She usually hangs out in my office with me as I do my school work; sometimes she will remind me to take a break from it to give her attention. " +
                "\n\nI am thankful to have met such a purrfect cat.  She is my bestfriend."; 
               
        }
        //This will tell you more about Mini when you click on the picture
        private void picCat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("She has big green eyes", "Brayden Chase");
        }
        //This will multiply your number by multiplier and show your answer
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);
            int multiplier = Convert.ToInt32(txtMultiplier.Text);
            int answer = number * multiplier;
            lblAnswer.Text = Convert.ToString(answer);
        }
    }
 
}


