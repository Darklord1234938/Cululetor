using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Calulor : Form
    {
        string some = "";
        int someInt = 0;
        public Calulor()
        {
            InitializeComponent();
        }

        private void Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn1_Click(object sender, EventArgs e)
        {
            some = some +"1";
            AnwerLable.Text = some;
        }

        private void bttn2_Click(object sender, EventArgs e)
        {
            some = some + "2";
            AnwerLable.Text = some;
        }

        private void bttn3_Click(object sender, EventArgs e)
        {
            some = some + "3";
            AnwerLable.Text = some;
        }

        private void bttn4_Click(object sender, EventArgs e)
        {
            some = some + "4";
            AnwerLable.Text = some;
        }

        private void bttn5_Click(object sender, EventArgs e)
        {
            some = some + "5";
            AnwerLable.Text = some;
        }

        private void bttn6_Click(object sender, EventArgs e)
        {
            some = some + "6";
            AnwerLable.Text = some;
        }

        private void bttn7_Click(object sender, EventArgs e)
        {
            some = some + "7";
            AnwerLable.Text = some;
        }

        private void bttn8_Click(object sender, EventArgs e)
        {
            some = some + "8";
            AnwerLable.Text = some;
        }

        private void bttn9_Click(object sender, EventArgs e)
        {
            some = some + "9";
            AnwerLable.Text = some;
        }

        private void bttn0_Click(object sender, EventArgs e)
        {
            some = some + "0";
            AnwerLable.Text = some;
        }

        private void decBttn_Click(object sender, EventArgs e)
        {
            some = some + ",";
            AnwerLable.Text = some;
        }

        private void pluseBttn_Click(object sender, EventArgs e)
        {
            some = some + " + ";
            AnwerLable.Text = some;
        }

        private void minBttn_Click(object sender, EventArgs e)
        {
            some = some + " - ";
            AnwerLable.Text = some;
        }

        private void MultiBttn_Click(object sender, EventArgs e)
        {
            some = some + " * ";
            AnwerLable.Text = some;
        }

        private void divBttn_Click(object sender, EventArgs e)
        {
            some = some + " / ";
            AnwerLable.Text = some;
        }

        private void CEBttn_Click(object sender, EventArgs e)
        {
            some = " ";
            AnwerLable.Text = some;
        }

        private void isBttn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                var result = dt.Compute(some, "");  // Evaluates the math expression
                some = result.ToString();
                AnwerLable.Text = some;
            }
            catch
            {
                AnwerLable.Text = "Error";
                some = "";
            }
        }
    }
}
