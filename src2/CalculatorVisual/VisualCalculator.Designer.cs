namespace CalculatorVisual;

partial class VisualCalculator
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualCalculator));
            this.calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calc
            // 
            resources.ApplyResources(this.calc, "calc");
            this.calc.BackColor = System.Drawing.Color.Silver;
            this.calc.ForeColor = System.Drawing.Color.Red;
            this.calc.Name = "calc";
            this.calc.UseVisualStyleBackColor = false;
            this.calc.Click += new System.EventHandler(this.res_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.CausesValidation = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // number1
            // 
            resources.ApplyResources(this.number1, "number1");
            this.number1.ForeColor = System.Drawing.Color.Black;
            this.number1.Name = "number1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number_Click);
            // 
            // number2
            // 
            resources.ApplyResources(this.number2, "number2");
            this.number2.ForeColor = System.Drawing.Color.Black;
            this.number2.Name = "number2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number_Click);
            // 
            // number9
            // 
            resources.ApplyResources(this.number9, "number9");
            this.number9.ForeColor = System.Drawing.Color.Black;
            this.number9.Name = "number9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number_Click);
            // 
            // number8
            // 
            resources.ApplyResources(this.number8, "number8");
            this.number8.ForeColor = System.Drawing.Color.Black;
            this.number8.Name = "number8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number_Click);
            // 
            // number7
            // 
            resources.ApplyResources(this.number7, "number7");
            this.number7.ForeColor = System.Drawing.Color.Black;
            this.number7.Name = "number7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number_Click);
            // 
            // number6
            // 
            resources.ApplyResources(this.number6, "number6");
            this.number6.ForeColor = System.Drawing.Color.Black;
            this.number6.Name = "number6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number_Click);
            // 
            // number5
            // 
            resources.ApplyResources(this.number5, "number5");
            this.number5.ForeColor = System.Drawing.Color.Black;
            this.number5.Name = "number5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number_Click);
            // 
            // number4
            // 
            resources.ApplyResources(this.number4, "number4");
            this.number4.ForeColor = System.Drawing.Color.Black;
            this.number4.Name = "number4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number_Click);
            // 
            // number3
            // 
            resources.ApplyResources(this.number3, "number3");
            this.number3.ForeColor = System.Drawing.Color.Black;
            this.number3.Name = "number3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number_Click);
            // 
            // addition
            // 
            resources.ApplyResources(this.addition, "addition");
            this.addition.ForeColor = System.Drawing.Color.Black;
            this.addition.Name = "addition";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.sign_Click);
            // 
            // button14
            // 
            resources.ApplyResources(this.button14, "button14");
            this.button14.BackColor = System.Drawing.Color.Silver;
            this.button14.ForeColor = System.Drawing.Color.Red;
            this.button14.Name = "button14";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.clear_Click);
            // 
            // number0
            // 
            resources.ApplyResources(this.number0, "number0");
            this.number0.ForeColor = System.Drawing.Color.Black;
            this.number0.Name = "number0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number_Click);
            // 
            // division
            // 
            resources.ApplyResources(this.division, "division");
            this.division.ForeColor = System.Drawing.Color.Black;
            this.division.Name = "division";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.sign_Click);
            // 
            // multiplication
            // 
            resources.ApplyResources(this.multiplication, "multiplication");
            this.multiplication.ForeColor = System.Drawing.Color.Black;
            this.multiplication.Name = "multiplication";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.sign_Click);
            // 
            // subtraction
            // 
            resources.ApplyResources(this.subtraction, "subtraction");
            this.subtraction.ForeColor = System.Drawing.Color.Black;
            this.subtraction.Name = "subtraction";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.sign_Click);
            // 
            // VisualCalculator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.division);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calc);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "VisualCalculator";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.VisualCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button calc;
    private Label label1;
    private TextBox textBox1;
    private Button number1;
    private Button number2;
    private Button number9;
    private Button number8;
    private Button number7;
    private Button number6;
    private Button number5;
    private Button number4;
    private Button number3;
    private Button addition;
    private Button button14;
    private Button number0;
    private Button division;
    private Button multiplication;
    private Button subtraction;
}