using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace GuiDemo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void button1_Click_1(object sender, EventArgs e)
    {
        MessageBox.Show("Button Click");
    }
    //private void button1_Click(object sender, EventArgs e)
    //{
    //    MessageBox.Show("Welcome ");
    //}


    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

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

    // Trayectoria km
    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        string txt = textBox1.Text;
        if (!double.TryParse(txt, out double d))
        {
            textBox1.Clear();
        }
    }

    // Precio Diesel galon
    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        
        if (double.TryParse(textBox2.Text, out double d) || int.TryParse(textBox2.Text, out int i))
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
    
    // Rendimiento descargado
    private void textBox11_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox11.Text, out double d))
        {
            textBox11.Clear();
        }
    }

    // Rendimiento 25%
    private void textBox10_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox10.Text, out double d))
        {
            textBox10.Clear();
        }
    }
    private void textBox9_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox9.Text, out double d))
        {
            textBox9.Clear();
        }
    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox5.Text, out double d))
        {
            textBox5.Clear();
        }
    }

    private void textBox13_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox13.Text, out double d))
        {
            textBox13.Clear();
        }
    }

    private void textBox8_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox8.Text, out double d))
        {
            textBox8.Clear();
        }
    }

    private void textBox7_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox7.Text, out double d))
        {
            textBox7.Clear();
        }
    }

    private void textBox6_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox6.Text, out double d))
        {
            textBox6.Clear();
        }
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox4.Text, out double d))
        {
            textBox4.Clear();
        }
    }

    private void textBox15_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox15.Text, out double d))
        {
            textBox15.Clear();
        }
    }

    private void textBox14_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox14.Text, out double d))
        {
            textBox14.Clear();
        }
    }

    private void textBox12_TextChanged(object sender, EventArgs e)
    {
        if (!Double.TryParse(textBox12.Text, out double d))
        {
            textBox12.Clear();
        }
    }
}
