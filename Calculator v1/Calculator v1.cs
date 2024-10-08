namespace Calculator_v1
{
    public partial class Form1 : Form
    {
        private decimal ValueFirst;
        private decimal ValueSecond;
        private decimal result;
        private string operators = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text += ".";
            }
        }
        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text += "0";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "1";
            }
            else
            {
                TxtBox.Text += "1";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "2";
            }
            else
            {
                TxtBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "3";
            }
            else
            {
                TxtBox.Text += "3";
            }
        }

        private void FourBtn_Click_1(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "4";
            }
            else
            {
                TxtBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "5";
            }
            else
            {
                TxtBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "6";
            }
            else
            {
                TxtBox.Text += "6";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "7";
            }
            else
            {
                TxtBox.Text += "7";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "8";
            }
            else
            {
                TxtBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "9";
            }
            else
            {
                TxtBox.Text += "9";
            }
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ValueFirst = decimal.Parse(TxtBox.Text);
                TxtBox.Clear();
                operators = "+";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void MInusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ValueFirst = decimal.Parse(TxtBox.Text);
                TxtBox.Clear();
                operators = "-";
            }
            catch (Exception ex)
            {
                Console.WriteLine(  ex.Message);
            }        
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
            ValueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "*";
            }
            catch (Exception ex )
            {
                 Console.WriteLine (ex.Message);
            }
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            try
            {
            ValueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "/";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operators)
                {
                    case "+":
                        ValueSecond = decimal.Parse(TxtBox.Text);
                        result = ValueFirst + ValueSecond;
                        TxtBox.Text = result.ToString();
                        break;
                    case "-":
                        ValueSecond = decimal.Parse(TxtBox.Text);
                        result = ValueFirst - ValueSecond;
                        TxtBox.Text = result.ToString();
                        break;
                    case "*":
                        ValueSecond = decimal.Parse(TxtBox.Text);
                        result = ValueFirst * ValueSecond;
                        TxtBox.Text = result.ToString();
                        break;
                    case "/":
                        ValueSecond = decimal.Parse(TxtBox.Text);
                        result = ValueFirst / ValueSecond;
                        TxtBox.Text = result.ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }          
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ValueFirst = 0;
            TxtBox.Text = null;
        }
    }
}

