using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double num = 0;
        private double res = 0;

        private string numTmp = String.Empty;
        private string operation = String.Empty;

        public Form1()
        {
            InitializeComponent();

            equationTextBox.Enabled = false;
            resultTextBox.Enabled = false;
        }


        private void SomeMethod(object sender, EventArgs e)
        {
            try
            {
                Button b = (sender as Button);

                if (b.Text == "0" || b.Text == "1" || b.Text == "2" || b.Text == "3" || b.Text == "4" || b.Text == "5" || b.Text == "6" || b.Text == "7" || b.Text == "8" || b.Text == "9")
                {
                    if (res == 0) res = num;

                    numTmp += b.Text;
                    equationTextBox.Text += b.Text;
                }

                else if (b.Text == ",")
                {
                    numTmp += ".";
                    equationTextBox.Text += b.Text;
                }

                else
                {
                    if (resultTextBox.Text != String.Empty) res = Convert.ToDouble(resultTextBox.Text);

                    if (numTmp != String.Empty) num = Convert.ToDouble(numTmp);


                    if (b.Text == "+" || b.Text == "-" || b.Text == "x" || b.Text == "/" || b.Text == "%")
                    {
                        operation = b.Text;
                        equationTextBox.Text += " " + b.Text + " ";
                    }

                    numTmp = string.Empty;

                    if (operation == "+") res += num;
                    else if (operation == "-") res -= num;
                    else if (operation == "x") res *= num;
                    else if (operation == "/" && num != 0) res /= num;
                    else if (operation == "%" && num != 0) res = res / 100 * num;

                    if (b.Text == "=")
                    {
                        resultTextBox.Text = res.ToString();
                        num = 0;
                    }

                    else if (b.Text == "C")
                    {
                        equationTextBox.Text = String.Empty;
                        num = 0;
                        res = 0;
                    }
                    else if (b.Text == "CE")
                    {
                        equationTextBox.Text = String.Empty;
                        resultTextBox.Text = String.Empty;
                        num = 0;
                        res = 0;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
