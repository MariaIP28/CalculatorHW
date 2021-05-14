using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {

        CalculationsAndValidations c = new CalculationsAndValidations();
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Numbers_Click(object sender, EventArgs e) //само за визуализация на натиснатите числа/точка
        {

            Button button = (Button)sender; 
            if (button.Text == ".")
            {
                c.MultipleDotsRestrict(tbDisplay);
                return;
            }

            if (tbDisplay.Text=="0"|| tbDisplay.Text == "-0")
            {
                tbDisplay.Text = ""; 
            }
           
            tbDisplay.Text += button.Text;

            if (tbDisplay.Text.IndexOf("∞") != -1)
            {
                c.ModifyIfinity(tbDisplay);
            }
        }

      
        private void Operations_Click(object sender, EventArgs e)
        {
            if (c.HandleFormatEx(tbDisplay))
            {
                return;
            }
          
            Button button = (Button)sender;


            if (c.FirstNum != 0.0d)
            {
                btnEqual.PerformClick(); 
                tbDisplay.Text = "";
                c.Operation = button.Text; 
               
                if (c.Operation == "x√y")
                {
                    string rootOperation=c.ModifyRootLabel();
                    lblCurrentOperation.Text = Convert.ToString(c.FirstNum) + "  " + rootOperation;
                    return;
                }
                lblCurrentOperation.Text = Convert.ToString(c.FirstNum) + "  " + c.Operation;
            }
            else
            {
                c.Operation = button.Text;
                c.FirstNum = double.Parse(tbDisplay.Text);

                tbDisplay.Text = "";
                if (c.Operation == "x√y")
                {
                    string rootOperation = c.ModifyRootLabel();
                    lblCurrentOperation.Text = Convert.ToString(c.FirstNum) + "  " + rootOperation;
                    return;
                }
                lblCurrentOperation.Text = Convert.ToString(c.FirstNum) + "  " + c.Operation;

            }
        }
        private void btnRootSingleValue_Click(object sender, EventArgs e)
        {
 
            if (c.HandleFormatExForBtnSingleSquare(tbDisplay))
            {
                return;
            }
           
            tbDisplay.Text = c.SqrtSingleValue(double.Parse(tbDisplay.Text)).ToString();
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            lblCurrentOperation.Text = "";
         
            if (c.HandleFormatExBtnEqual(tbDisplay))
            {
                return;
            }

            switch (c.Operation)
            {

                case "+":
                    tbDisplay.Text = c.Add(double.Parse(tbDisplay.Text)).ToString(); // за въвеждане на много числа и мн операции
                    break;
                case "-":
                    tbDisplay.Text = c.Subtract(double.Parse(tbDisplay.Text)).ToString();
                    break;
                case "x":
                    tbDisplay.Text = c.Multiply(double.Parse(tbDisplay.Text)).ToString();
                    break;
                case "/":
                    try
                    {
                        tbDisplay.Text = c.Divide(double.Parse(tbDisplay.Text)).ToString();
                    }
                    catch (DivideByZeroException divideByZeroEx)
                    {
                        MessageBox.Show(divideByZeroEx.Message); // няма да възникне, защото когато делим
                                                                 // double / 0 не се хвърля изкл., a връща безкрайност
                        return;
                    }
                    break;
                case "x√y":
                    tbDisplay.Text = c.Sqrt(double.Parse(tbDisplay.Text)).ToString();
                    break;
                case "^":
                    tbDisplay.Text = c.Power(double.Parse(tbDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }

            c.HandleOverflowEx(tbDisplay);
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "0"; 
            lblCurrentOperation.Text = "";
            c.FirstNum = 0;

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "0"; //TUKA
        }

        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (c.FirstNum == 0.0 || tbDisplay.Text == "" || c.FirstNum != 0)
            {
                if (tbDisplay.Text.IndexOf("-") == -1) // ако е било положително да стане отрицателно
                {
                    tbDisplay.Text = "-" + tbDisplay.Text; 
                }
                else if (tbDisplay.Text[0] == '-') // aко е било отрицателно да стане положително
                {
                    tbDisplay.Text = tbDisplay.Text.Remove(0, 1);
                }

            }

        }

        private void Memory_Click(object sender, EventArgs e)
        {
           
            Button button = (Button)sender;
            c.MemoryOperation = button.Text;

            if (c.HandleFormatEx(tbDisplay))
            {
                return;
            }
            

                switch (c.MemoryOperation)
            {
                case "M+":
                    c.MAdd(double.Parse(tbDisplay.Text));
                    btnMC.Enabled = true;
                    btnMR.Enabled = true;
                    break;
                case "M-":
                    c.MSubtract(double.Parse(tbDisplay.Text));
                    btnMC.Enabled = true;
                    btnMR.Enabled = true;
                    break;
                case "MR":
                    double memoryRegisterCurrentValue = c.MemoryRecall();
                    tbDisplay.Text = memoryRegisterCurrentValue.ToString();
                    break;
                case "MC":
                    c.MemoryClear();
                    tbDisplay.Text = "";
                    btnMR.Enabled = false;
                    btnMC.Enabled = false;
                    break;
            }
        }
    }
}
