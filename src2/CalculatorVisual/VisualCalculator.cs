using Calculator.Core;

namespace CalculatorVisual;

public partial class VisualCalculator : Form
{
	private double? _result;
	private char _sign = default; //вопрос

	private readonly SimpleCalculator calculatorVisual = new();
	private readonly double[] nums = new double[10];

	public VisualCalculator()
	{
		InitializeComponent();
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void number_Click(object sender, EventArgs e)
	{
		var num = (Button)sender;
		textBox1.Text += num.Text;
	}

	private void label1_Click(object sender, EventArgs e)
	{
		var num = (Button)sender;
		textBox1.Text += num.Text;
	}

	private void sign_Click(object sender, EventArgs e)
	{
		var sign = (Button)sender;
		textBox1.Text += sign.Text;

		if (_result != null)
		{
			textBox1.Text = _result + sign.Text;
		}
		else if (_sign != default(char))
		{
			Aaaaa();
		}
	}

	private void res_Click(object sender, EventArgs e)
	{
		textBox1.Text += ((Button)sender).Text;
		Aaaaa();
	}

	private void clear_Click(object sender, EventArgs e)
	{
		textBox1.Text = "";
		_result = null;
		_sign = default;
	}

	private void VisualCalculator_Load(object sender, EventArgs e)
	{
	}

	private void point_Click(object sender, EventArgs e)
	{
		var num = (Button)sender;
		textBox1.Text += num.Text;
	}

	private void Aaaaa()
	{
		var numStr = "";
		var j = 0;
		double result = 0;
		var str = textBox1.Text;
		for (var i = 0; i < str.Length; i++)
		{
			var signs = "+-/*";
			if (signs.Contains(str[i]))
			{
				nums[j] = double.Parse(numStr);
				_sign = str[i];
				numStr = "";
				j++;
			}
			else if (str[i] == '=')
			{
				nums[j] = double.Parse(numStr);
			}
			else
			{
				numStr += str[i];
			}
		}

		result = calculatorVisual.Solve(_sign, nums[0], nums[1]);
		//this.textBox1.Text = result.ToString();
		textBox1.Text += result;
		_result = result;
	}
}