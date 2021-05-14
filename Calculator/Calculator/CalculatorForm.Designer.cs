
namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.lblCurrentOperation = new System.Windows.Forms.Label();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMAdd = new System.Windows.Forms.Button();
            this.btnMSubtract = new System.Windows.Forms.Button();
            this.btnChangeSign = new System.Windows.Forms.Button();
            this.btnRootSingleValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDisplay.Location = new System.Drawing.Point(24, 41);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(498, 34);
            this.tbDisplay.TabIndex = 42;
            this.tbDisplay.Text = "0";
            this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(360, 371);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(78, 67);
            this.btnMinus.TabIndex = 41;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.Operations_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(276, 371);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(78, 67);
            this.btnPlus.TabIndex = 40;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.Operations_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDot.Location = new System.Drawing.Point(192, 371);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(78, 67);
            this.btnDot.TabIndex = 39;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEqual.Location = new System.Drawing.Point(444, 152);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(78, 286);
            this.btnEqual.TabIndex = 38;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZero.Location = new System.Drawing.Point(24, 371);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(162, 67);
            this.btnZero.TabIndex = 37;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivide.Location = new System.Drawing.Point(360, 298);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(78, 67);
            this.btnDivide.TabIndex = 36;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.Operations_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiply.Location = new System.Drawing.Point(276, 298);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(78, 67);
            this.btnMultiply.TabIndex = 35;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.Operations_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(192, 298);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(78, 67);
            this.btn3.TabIndex = 34;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(108, 298);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(78, 67);
            this.btn2.TabIndex = 33;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(24, 298);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(78, 67);
            this.btn1.TabIndex = 32;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // btnPow
            // 
            this.btnPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPow.Location = new System.Drawing.Point(360, 225);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(78, 67);
            this.btnPow.TabIndex = 31;
            this.btnPow.Text = "^";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.Operations_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRoot.Location = new System.Drawing.Point(276, 225);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(78, 33);
            this.btnRoot.TabIndex = 30;
            this.btnRoot.Text = "x√y";
            this.btnRoot.UseVisualStyleBackColor = true;
            this.btnRoot.Click += new System.EventHandler(this.Operations_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.Location = new System.Drawing.Point(192, 225);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(78, 67);
            this.btn6.TabIndex = 29;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.Location = new System.Drawing.Point(108, 225);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(78, 67);
            this.btn5.TabIndex = 28;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.Location = new System.Drawing.Point(24, 225);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(78, 67);
            this.btn4.TabIndex = 27;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnC.Location = new System.Drawing.Point(360, 152);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(78, 67);
            this.btnC.TabIndex = 26;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCE.Location = new System.Drawing.Point(276, 152);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(78, 67);
            this.btnCE.TabIndex = 25;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn9.Location = new System.Drawing.Point(192, 152);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(78, 67);
            this.btn9.TabIndex = 24;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.Location = new System.Drawing.Point(108, 152);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(78, 67);
            this.btn8.TabIndex = 23;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.Location = new System.Drawing.Point(24, 152);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(78, 67);
            this.btn7.TabIndex = 22;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // lblCurrentOperation
            // 
            this.lblCurrentOperation.AutoSize = true;
            this.lblCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentOperation.Location = new System.Drawing.Point(174, 9);
            this.lblCurrentOperation.Name = "lblCurrentOperation";
            this.lblCurrentOperation.Size = new System.Drawing.Size(0, 29);
            this.lblCurrentOperation.TabIndex = 43;
            this.lblCurrentOperation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnMC
            // 
            this.btnMC.Enabled = false;
            this.btnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMC.Location = new System.Drawing.Point(24, 79);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(78, 67);
            this.btnMC.TabIndex = 44;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.Memory_Click);
            // 
            // btnMR
            // 
            this.btnMR.Enabled = false;
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMR.Location = new System.Drawing.Point(108, 79);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(78, 67);
            this.btnMR.TabIndex = 45;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.Memory_Click);
            // 
            // btnMAdd
            // 
            this.btnMAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMAdd.Location = new System.Drawing.Point(192, 79);
            this.btnMAdd.Name = "btnMAdd";
            this.btnMAdd.Size = new System.Drawing.Size(78, 67);
            this.btnMAdd.TabIndex = 46;
            this.btnMAdd.Text = "M+";
            this.btnMAdd.UseVisualStyleBackColor = true;
            this.btnMAdd.Click += new System.EventHandler(this.Memory_Click);
            // 
            // btnMSubtract
            // 
            this.btnMSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMSubtract.Location = new System.Drawing.Point(276, 79);
            this.btnMSubtract.Name = "btnMSubtract";
            this.btnMSubtract.Size = new System.Drawing.Size(78, 67);
            this.btnMSubtract.TabIndex = 47;
            this.btnMSubtract.Text = "M-";
            this.btnMSubtract.UseVisualStyleBackColor = true;
            this.btnMSubtract.Click += new System.EventHandler(this.Memory_Click);
            // 
            // btnChangeSign
            // 
            this.btnChangeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeSign.Location = new System.Drawing.Point(360, 79);
            this.btnChangeSign.Name = "btnChangeSign";
            this.btnChangeSign.Size = new System.Drawing.Size(162, 67);
            this.btnChangeSign.TabIndex = 48;
            this.btnChangeSign.Text = "+/-";
            this.btnChangeSign.UseVisualStyleBackColor = true;
            this.btnChangeSign.Click += new System.EventHandler(this.btnChangeSign_Click);
            // 
            // btnRootSingleValue
            // 
            this.btnRootSingleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRootSingleValue.Location = new System.Drawing.Point(276, 259);
            this.btnRootSingleValue.Name = "btnRootSingleValue";
            this.btnRootSingleValue.Size = new System.Drawing.Size(78, 33);
            this.btnRootSingleValue.TabIndex = 49;
            this.btnRootSingleValue.Text = "√x";
            this.btnRootSingleValue.UseVisualStyleBackColor = true;
            this.btnRootSingleValue.Click += new System.EventHandler(this.btnRootSingleValue_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 454);
            this.Controls.Add(this.btnRootSingleValue);
            this.Controls.Add(this.btnChangeSign);
            this.Controls.Add(this.btnMSubtract);
            this.Controls.Add(this.btnMAdd);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.lblCurrentOperation);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Label lblCurrentOperation;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMAdd;
        private System.Windows.Forms.Button btnMSubtract;
        private System.Windows.Forms.Button btnChangeSign;
        private System.Windows.Forms.Button btnRootSingleValue;
    }
}

