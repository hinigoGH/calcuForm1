
using System.Data;

namespace calcuForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1;
        double num2;
        string option;
        double results;
        string temp;
        private void AppendDigit(string digit)
        {
            temp += digit;
            textBox1.Text += digit;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AppendDigit("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AppendDigit("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AppendDigit("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AppendDigit("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AppendDigit("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AppendDigit("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AppendDigit("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AppendDigit("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AppendDigit("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AppendDigit("0");
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            //textBox1.Text = new DataTable().Compute(temp, "").ToString();
            //label1.Text = temp;
            try
            {
                if (!string.IsNullOrEmpty(temp))
                {
                    DataTable dt = new DataTable();
                    object result = dt.Compute(temp, "");
                    textBox1.Text = result.ToString();
                    label1.Text = temp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            option = "+";
            AppendDigit("+");
            // num1 = double.Parse(textBox1.Text);
            //textBox1.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            option = "-";
            AppendDigit("-");

            // num1 = double.Parse(textBox1.Text);
            //textBox1.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            AppendDigit("*");
            if (option == "*") { }


            /* num1 = double.Parse(textBox1.Text);
             textBox1.Clear();*/
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            AppendDigit("/");
            //num1 = double.Parse(textBox1.Text);
            //textBox1.Clear();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            results = 0;
            num1 = 0;
            num2 = 0;
            temp = "";
            //textBox1.Text="";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            /*if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }*/
            AppendDigit(".");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            temp = temp.Remove(temp.Length - 1);
            textBox1.Text = temp;
        }

        private void btnParenL_Click(object sender, EventArgs e)
        {
            AppendDigit("(");
        }

        private void btnparenRight_Click(object sender, EventArgs e)
        {
            AppendDigit(")");
        }
    }
}
