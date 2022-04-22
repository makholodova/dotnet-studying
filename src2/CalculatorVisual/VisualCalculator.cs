namespace CalculatorVisual;

public partial class VisualCalculator : Form
{
    public VisualCalculator()
    {
        InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
    
    
    private void label1_Click(object sender, EventArgs e)
    {

    }

   /* private void number2_Click(object sender, EventArgs e)
    {
        
        if (b.Text == "2")
        {
           // 
        }
   
    }*/

    private void number_Click(object sender, EventArgs e)
    {var b = (Button)sender;
        this.textBox1.Text += b.Text;
    }

    private void sign_Click(object sender, EventArgs e)
    {

    }

    private void res_Click(object sender, EventArgs e)
    {

    }

    private void clear_Click(object sender, EventArgs e)
    {

    }

    private void VisualCalculator_Load(object sender, EventArgs e)
    {

    }
}