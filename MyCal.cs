using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bscs22017_SciCal
{
    public partial class MyCal : Form
    {
        bool isFirst = true;
        int op1, op2;
        double op3;
        //double op4;
        string op;
        public MyCal()
        {
            InitializeComponent();
        }

        private void MyCal_Load(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                screen.Text = "";
                isFirst = false;
            }
            screen.Text += "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            if(isFirst)
            {
                screen.Text = "";
                isFirst = false;
            }
            screen.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                screen.Text = "";
                isFirst = false;
            }
            screen.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                screen.Text = "";
                isFirst = false;
            }
            screen.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                screen.Text = "";
                isFirst = false;
            }
            screen.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                screen.Text = "";
                isFirst = false;
            }
            screen.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                screen.Text = "";
                isFirst = false;
            }
            screen.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                screen.Text = "";
                isFirst = false;
            }
            screen.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                screen.Text = "";
                isFirst = false;
            }
            screen.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                screen.Text = "";
                isFirst = false;
            }
            screen.Text += "9";
        }

        private void ans_Click(object sender, EventArgs e)////////////
        {
            op2 = int.Parse(screen.Text);
            op3 =double.Parse(screen.Text);
            
            
            switch(op)
            {
                case "+":
                    screen.Text = (op1 + op2).ToString();
                    break;
                case "-":
                    screen.Text = (op1 - op2).ToString();
                    break;
                case "*":
                    screen.Text = (op1 * op2).ToString();
                    break;
                case "/":
                    //screen.Text = double(op1 / op2).ToString();
                    screen.Text = (op1 / op3).ToString();
                    break;
                case "%":
                    screen.Text = (op1 % op2).ToString();
                    break;
                case "cos":
                    screen.Text = (Math.Cos(op3)).ToString();
                    break;
                case "sin":
                    screen.Text = (Math.Sin(op3)).ToString();
                    break;
                case "tan":
                    screen.Text = (Math.Tan(op3)).ToString();
                    break;
                case "pow":
                    screen.Text = (Math.Pow(op1,op2)).ToString();
                    break;
                case "log":
                    screen.Text = (Math.Log10(op3)).ToString();
                    break;
                //case "clr":
                //    screen.Clear();
                //    break;
                case "sqr":
                    screen.Text = (Math.Pow(op1, 2)).ToString();
                    break;
                //case "del":
                //    if (screen.Text.Length > 0)
                //    {
                //        screen.Text = screen.Text.Remove(screen.Text.Length - 1);
                //    }
                //    //screen.Text=(op1/10).ToString();
                //    break;
                case "fact":
                    int res = 1;
                    for(int i=2;i<=op1;i++)
                    {
                        res *= i;
                    }
                    screen.Text = res.ToString(); ;
                    break;
                case "oneby":
                    screen.Text = (1/op3).ToString();
                    break;
                case "sqrt":
                    screen.Text = (Math.Sqrt(op3)).ToString();
                    break;
                case "ln":
                    screen.Text = (Math.Log(op3)).ToString();
                    break;
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            op = "+";
            isFirst = true;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            op = "-";
            isFirst = true;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            op = "*";
            isFirst = true;
        }

        private void div_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            op = "/";
            isFirst = true;
        }

        private void mod_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            op = "%";
            isFirst = true;
        }

        private void plusmin_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            screen.Text = (op1 * (-1)).ToString();
            isFirst = true;
        }

        private void sin_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "sin";
            isFirst = true;
        }

        private void cos_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "cos";
            isFirst = true;
        }

        private void tan_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "tan";
            isFirst = true;
        }

        private void log_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "log";
            isFirst = true;
        }

        private void power_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            op = "pow";
            isFirst = true;
        }

        private void sqr_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            op = "sqr";
            isFirst = true;
        }

        private void remove_Click(object sender, EventArgs e)
        {
           // op1 = int.Parse(screen.Text);
            //op = "del";
            if (screen.Text.Length > 0)
            {
                screen.Text = screen.Text.Remove(screen.Text.Length - 1);
            }
            //isFirst = true;
        }

        private void fact_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            op = "fact";
            isFirst = true;
        }

        private void oneby_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "oneby";
            isFirst = true;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "sqrt";
            isFirst = true;
        }

        private void NLog_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "ln";
            isFirst = true;
        }

        private void Clr_Click(object sender, EventArgs e)
        {
            //op = "clr";
            //isFirst = true;
            //case "clr":
            screen.Clear();
            //    break;
        }

    }
}
