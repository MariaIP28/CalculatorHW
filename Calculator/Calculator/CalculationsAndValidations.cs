using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Calculator
{
    public class CalculationsAndValidations
    {
        public double FirstNum { get; set; }
        public string Operation { get;set; }
        private double Memory { get; set; }
        public string MemoryOperation { get; set; }
 
        
        // b is the second input, and every other new input
        
        //---calculations---
        public double Add(double b)
        {
            return FirstNum + b;
        }

        public double Subtract(double b)
        {
            return FirstNum- b;
        }
        public double Multiply(double b)
        {
            return FirstNum * b;
        }

        public double Divide(double b)
        {
           // prevent from NaN
            if (FirstNum==0 && b==0)
            {
                return 0;
            }
           return FirstNum / b;

        }

        public double SqrtSingleValue(double b)
        {  
            //проверка дали числото което ще се коренува е отрицателно ->NaN
            if (b < 0)
            {
                return -1 * Math.Sqrt(Math.Abs(b));
            }
            return Math.Sqrt(b);
        }
        public double Sqrt(double b)
        {
            //проверка дали числото което ще се коренува е отрицателно ->NaN
            if (b<0)
            {
                return -1 * FirstNum * Math.Sqrt(Math.Abs(b));
            }
            return FirstNum * Math.Sqrt(b); //???????????????????????????
        }
        public string ModifyRootLabel()
        {
            return Operation.Substring(1, 1);
        }
        public double Power(double b)
        {
            if (FirstNum<0)
            {
                return -1 * Math.Pow(Math.Abs(FirstNum), b);
            }
            return Math.Pow(FirstNum, b);
        }

        public double MemoryRecall()
        {
            return Memory;
        }

        public void MemoryClear()
        {
            Memory = 0.0;
        }

        public void MAdd(double b)
        {
             Memory += b;
        }

        public void MSubtract(double b)
        {
            Memory -= b;
        }
        //---validations---
        public void MultipleDotsRestrict( TextBox tb)
        {
            if (tb.Text.IndexOf(".") == -1)
            {
                tb.Text += ".";
            }
        }
        
        public void ModifyIfinity(TextBox tb)
        {
            tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);  
        }
        public bool HandleFormatExBtnEqual(TextBox tb)
        {
            try
            {
                double.Parse(tb.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid operation!Please, enter new numbers", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tb.Text = "";
                FirstNum = 0; // за да ми занулява още първия input и всичко да почва отначало;
                return true;
            }
           return false;
        }
        public bool HandleFormatExForBtnSingleSquare(TextBox tb)
        {
            try
            {
                double.Parse(tb.Text);

            }
            catch (FormatException)
            {

                MessageBox.Show("First enter a number, second enter '√' ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb.Text = "";
                return true;

            }
            return false;
           
        }
        public bool HandleFormatEx(TextBox tb)
        {
            try
            {
                double.Parse(tb.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, enter a valid number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return true;
            }
            return false;
        }
        public void HandleOverflowEx(TextBox tb)
        {
            try
            {
                FirstNum = double.Parse(tb.Text);
                Operation = "";
            }


            catch (OverflowException)
            {
                MessageBox.Show("Entered number is too big.Please,enter smaller number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tb.Text = "";
                FirstNum = 0;
                return;
            }
          
        }

    }
}

