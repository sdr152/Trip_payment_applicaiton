using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace GuiDemo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Welcome ");
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        MessageBox.Show("Button Click");
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    // Trayectoria km
    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        string txt = textBox1.Text;
    }

    // Precio Diesel galon
    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        int i = 0;
        if (double.TryParse(textBox2.Text, out double d) || int.TryParse(textBox2.Text, out i))
        {
            double precio_dep = Convert.ToDouble(textBox2.Text) * 0.25;
            textBox3.Text = precio_dep.ToString();
        }
        else
        {
            textBox2.Clear();
            textBox3.Clear();
        }
        
        

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void label8_Click(object sender, EventArgs e)
    {

    }
}
