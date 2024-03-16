using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcUI
{
    public partial class CalculatorUI : Form
    {
        double firstNumber = 0;
        double secondNumber = 0;
        string operation = "";
        bool operationPressed = false;

        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void CalculatorUI_Load(object sender, EventArgs e)
        {

        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            string t = calculatorScreen.Text;
            string res = "";
            for (int i = 0; i < t.Length - 1; i++)
            {
                res += t[i];
            }

            calculatorScreen.Text = res;
        }


        private void CalcScreen_TextChange(object sender, EventArgs e)
        {

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = "";
            firstNumber = 0;
            secondNumber = 0;
        }

        private void CeButton_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = "";
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(calculatorScreen.Text);

            switch (operation)
            {
                case "+":
                    calculatorScreen.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    calculatorScreen.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    calculatorScreen.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    calculatorScreen.Text = (firstNumber / secondNumber).ToString();
                    break;
                default:
                    break;
            }

            operationPressed = false;

        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text == "0")
                calculatorScreen.Text = "";
            Button b = (Button)sender;
            calculatorScreen.Text += b.Text;
        }


        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if(operationPressed == false)
                firstNumber = double.Parse(calculatorScreen.Text);

            calculatorScreen.Text = "";
            operationPressed = true;
            operation = b.Text;


        }

        private void BoobButton_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = "8008";
        }
    }
}
